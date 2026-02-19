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
[CqlLibrary("CMS349FHIRHIVScreening", "1.1.000")]
public partial class CMS349FHIRHIVScreening_1_1_000 : ILibrary, ISingleton<CMS349FHIRHIVScreening_1_1_000>
{
    #region ValueSets

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50", valueSetVersion: null)]
    public CqlValueSet Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_(CqlContext _) => _Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_;
    private static readonly CqlValueSet _Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("HIV 1 and 2 tests - Meaningful Use set", codeId: "75622-1", codeSystem: "http://loinc.org")]
    public CqlCode HIV_1_and_2_tests___Meaningful_Use_set(CqlContext _) => _HIV_1_and_2_tests___Meaningful_Use_set;
    private static readonly CqlCode _HIV_1_and_2_tests___Meaningful_Use_set = new CqlCode("75622-1", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _HIV_1_and_2_tests___Meaningful_Use_set]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(-1238750488277271729L, () => {
            CqlDateTime a_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, (decimal?)0.0m);
            CqlDateTime b_ = context.Operators.DateTime((int?)2027, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, (decimal?)0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
            object d_ = context.ResolveParameter("CMS349FHIRHIVScreening-1.1.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(6002561165017354265L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(8620195041208317359L, () => {
            CqlValueSet a_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet c_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
            IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
            CqlValueSet f_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet h_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
            IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
            CqlValueSet l_ = this.Office_Visit(context);
            IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);

            bool? o_(Encounter Encounter) {
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                Period r_ = Encounter?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");
                Code<Encounter.EncounterStatus> u_ = Encounter?.StatusElement;
                Encounter.EncounterStatus? v_ = u_?.Value;
                Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                bool? x_ = context.Operators.Equal(w_, "finished");
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
            return p_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(2298964704118148484L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            CqlInterval<int?> i_ = context.Operators.Interval((int?)15, (int?)65, (bool?)true, (bool?)true);
            bool? j_ = context.Operators.In<int?>(h_, i_, default);
            IEnumerable<Encounter> k_ = this.Qualifying_Encounters(context);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            bool? m_ = context.Operators.And(j_, l_);
            return m_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-733171021098403886L, () => {
            bool? a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Has HIV Test Performed")]
    public bool? Has_HIV_Test_Performed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(2944446001550422107L, () => {
            CqlValueSet a_ = this.Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_(context);
            IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            CqlCode c_ = this.HIV_1_and_2_tests___Meaningful_Use_set(context);
            IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            IEnumerable<Observation> f_ = context.Operators.Union<Observation>(b_, e_);

            bool? g_(Observation HIVTest) {
                DataType j_ = HIVTest?.Value;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                bool? l_ = context.Operators.Not((bool?)(k_ is null));
                Patient m_ = this.Patient(context);
                Date n_ = m_?.BirthDateElement;
                string o_ = n_?.Value;
                CqlDate p_ = context.Operators.ConvertStringToDate(o_);
                DataType q_ = HIVTest?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlDate u_ = context.Operators.DateFrom(t_);
                int? v_ = context.Operators.CalculateAgeAt(p_, u_, "year");
                CqlInterval<int?> w_ = context.Operators.Interval((int?)15, (int?)65, (bool?)true, (bool?)true);
                bool? x_ = context.Operators.In<int?>(v_, w_, default);
                bool? y_ = context.Operators.And(l_, x_);
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                CqlDateTime ae_ = context.Operators.End(ad_);
                bool? af_ = context.Operators.Before(ac_, ae_, "day");
                bool? ag_ = context.Operators.And(y_, af_);
                Code<ObservationStatus> ah_ = HIVTest?.StatusElement;
                ObservationStatus? ai_ = ah_?.Value;
                string aj_ = context.Operators.Convert<string>(ai_);
                bool? ak_ = context.Operators.Equal(aj_, "final");
                ObservationStatus? am_ = ah_?.Value;
                string an_ = context.Operators.Convert<string>(am_);
                bool? ao_ = context.Operators.Equal(an_, "amended");
                bool? ap_ = context.Operators.Or(ak_, ao_);
                ObservationStatus? ar_ = ah_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                bool? at_ = context.Operators.Equal(as_, "corrected");
                bool? au_ = context.Operators.Or(ap_, at_);
                bool? av_ = context.Operators.And(ag_, au_);
                return av_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            bool? i_ = context.Operators.Exists<Observation>(h_);
            return i_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-5319234006087607187L, () => {
            bool? a_ = this.Has_HIV_Test_Performed(context);
            return a_;
        });


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(6404461629041927873L, () => {
            CqlValueSet a_ = this.HIV(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object HIVDiagnosis) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.Start(k_);
                bool? m_ = context.Operators.Before(j_, l_, "day");
                bool? n_ = this.isVerified(context, HIVDiagnosis);
                bool? o_ = context.Operators.And(m_, n_);
                return o_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            bool? h_ = context.Operators.Exists<object>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Patient Expired")]
    public bool? Patient_Expired(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(2804529335998646238L, () => {
            Patient a_ = this.Patient(context);
            DataType b_ = a_?.Deceased;
            object c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
            CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
            CqlDateTime e_ = context.Operators.End(d_);
            bool? f_ = context.Operators.SameOrBefore(c_ as CqlDateTime, e_, "day");
            return f_;
        });


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(196913329891557527L, () => {
            bool? a_ = this.Patient_Expired(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(3719733758870457014L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(-4297719452549950995L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(8108146241635492532L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(7227666871515292594L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS349FHIRHIVScreening_1_1_000() {}

    public static CMS349FHIRHIVScreening_1_1_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS349FHIRHIVScreening";
    public string Version => "1.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
