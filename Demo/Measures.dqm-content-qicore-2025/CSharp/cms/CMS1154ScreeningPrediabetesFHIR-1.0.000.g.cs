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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CMS1154ScreeningPrediabetesFHIR", "1.0.000")]
public partial class CMS1154ScreeningPrediabetesFHIR_1_0_000 : ILibrary, ISingleton<CMS1154ScreeningPrediabetesFHIR_1_0_000>
{
    #region ValueSets

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

    #region Codes

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

    #region CodeSystems

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(-5866298817992680085L, () => {
            CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
            object d_ = context.ResolveParameter("CMS1154ScreeningPrediabetesFHIR-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(-7421968764374336798L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlFunctionDefinition("verified")]
    public IEnumerable<object> verified(CqlContext context, IEnumerable<object> conditions)
    {

        bool? a_(object C) {
            object c_ = context.Operators.LateBoundProperty<object>(C, "verificationStatus");
            CqlConcept d_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            CqlCode h_ = this.confirmed(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(g_, i_);
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            CqlCode m_ = this.unconfirmed(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(l_, n_);
            bool? p_ = context.Operators.Or(j_, o_);
            CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            CqlCode s_ = this.provisional(context);
            CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
            bool? u_ = context.Operators.Equivalent(r_, t_);
            bool? v_ = context.Operators.Or(p_, u_);
            CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            CqlCode y_ = this.differential(context);
            CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
            bool? aa_ = context.Operators.Equivalent(x_, z_);
            bool? ab_ = context.Operators.Or(v_, aa_);
            bool? ac_ = context.Operators.Implies(e_, ab_);
            return ac_;
        }

        IEnumerable<object> b_ = context.Operators.Where<object>(conditions, a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Advanced Illness or Limited Life Expectancy")]
    public IEnumerable<object> Has_Advanced_Illness_or_Limited_Life_Expectancy(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(1509290388530786869L, () => {
            CqlValueSet a_ = this.Advanced_Illness(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
            CqlValueSet f_ = this.Limited_Life_Expectancy(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);
            IEnumerable<object> l_ = this.verified(context, k_);

            bool? m_(object AdvancedIllness) {
                object o_ = context.Operators.LateBoundProperty<object>(AdvancedIllness, "onset");
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                bool? s_ = context.Operators.Before(p_ as CqlDateTime, r_, "day");
                return s_;
            }

            IEnumerable<object> n_ = context.Operators.Where<object>(l_, m_);
            return n_;
        });


    [CqlExpressionDefinition("Preventive Care Outpatient Visits During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Care_Outpatient_Visits_During_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-1867213146648226874L, () => {
            CqlValueSet a_ = this.Preventative_Clinical_Encounters(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? c_(Encounter PreventiveCare) {
                Period e_ = PreventiveCare?.Period;
                CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
                CqlDateTime g_ = context.Operators.End(f_);
                CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
                bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
                Code<Encounter.EncounterStatus> j_ = PreventiveCare?.StatusElement;
                Encounter.EncounterStatus? k_ = j_?.Value;
                Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
                bool? m_ = context.Operators.Equal(l_, "finished");
                bool? n_ = context.Operators.And(i_, m_);
                return n_;
            }

            IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
            return d_;
        });


    [CqlExpressionDefinition("Office Visit During the Measurement Period")]
    public IEnumerable<Encounter> Office_Visit_During_the_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-5330974653624701193L, () => {
            CqlValueSet a_ = this.Outpatient_Clinical_Encounters(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? c_(Encounter OfficeVisit) {
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                Period f_ = OfficeVisit?.Period;
                CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
                bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
                Code<Encounter.EncounterStatus> i_ = OfficeVisit?.StatusElement;
                Encounter.EncounterStatus? j_ = i_?.Value;
                Code<Encounter.EncounterStatus> k_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(j_);
                bool? l_ = context.Operators.Equal(k_, "finished");
                bool? m_ = context.Operators.And(h_, l_);
                return m_;
            }

            IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
            return d_;
        });


    [CqlExpressionDefinition("Aged 35 to 70 at Start of Measurement Period")]
    public bool? Aged_35_to_70_at_Start_of_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(6123212858979409007L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            bool? i_ = context.Operators.GreaterOrEqual(h_, 35);
            Date k_ = a_?.BirthDateElement;
            string l_ = k_?.Value;
            CqlDate m_ = context.Operators.ConvertStringToDate(l_);
            CqlDateTime o_ = context.Operators.Start(e_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            int? q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
            bool? r_ = context.Operators.LessOrEqual(q_, 70);
            bool? s_ = context.Operators.And(i_, r_);
            return s_;
        });


    [CqlExpressionDefinition("Patients Aged 35 to 70 with an Office Visit During the Measurement Period")]
    public bool? Patients_Aged_35_to_70_with_an_Office_Visit_During_the_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-7763358644582279625L, () => {
            IEnumerable<Encounter> a_ = this.Preventive_Care_Outpatient_Visits_During_Measurement_Period(context);
            bool? b_ = context.Operators.Exists<Encounter>(a_);
            IEnumerable<Encounter> c_ = this.Office_Visit_During_the_Measurement_Period(context);
            int? d_ = context.Operators.Count<Encounter>(c_);
            bool? e_ = context.Operators.GreaterOrEqual(d_, 2);
            bool? f_ = context.Operators.Or(b_, e_);
            bool? g_ = this.Aged_35_to_70_at_Start_of_Measurement_Period(context);
            bool? h_ = context.Operators.IsTrue(g_);
            bool? i_ = context.Operators.And(f_, h_);
            return i_;
        });


    [CqlExpressionDefinition("Most Recent BMI")]
    public Observation Most_Recent_BMI(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Observation>(6452276778631599383L, () => {
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
        });


    [CqlExpressionDefinition("Patient is Asian")]
    public bool? Patient_is_Asian(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(7986858896242549351L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            IEnumerable<CqlCode> b_ = a_?.codes;

            bool? c_(CqlCode C) {
                CqlCode f_ = this.Asian(context);
                bool? g_ = context.Operators.Equivalent(C, f_);
                return g_;
            }

            IEnumerable<CqlCode> d_ = context.Operators.Where<CqlCode>(b_, c_);
            bool? e_ = context.Operators.Exists<CqlCode>(d_);
            return e_;
        });


    [CqlExpressionDefinition("Patient is not Asian")]
    public bool? Patient_is_not_Asian(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-1757457377914612541L, () => {
            bool? a_ = this.Patient_is_Asian(context);
            bool? b_ = context.Operators.Not(a_);
            return b_;
        });


    [CqlExpressionDefinition("Most Recent BMI Equal to or Greater Than 25 and Is Not Asian")]
    public bool? Most_Recent_BMI_Equal_to_or_Greater_Than_25_and_Is_Not_Asian(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(5419091062142640358L, () => {
            Observation a_ = this.Most_Recent_BMI(context);
            DataType b_ = a_?.Value;
            CqlQuantity c_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, b_ as Quantity);
            CqlQuantity d_ = context.Operators.Quantity(25m, "kg/m2");
            bool? e_ = context.Operators.GreaterOrEqual(c_, d_);
            bool? f_ = this.Patient_is_not_Asian(context);
            bool? g_ = context.Operators.And(e_, f_);
            return g_;
        });


    [CqlExpressionDefinition("Most Recent BMI Equal to or Greater Than 23 and Is Asian")]
    public bool? Most_Recent_BMI_Equal_to_or_Greater_Than_23_and_Is_Asian(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-2883356292628113588L, () => {
            Observation a_ = this.Most_Recent_BMI(context);
            DataType b_ = a_?.Value;
            CqlQuantity c_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, b_ as Quantity);
            CqlQuantity d_ = context.Operators.Quantity(23m, "kg/m2");
            bool? e_ = context.Operators.GreaterOrEqual(c_, d_);
            bool? f_ = this.Patient_is_Asian(context);
            bool? g_ = context.Operators.And(e_, f_);
            return g_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(5820967484384018458L, () => {
            bool? a_ = this.Patients_Aged_35_to_70_with_an_Office_Visit_During_the_Measurement_Period(context);
            bool? b_ = this.Most_Recent_BMI_Equal_to_or_Greater_Than_25_and_Is_Not_Asian(context);
            bool? c_ = this.Most_Recent_BMI_Equal_to_or_Greater_Than_23_and_Is_Asian(context);
            bool? d_ = context.Operators.Or(b_, c_);
            bool? e_ = context.Operators.And(a_, d_);
            return e_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(709014718321169443L, () => {
            bool? a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Glycemic Laboratory Test Performed During Measurement Period")]
    public IEnumerable<Observation> Glycemic_Laboratory_Test_Performed_During_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Observation>>(4588430099918846418L, () => {
            CqlValueSet a_ = this.Glycemic_Screening_Tests(context);
            IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? c_(Observation LabTestPerformed) {
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                DataType f_ = LabTestPerformed?.Effective;
                object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.ToInterval(context, g_);
                bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
                Code<ObservationStatus> j_ = LabTestPerformed?.StatusElement;
                ObservationStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                string[] m_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                bool? o_ = context.Operators.And(i_, n_);
                return o_;
            }

            IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
            return d_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(260898604472239881L, () => {
            IEnumerable<Observation> a_ = this.Glycemic_Laboratory_Test_Performed_During_Measurement_Period(context);
            bool? b_ = context.Operators.Exists<Observation>(a_);
            return b_;
        });


    [CqlExpressionDefinition("Has Pregnancy Observation During Measurement Period")]
    public bool? Has_Pregnancy_Observation_During_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-3816791241199783336L, () => {
            IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

            bool? b_(Observation PregnantObservation) {
                DataType e_ = PregnantObservation?.Value;
                CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_ as CodeableConcept);
                CqlValueSet g_ = this.Pregnancy(context);
                bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
                DataType i_ = PregnantObservation?.Effective;
                CqlDateTime j_ = context.Operators.LateBoundProperty<CqlDateTime>(i_, "value");
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_ as object);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                bool? m_ = context.Operators.Overlaps(k_, l_, "day");
                bool? n_ = context.Operators.And(h_, m_);
                return n_;
            }

            IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
            bool? d_ = context.Operators.Exists<Observation>(c_);
            return d_;
        });


    [CqlExpressionDefinition("Has Pregnancy Diagnosis During Measurement Period")]
    public IEnumerable<object> Has_Pregnancy_Diagnosis_During_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(-3677172026540839592L, () => {
            CqlValueSet a_ = this.Pregnancy(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
            IEnumerable<object> f_ = this.verified(context, e_);

            bool? g_(object PregnancyDx) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDx);
                CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
                bool? k_ = context.Operators.Overlaps(i_, j_, "day");
                return k_;
            }

            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            return h_;
        });


    [CqlExpressionDefinition("Look Back Period")]
    public CqlInterval<CqlDateTime> Look_Back_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(2077423446850315487L, () => {
            CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
            CqlDateTime b_ = context.Operators.Start(a_);
            CqlQuantity c_ = context.Operators.Quantity(2m, "years");
            CqlDateTime d_ = context.Operators.Subtract(b_, c_);
            CqlDateTime f_ = context.Operators.Start(a_);
            CqlInterval<CqlDateTime> g_ = context.Operators.Interval(d_, f_, true, false);
            return g_;
        });


    [CqlExpressionDefinition("Prediabetes Diagnosis Overlaps 2 Year Look Back Period")]
    public IEnumerable<object> Prediabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(2046368973321817443L, () => {
            CqlValueSet a_ = this.Prediabetes__Borderline_Diabetes_(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
            IEnumerable<object> f_ = this.verified(context, e_);

            bool? g_(object PriorPrediabetes) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PriorPrediabetes);
                CqlInterval<CqlDateTime> j_ = this.Look_Back_Period(context);
                bool? k_ = context.Operators.Overlaps(i_, j_, "day");
                return k_;
            }

            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            return h_;
        });


    [CqlExpressionDefinition("Diabetes Diagnosis Overlaps 2 Year Look Back Period")]
    public IEnumerable<object> Diabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(-6618366694283717709L, () => {
            CqlValueSet a_ = this.Diabetes(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
            IEnumerable<object> f_ = this.verified(context, e_);

            bool? g_(object PriorDiabetes) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PriorDiabetes);
                CqlInterval<CqlDateTime> j_ = this.Look_Back_Period(context);
                bool? k_ = context.Operators.Overlaps(i_, j_, "day");
                return k_;
            }

            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Glycemic Laboratory Test Performed During 2 Year Look Back Period")]
    public bool? Has_Glycemic_Laboratory_Test_Performed_During_2_Year_Look_Back_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-5111289342832184703L, () => {
            CqlValueSet a_ = this.Glycemic_Screening_Tests(context);
            IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? c_(Observation LabTestPerformed) {
                CqlInterval<CqlDateTime> f_ = this.Look_Back_Period(context);
                DataType g_ = LabTestPerformed?.Effective;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.ToInterval(context, h_);
                bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");
                Code<ObservationStatus> k_ = LabTestPerformed?.StatusElement;
                ObservationStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                bool? p_ = context.Operators.And(j_, o_);
                return p_;
            }

            IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
            bool? e_ = context.Operators.Exists<Observation>(d_);
            return e_;
        });


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-7543466091754023904L, () => {
            bool? a_ = this.Has_Pregnancy_Observation_During_Measurement_Period(context);
            IEnumerable<object> b_ = this.Has_Pregnancy_Diagnosis_During_Measurement_Period(context);
            bool? c_ = context.Operators.Exists<object>(b_);
            bool? d_ = context.Operators.Or(a_, c_);
            IEnumerable<object> e_ = this.Has_Advanced_Illness_or_Limited_Life_Expectancy(context);
            bool? f_ = context.Operators.Exists<object>(e_);
            bool? g_ = context.Operators.Or(d_, f_);
            IEnumerable<object> h_ = this.Diabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period(context);
            bool? i_ = context.Operators.Exists<object>(h_);
            bool? j_ = context.Operators.Or(g_, i_);
            IEnumerable<object> k_ = this.Prediabetes_Diagnosis_Overlaps_2_Year_Look_Back_Period(context);
            bool? l_ = context.Operators.Exists<object>(k_);
            bool? m_ = context.Operators.Or(j_, l_);
            bool? n_ = this.Has_Glycemic_Laboratory_Test_Performed_During_2_Year_Look_Back_Period(context);
            bool? o_ = context.Operators.Or(m_, n_);
            return o_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(8978605305610805484L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(-6630685495481277238L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(7698772050861812561L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(-8717201137091475486L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


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
