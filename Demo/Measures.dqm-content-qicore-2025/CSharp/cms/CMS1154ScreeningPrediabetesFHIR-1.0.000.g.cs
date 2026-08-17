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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.1.0")]
[CqlLibrary("CMS1154ScreeningPrediabetesFHIR", "1.0.000")]
public partial class CMS1154ScreeningPrediabetesFHIR_1_0_000 : ILibrary, ISingleton<CMS1154ScreeningPrediabetesFHIR_1_0_000>
{
    #region ValueSets (10)

    [CqlValueSetDefinition("Advanced Illness", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext _) => _Advanced_Illness;
    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Glycemic Screening Tests", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.5", valueSetVersion: null)]
    public CqlValueSet Glycemic_Screening_Tests(CqlContext _) => _Glycemic_Screening_Tests;
    private static readonly CqlValueSet _Glycemic_Screening_Tests = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.5", null);

    [CqlValueSetDefinition("Limited Life Expectancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", valueSetVersion: null)]
    public CqlValueSet Limited_Life_Expectancy(CqlContext _) => _Limited_Life_Expectancy;
    private static readonly CqlValueSet _Limited_Life_Expectancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", null);

    [CqlValueSetDefinition("Outpatient Clinical Encounters", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.24", valueSetVersion: null)]
    public CqlValueSet Outpatient_Clinical_Encounters(CqlContext _) => _Outpatient_Clinical_Encounters;
    private static readonly CqlValueSet _Outpatient_Clinical_Encounters = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.24", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Prediabetes (Borderline Diabetes)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1222.419", valueSetVersion: null)]
    public CqlValueSet Prediabetes__Borderline_Diabetes_(CqlContext _) => _Prediabetes__Borderline_Diabetes_;
    private static readonly CqlValueSet _Prediabetes__Borderline_Diabetes_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1222.419", null);

    [CqlValueSetDefinition("Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext _) => _Pregnancy;
    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);

    [CqlValueSetDefinition("Preventative Clinical Encounters", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.13", valueSetVersion: null)]
    public CqlValueSet Preventative_Clinical_Encounters(CqlContext _) => _Preventative_Clinical_Encounters;
    private static readonly CqlValueSet _Preventative_Clinical_Encounters = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.13", null);

    #endregion ValueSets

    #region Codes (8)

    [CqlCodeDefinition("Body mass index (BMI) [Ratio]", codeId: "39156-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext _) => _Body_mass_index__BMI___Ratio_;
    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org");

    [CqlCodeDefinition("Asian", codeId: "2028-9", codeSystem: "urn:oid:2.16.840.1.113883.6.238")]
    public CqlCode Asian(CqlContext _) => _Asian;
    private static readonly CqlCode _Asian = new CqlCode("2028-9", "urn:oid:2.16.840.1.113883.6.238");

    [CqlCodeDefinition("unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode unconfirmed(CqlContext _) => _unconfirmed;
    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("provisional", codeId: "provisional", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode provisional(CqlContext _) => _provisional;
    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("differential", codeId: "differential", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode differential(CqlContext _) => _differential;
    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode confirmed(CqlContext _) => _confirmed;
    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext _) => _refuted;
    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Body_mass_index__BMI___Ratio_]);

    [CqlCodeSystemDefinition("CDCREC", codeSystemId: "urn:oid:2.16.840.1.113883.6.238", codeSystemVersion: null)]
    public CqlCodeSystem CDCREC(CqlContext _) => _CDCREC;
    private static readonly CqlCodeSystem _CDCREC =
      new CqlCodeSystem("urn:oid:2.16.840.1.113883.6.238", null, [
          _Asian]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-ver-status", codeSystemVersion: null)]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, [
          _unconfirmed,
          _provisional,
          _differential,
          _confirmed,
          _refuted,
          _entered_in_error]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -5866298817992680085L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1154ScreeningPrediabetesFHIR-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (27)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7421968764374336798L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("verified")]
    public IEnumerable<Condition> verified(CqlContext context, IEnumerable<Condition> conditions)
    {

        bool? a_(Condition C) {
            CodeableConcept c_ = C?.VerificationStatus;
            CqlConcept d_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_);

            CqlBoolean e_() {
                CodeableConcept f_ = C?.VerificationStatus;
                CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, f_);
                CqlCode h_ = this.confirmed(context);
                CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
                bool? j_ = context.Operators.Equivalent(g_, i_);

                CqlBoolean k_() {
                    CodeableConcept n_ = C?.VerificationStatus;
                    CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                    CqlCode p_ = this.unconfirmed(context);
                    CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                    bool? r_ = context.Operators.Equivalent(o_, q_);
                    return r_;
                }


                CqlBoolean l_() {
                    CodeableConcept s_ = C?.VerificationStatus;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    CqlCode u_ = this.provisional(context);
                    CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                    bool? w_ = context.Operators.Equivalent(t_, v_);
                    return w_;
                }


                CqlBoolean m_() {
                    CodeableConcept x_ = C?.VerificationStatus;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlCode z_ = this.differential(context);
                    CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                    bool? ab_ = context.Operators.Equivalent(y_, aa_);
                    return ab_;
                }

                return /* CQL 'or' (42:52-46:5) */ (/* CQL 'or' (42:54-44:47) */ (/* CQL 'or' (42:54-43:47) */ ((CqlBoolean)j_
                    || k_())
                    || l_())
                    || m_());
            }

            return /* CQL 'implies' (42:5-46:5) */ ((CqlBoolean)(!(!((bool?)(d_ is null))))
                || e_());
        }

        IEnumerable<Condition> b_ = context.Operators.Where<Condition>(conditions, a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Advanced Illness or Limited Life Expectancy")]
    public IEnumerable<Condition> Has_Advanced_Illness_or_Limited_Life_Expectancy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Advanced_Illness_or_Limited_Life_Expectancy, Has_Advanced_Illness_or_Limited_Life_Expectancy_Compute);

    private const long _cacheIndex_Has_Advanced_Illness_or_Limited_Life_Expectancy = 1509290388530786869L;

    private IEnumerable<Condition> Has_Advanced_Illness_or_Limited_Life_Expectancy_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Advanced_Illness(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.Limited_Life_Expectancy(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);
        IEnumerable<Condition> j_ = this.verified(context, i_);

        bool? k_(Condition AdvancedIllness) {
            DataType m_ = AdvancedIllness?.Onset;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            CqlDateTime p_ = context.Operators.End(o_);
            bool? q_ = context.Operators.Before(n_ as CqlDateTime, p_, "day");
            return q_;
        }

        IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Preventive Care Outpatient Visits During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Care_Outpatient_Visits_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Preventive_Care_Outpatient_Visits_During_Measurement_Period, Preventive_Care_Outpatient_Visits_During_Measurement_Period_Compute);

    private const long _cacheIndex_Preventive_Care_Outpatient_Visits_During_Measurement_Period = -1867213146648226874L;

    private IEnumerable<Encounter> Preventive_Care_Outpatient_Visits_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Preventative_Clinical_Encounters(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter PreventiveCare) {
            Period e_ = PreventiveCare?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");

            CqlBoolean j_() {
                Code<Encounter.EncounterStatus> k_ = PreventiveCare?.StatusElement;
                Encounter.EncounterStatus? l_ = k_?.Value;
                Code<Encounter.EncounterStatus> m_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(l_);
                bool? n_ = context.Operators.Equal(m_, "finished");
                return n_;
            }

            return /* CQL 'and' (81:5-82:44) */ ((CqlBoolean)i_
                && j_());
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Office Visit During the Measurement Period")]
    public IEnumerable<Encounter> Office_Visit_During_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Office_Visit_During_the_Measurement_Period, Office_Visit_During_the_Measurement_Period_Compute);

    private const long _cacheIndex_Office_Visit_During_the_Measurement_Period = -5330974653624701193L;

    private IEnumerable<Encounter> Office_Visit_During_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Outpatient_Clinical_Encounters(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter OfficeVisit) {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            Period f_ = OfficeVisit?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");

            CqlBoolean i_() {
                Code<Encounter.EncounterStatus> j_ = OfficeVisit?.StatusElement;
                Encounter.EncounterStatus? k_ = j_?.Value;
                Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
                bool? m_ = context.Operators.Equal(l_, "finished");
                return m_;
            }

            return /* CQL 'and' (100:5-101:41) */ ((CqlBoolean)h_
                && i_());
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Aged 35 to 70 at Start of Measurement Period")]
    public bool? Aged_35_to_70_at_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Aged_35_to_70_at_Start_of_Measurement_Period, Aged_35_to_70_at_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Aged_35_to_70_at_Start_of_Measurement_Period = 6123212858979409007L;

    private bool? Aged_35_to_70_at_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 35);

        CqlBoolean j_() {
            Patient k_ = this.Patient(context);
            Date l_ = k_?.BirthDateElement;
            string m_ = l_?.Value;
            CqlDate n_ = context.Operators.ConvertStringToDate(m_);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlDate q_ = context.Operators.DateFrom(p_);
            int? r_ = context.Operators.CalculateAgeAt(n_, q_, "year");
            bool? s_ = context.Operators.LessOrEqual(r_, 70);
            return s_;
        }

        return /* CQL 'and' (145:3-145:75) */ ((CqlBoolean)i_
            && j_());
    }


    [CqlExpressionDefinition("Patients Aged 35 to 70 with an Office Visit During the Measurement Period")]
    public bool? Patients_Aged_35_to_70_with_an_Office_Visit_During_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patients_Aged_35_to_70_with_an_Office_Visit_During_the_Measurement_Period, Patients_Aged_35_to_70_with_an_Office_Visit_During_the_Measurement_Period_Compute);

    private const long _cacheIndex_Patients_Aged_35_to_70_with_an_Office_Visit_During_the_Measurement_Period = -7763358644582279625L;

    private bool? Patients_Aged_35_to_70_with_an_Office_Visit_During_the_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Preventive_Care_Outpatient_Visits_During_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<Encounter>(a_);

        CqlBoolean c_() {
            IEnumerable<Encounter> d_ = this.Office_Visit_During_the_Measurement_Period(context);
            int? e_ = context.Operators.Count<Encounter>(d_);
            bool? f_ = context.Operators.GreaterOrEqual(e_, 2);
            return f_;
        }

        return /* CQL 'and' (104:3-107:62) */ (/* CQL 'or' (104:3-106:3) */ ((CqlBoolean)b_
            || c_())
            && (CqlBoolean)((bool?)(/* CQL 'is true' (107:9-107:62) */ (this.Aged_35_to_70_at_Start_of_Measurement_Period(context)) is true)));
    }


    [CqlExpressionDefinition("Most Recent BMI")]
    public Observation Most_Recent_BMI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_BMI, Most_Recent_BMI_Compute);

    private const long _cacheIndex_Most_Recent_BMI = 6452276778631599383L;

    private Observation Most_Recent_BMI_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

        bool? b_(Observation BMI) {
            Code<ObservationStatus> g_ = BMI?.StatusElement;
            ObservationStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            string[] j_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            return k_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType l_ = @this?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            return o_;
        }

        IEnumerable<Observation> e_ = context.Operators.SortBy<Observation>(c_, d_, System.ComponentModel.ListSortDirection.Descending);
        Observation f_ = context.Operators.First<Observation>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Patient is Asian")]
    public bool? Patient_is_Asian(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_is_Asian, Patient_is_Asian_Compute);

    private const long _cacheIndex_Patient_is_Asian = 7986858896242549351L;

    private bool? Patient_is_Asian_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        IEnumerable<CqlCode> b_ = a_?.codes;

        bool? c_(CqlCode C) {
            CqlCode e_ = this.Asian(context);
            bool? f_ = context.Operators.Equivalent(C, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<CqlCode>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Patient is not Asian")]
    public bool? Patient_is_not_Asian(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_is_not_Asian, Patient_is_not_Asian_Compute);

    private const long _cacheIndex_Patient_is_not_Asian = -1757457377914612541L;

    private bool? Patient_is_not_Asian_Compute(CqlContext context)
    {
        bool? a_ = this.Patient_is_Asian(context);
        return !a_;
    }


    [CqlExpressionDefinition("Most Recent BMI Equal to or Greater Than 25 and Is Not Asian")]
    public bool? Most_Recent_BMI_Equal_to_or_Greater_Than_25_and_Is_Not_Asian(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_BMI_Equal_to_or_Greater_Than_25_and_Is_Not_Asian, Most_Recent_BMI_Equal_to_or_Greater_Than_25_and_Is_Not_Asian_Compute);

    private const long _cacheIndex_Most_Recent_BMI_Equal_to_or_Greater_Than_25_and_Is_Not_Asian = 5419091062142640358L;

    private bool? Most_Recent_BMI_Equal_to_or_Greater_Than_25_and_Is_Not_Asian_Compute(CqlContext context)
    {
        Observation a_ = this.Most_Recent_BMI(context);
        DataType b_ = a_?.Value;
        CqlQuantity c_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, b_ as Quantity);
        CqlQuantity d_ = context.Operators.Quantity(25m, "kg/m2");
        bool? e_ = context.Operators.GreaterOrEqual(c_, d_);
        return /* CQL 'and' (89:3-90:30) */ ((CqlBoolean)e_
            && (CqlBoolean)(this.Patient_is_not_Asian(context)));
    }


    [CqlExpressionDefinition("Most Recent BMI Equal to or Greater Than 23 and Is Asian")]
    public bool? Most_Recent_BMI_Equal_to_or_Greater_Than_23_and_Is_Asian(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_BMI_Equal_to_or_Greater_Than_23_and_Is_Asian, Most_Recent_BMI_Equal_to_or_Greater_Than_23_and_Is_Asian_Compute);

    private const long _cacheIndex_Most_Recent_BMI_Equal_to_or_Greater_Than_23_and_Is_Asian = -2883356292628113588L;

    private bool? Most_Recent_BMI_Equal_to_or_Greater_Than_23_and_Is_Asian_Compute(CqlContext context)
    {
        Observation a_ = this.Most_Recent_BMI(context);
        DataType b_ = a_?.Value;
        CqlQuantity c_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, b_ as Quantity);
        CqlQuantity d_ = context.Operators.Quantity(23m, "kg/m2");
        bool? e_ = context.Operators.GreaterOrEqual(c_, d_);
        return /* CQL 'and' (85:3-86:26) */ ((CqlBoolean)e_
            && (CqlBoolean)(this.Patient_is_Asian(context)));
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 5820967484384018458L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Patients_Aged_35_to_70_with_an_Office_Visit_During_the_Measurement_Period(context);

        CqlBoolean b_() {
            bool? c_ = this.Most_Recent_BMI_Equal_to_or_Greater_Than_25_and_Is_Not_Asian(context);
            return /* CQL 'or' (94:9-96:5) */ ((CqlBoolean)c_
                || (CqlBoolean)(this.Most_Recent_BMI_Equal_to_or_Greater_Than_23_and_Is_Asian(context)));
        }

        return /* CQL 'and' (93:3-96:5) */ ((CqlBoolean)a_
            && b_());
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 709014718321169443L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Glycemic Laboratory Test Performed During Measurement Period")]
    public IEnumerable<Observation> Glycemic_Laboratory_Test_Performed_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Glycemic_Laboratory_Test_Performed_During_Measurement_Period, Glycemic_Laboratory_Test_Performed_During_Measurement_Period_Compute);

    private const long _cacheIndex_Glycemic_Laboratory_Test_Performed_During_Measurement_Period = 4588430099918846418L;

    private IEnumerable<Observation> Glycemic_Laboratory_Test_Performed_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Glycemic_Screening_Tests(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation LabTestPerformed) {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            DataType f_ = LabTestPerformed?.Effective;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");

            CqlBoolean j_() {
                Code<ObservationStatus> k_ = LabTestPerformed?.StatusElement;
                ObservationStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                return o_;
            }

            return /* CQL 'and' (61:5-62:72) */ ((CqlBoolean)i_
                && j_());
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 260898604472239881L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Laboratory_Test_Performed_During_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Pregnancy Observation During Measurement Period")]
    public bool? Has_Pregnancy_Observation_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Pregnancy_Observation_During_Measurement_Period, Has_Pregnancy_Observation_During_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Pregnancy_Observation_During_Measurement_Period = -3816791241199783336L;

    private bool? Has_Pregnancy_Observation_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

        bool? b_(Observation PregnantObservation) {
            DataType d_ = PregnantObservation?.Value;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_ as CodeableConcept);
            CqlValueSet f_ = this.Pregnancy(context);
            bool? g_ = context.Operators.ConceptInValueSet(e_, f_);

            CqlBoolean h_() {
                DataType i_ = PregnantObservation?.Effective;
                CqlDateTime j_ = context.Operators.LateBoundProperty<CqlDateTime>(i_, "value");
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                bool? m_ = context.Operators.Overlaps(k_, l_, "day");
                return m_;
            }

            return /* CQL 'and' (69:7-70:93) */ ((CqlBoolean)g_
                && h_());
        }

        bool? c_ = context.Operators.WhereAny<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Pregnancy Diagnosis During Measurement Period")]
    public IEnumerable<Condition> Has_Pregnancy_Diagnosis_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Pregnancy_Diagnosis_During_Measurement_Period, Has_Pregnancy_Diagnosis_During_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Pregnancy_Diagnosis_During_Measurement_Period = -3677172026540839592L;

    private IEnumerable<Condition> Has_Pregnancy_Diagnosis_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = this.verified(context, d_);

        bool? f_(Condition PregnancyDx) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDx);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            bool? j_ = context.Operators.Overlaps(h_, i_, "day");
            return j_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Look Back Period")]
    public CqlInterval<CqlDateTime> Look_Back_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Look_Back_Period, Look_Back_Period_Compute);

    private const long _cacheIndex_Look_Back_Period = 2077423446850315487L;

    private CqlInterval<CqlDateTime> Look_Back_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlQuantity c_ = context.Operators.Quantity(2m, "years");
        CqlDateTime d_ = context.Operators.Subtract(b_, c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.Interval(d_, b_, true, false);
        return e_;
    }


    [CqlExpressionDefinition("Prediabetes Diagnosis Overlaps 2 Year Look Back Period")]
    public IEnumerable<Condition> Prediabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Prediabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period, Prediabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period_Compute);

    private const long _cacheIndex_Prediabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period = 2046368973321817443L;

    private IEnumerable<Condition> Prediabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prediabetes__Borderline_Diabetes_(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = this.verified(context, d_);

        bool? f_(Condition PriorPrediabetes) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PriorPrediabetes);
            CqlInterval<CqlDateTime> i_ = this.Look_Back_Period(context);
            bool? j_ = context.Operators.Overlaps(h_, i_, "day");
            return j_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Diabetes Diagnosis Overlaps 2 Year Look Back Period")]
    public IEnumerable<Condition> Diabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Diabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period, Diabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period_Compute);

    private const long _cacheIndex_Diabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period = -6618366694283717709L;

    private IEnumerable<Condition> Diabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Diabetes(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = this.verified(context, d_);

        bool? f_(Condition PriorDiabetes) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PriorDiabetes);
            CqlInterval<CqlDateTime> i_ = this.Look_Back_Period(context);
            bool? j_ = context.Operators.Overlaps(h_, i_, "day");
            return j_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Glycemic Laboratory Test Performed During 2 Year Look Back Period")]
    public bool? Has_Glycemic_Laboratory_Test_Performed_During_2_Year_Look_Back_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Glycemic_Laboratory_Test_Performed_During_2_Year_Look_Back_Period, Has_Glycemic_Laboratory_Test_Performed_During_2_Year_Look_Back_Period_Compute);

    private const long _cacheIndex_Has_Glycemic_Laboratory_Test_Performed_During_2_Year_Look_Back_Period = -5111289342832184703L;

    private bool? Has_Glycemic_Laboratory_Test_Performed_During_2_Year_Look_Back_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Glycemic_Screening_Tests(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation LabTestPerformed) {
            CqlInterval<CqlDateTime> e_ = this.Look_Back_Period(context);
            DataType f_ = LabTestPerformed?.Effective;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");

            CqlBoolean j_() {
                Code<ObservationStatus> k_ = LabTestPerformed?.StatusElement;
                ObservationStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                return o_;
            }

            return /* CQL 'and' (131:7-132:74) */ ((CqlBoolean)i_
                && j_());
        }

        bool? d_ = context.Operators.WhereAny<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -7543466091754023904L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Pregnancy_Observation_During_Measurement_Period(context);

        CqlBoolean b_() {
            IEnumerable<Condition> f_ = this.Has_Pregnancy_Diagnosis_During_Measurement_Period(context);
            bool? g_ = context.Operators.Exists<Condition>(f_);
            return g_;
        }


        CqlBoolean c_() {
            IEnumerable<Condition> h_ = this.Has_Advanced_Illness_or_Limited_Life_Expectancy(context);
            bool? i_ = context.Operators.Exists<Condition>(h_);
            return i_;
        }


        CqlBoolean d_() {
            IEnumerable<Condition> j_ = this.Diabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period(context);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }


        CqlBoolean e_() {
            IEnumerable<Condition> l_ = this.Prediabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period(context);
            bool? m_ = context.Operators.Exists<Condition>(l_);
            return m_;
        }

        return /* CQL 'or' (116:3-121:78) */ (/* CQL 'or' (116:3-120:70) */ (/* CQL 'or' (116:3-119:67) */ (/* CQL 'or' (116:3-118:63) */ (/* CQL 'or' (116:3-117:65) */ ((CqlBoolean)a_
            || b_())
            || c_())
            || d_())
            || e_())
            || (CqlBoolean)(this.Has_Glycemic_Laboratory_Test_Performed_During_2_Year_Look_Back_Period(context)));
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 8978605305610805484L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -6630685495481277238L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 7698772050861812561L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -8717201137091475486L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1154ScreeningPrediabetesFHIR_1_0_000() {}

    public static CMS1154ScreeningPrediabetesFHIR_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1154ScreeningPrediabetesFHIR";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
