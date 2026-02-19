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
[CqlLibrary("CMS139FHIRFallRiskScreening", "1.0.000")]
public partial class CMS139FHIRFallRiskScreening_1_0_000 : ILibrary, ISingleton<CMS139FHIRFallRiskScreening_1_0_000>
{
    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Audiology Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1066", valueSetVersion: null)]
    public CqlValueSet Audiology_Visit(CqlContext _) => _Audiology_Visit;
    private static readonly CqlValueSet _Audiology_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1066", null);

    [CqlValueSetDefinition("Care Services in Long Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Discharge Services Nursing Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Nursing_Facility(CqlContext _) => _Discharge_Services_Nursing_Facility;
    private static readonly CqlValueSet _Discharge_Services_Nursing_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", null);

    [CqlValueSetDefinition("Falls Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1028", valueSetVersion: null)]
    public CqlValueSet Falls_Screening(CqlContext _) => _Falls_Screening;
    private static readonly CqlValueSet _Falls_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1028", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Occupational Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", valueSetVersion: null)]
    public CqlValueSet Occupational_Therapy_Evaluation(CqlContext _) => _Occupational_Therapy_Evaluation;
    private static readonly CqlValueSet _Occupational_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Physical Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", valueSetVersion: null)]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext _) => _Physical_Therapy_Evaluation;
    private static readonly CqlValueSet _Physical_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(4485116177554130861L, () => {
            CqlDateTime a_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, (decimal?)0.0m);
            CqlDateTime b_ = context.Operators.DateTime((int?)2027, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, (decimal?)0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
            object d_ = context.ResolveParameter("CMS139FHIRFallRiskScreening-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(3286081438940335178L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-1489028892183112824L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(403733070252259323L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-4903960086876782901L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(-3453658353872164592L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-2549576116253986340L, () => {
            CqlValueSet a_ = this.Office_Visit(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet c_ = this.Annual_Wellness_Visit(context);
            IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
            CqlValueSet f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet h_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
            IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
            CqlValueSet l_ = this.Home_Healthcare_Services(context);
            IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet n_ = this.Ophthalmological_Services(context);
            IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
            IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
            CqlValueSet r_ = this.Preventive_Care_Services_Individual_Counseling(context);
            IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet t_ = this.Discharge_Services_Nursing_Facility(context);
            IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
            IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
            CqlValueSet x_ = this.Nursing_Facility_Visit(context);
            IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet z_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
            IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
            IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
            CqlValueSet ad_ = this.Audiology_Visit(context);
            IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet af_ = this.Telephone_Visits(context);
            IEnumerable<Encounter> ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> ah_ = context.Operators.Union<Encounter>(ae_, ag_);
            IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ac_, ah_);
            CqlValueSet aj_ = this.Virtual_Encounter(context);
            IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet al_ = this.Physical_Therapy_Evaluation(context);
            IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);
            IEnumerable<Encounter> ao_ = context.Operators.Union<Encounter>(ai_, an_);
            CqlValueSet ap_ = this.Occupational_Therapy_Evaluation(context);
            IEnumerable<Encounter> aq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> ar_ = context.Operators.Union<Encounter>(ao_, aq_);
            IEnumerable<Encounter> as_ = Status_1_15_000.Instance.isEncounterPerformed(context, ar_);

            bool? at_(Encounter ValidEncounter) {
                CqlInterval<CqlDateTime> av_ = this.Measurement_Period(context);
                Period aw_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                bool? ay_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(av_, ax_, "day");
                return ay_;
            }

            IEnumerable<Encounter> au_ = context.Operators.Where<Encounter>(as_, at_);
            return au_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(3418199125207930874L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            bool? i_ = context.Operators.GreaterOrEqual(h_, 65);
            IEnumerable<Encounter> j_ = this.Qualifying_Encounter(context);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            bool? l_ = context.Operators.And(i_, k_);
            return l_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(1157435569036478270L, () => {
            bool? a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(8248066958237376319L, () => {
            bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
            return a_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-7798947002390531529L, () => {
            CqlValueSet a_ = this.Falls_Screening(context);
            IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> c_ = Status_1_15_000.Instance.isAssessmentPerformed(context, b_);

            bool? d_(Observation FallsScreening) {
                CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
                DataType h_ = FallsScreening?.Effective;
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");
                return k_;
            }

            IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
            bool? f_ = context.Operators.Exists<Observation>(e_);
            return f_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS139FHIRFallRiskScreening_1_0_000() {}

    public static CMS139FHIRFallRiskScreening_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS139FHIRFallRiskScreening";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
