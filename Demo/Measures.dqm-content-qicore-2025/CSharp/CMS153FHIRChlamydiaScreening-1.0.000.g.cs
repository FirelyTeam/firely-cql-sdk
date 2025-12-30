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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS153FHIRChlamydiaScreening", "1.0.000")]
public partial class CMS153FHIRChlamydiaScreening_1_0_000 : ILibrary, ISingleton<CMS153FHIRChlamydiaScreening_1_0_000>
{
    private CMS153FHIRChlamydiaScreening_1_0_000() {}

    public static CMS153FHIRChlamydiaScreening_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS153FHIRChlamydiaScreening";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheVersion, cqlContextCacheVersion))
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Chlamydia Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", valueSetVersion: null)]
    public CqlValueSet Chlamydia_Screening(CqlContext _) => _Chlamydia_Screening;
    private static readonly CqlValueSet _Chlamydia_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", null);

    [CqlValueSetDefinition("Complications of Pregnancy, Childbirth and the Puerperium", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", valueSetVersion: null)]
    public CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium(CqlContext _) => _Complications_of_Pregnancy__Childbirth_and_the_Puerperium;
    private static readonly CqlValueSet _Complications_of_Pregnancy__Childbirth_and_the_Puerperium = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", null);

    [CqlValueSetDefinition("Contraceptive Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", valueSetVersion: null)]
    public CqlValueSet Contraceptive_Medications(CqlContext _) => _Contraceptive_Medications;
    private static readonly CqlValueSet _Contraceptive_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", null);

    [CqlValueSetDefinition("Diagnoses Used to Indicate Sexual Activity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", valueSetVersion: null)]
    public CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity(CqlContext _) => _Diagnoses_Used_to_Indicate_Sexual_Activity;
    private static readonly CqlValueSet _Diagnoses_Used_to_Indicate_Sexual_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", null);

    [CqlValueSetDefinition("Diagnostic Studies During Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", valueSetVersion: null)]
    public CqlValueSet Diagnostic_Studies_During_Pregnancy(CqlContext _) => _Diagnostic_Studies_During_Pregnancy;
    private static readonly CqlValueSet _Diagnostic_Studies_During_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Isotretinoin", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", valueSetVersion: null)]
    public CqlValueSet Isotretinoin(CqlContext _) => _Isotretinoin;
    private static readonly CqlValueSet _Isotretinoin = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", null);

    [CqlValueSetDefinition("Lab Tests During Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", valueSetVersion: null)]
    public CqlValueSet Lab_Tests_During_Pregnancy(CqlContext _) => _Lab_Tests_During_Pregnancy;
    private static readonly CqlValueSet _Lab_Tests_During_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", null);

    [CqlValueSetDefinition("Lab Tests for Sexually Transmitted Infections", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", valueSetVersion: null)]
    public CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections(CqlContext _) => _Lab_Tests_for_Sexually_Transmitted_Infections;
    private static readonly CqlValueSet _Lab_Tests_for_Sexually_Transmitted_Infections = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pap Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext _) => _Pap_Test;
    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlValueSetDefinition("Pregnancy Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", valueSetVersion: null)]
    public CqlValueSet Pregnancy_Test(CqlContext _) => _Pregnancy_Test;
    private static readonly CqlValueSet _Pregnancy_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Procedures Used to Indicate Sexual Activity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", valueSetVersion: null)]
    public CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity(CqlContext _) => _Procedures_Used_to_Indicate_Sexual_Activity;
    private static readonly CqlValueSet _Procedures_Used_to_Indicate_Sexual_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("XRay Study", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", valueSetVersion: null)]
    public CqlValueSet XRay_Study(CqlContext _) => _XRay_Study;
    private static readonly CqlValueSet _XRay_Study = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Female (finding)", codeId: "248152002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Female__finding_(CqlContext _) => _Female__finding_;
    private static readonly CqlCode _Female__finding_ = new CqlCode("248152002", "http://snomed.info/sct");

    [CqlCodeDefinition("Have you ever had vaginal intercourse [PhenX]", codeId: "64728-9", codeSystem: "http://loinc.org")]
    public CqlCode Have_you_ever_had_vaginal_intercourse__PhenX_(CqlContext _) => _Have_you_ever_had_vaginal_intercourse__PhenX_;
    private static readonly CqlCode _Have_you_ever_had_vaginal_intercourse__PhenX_ = new CqlCode("64728-9", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Have_you_ever_had_vaginal_intercourse__PhenX_]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Female__finding_,
          _Yes__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS153FHIRChlamydiaScreening-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounters_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        _Qualifying_Encounters_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Office_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                CqlValueSet l_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
                IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet n_ = this.Home_Healthcare_Services(context);
                IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
                IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
                CqlValueSet r_ = this.Telephone_Visits(context);
                IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet t_ = this.Virtual_Encounter(context);
                IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
                IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
                IEnumerable<Encounter> x_ = Status_1_15_000.Instance.isEncounterPerformed(context, w_);

                bool? y_(Encounter ValidEncounters) {
                    CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                    Period ab_ = ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                    bool? ad_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aa_, ac_, "day");
                    return ad_;
                }

                IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(x_, y_);
                return z_;
            });


    private Cached<bool?> _Has_Assessments_Identifying_Sexual_Activity_Cached = new();

    [CqlExpressionDefinition("Has Assessments Identifying Sexual Activity")]
    public bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context) =>
        _Has_Assessments_Identifying_Sexual_Activity_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
                IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

                bool? e_(Observation SexualActivityAssessment) {
                    DataType h_ = SexualActivityAssessment?.Value;
                    object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                    CqlCode j_ = this.Yes__qualifier_value_(context);
                    CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                    bool? l_ = context.Operators.Equivalent(i_ as CqlConcept, k_);
                    DataType m_ = SexualActivityAssessment?.Effective;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);

                    CqlInterval<CqlDateTime> p_() {

                        bool s_() {
                            CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                            CqlDateTime u_ = context.Operators.End(t_);
                            return u_ is null;
                        }

                        if (s_())
                        {
                            return default;
                        }
                        else
                        {
                            CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                            CqlDateTime w_ = context.Operators.End(v_);
                            CqlDateTime y_ = context.Operators.End(v_);
                            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);
                            return z_;
                        };
                    }

                    bool? q_ = context.Operators.SameOrBefore(o_, p_(), default);
                    bool? r_ = context.Operators.And(l_, q_);
                    return r_;
                }

                IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
                bool? g_ = context.Operators.Exists<Observation>(f_);
                return g_;
            });


    private Cached<bool?> _Has_Diagnoses_Identifying_Sexual_Activity_Cached = new();

    [CqlExpressionDefinition("Has Diagnoses Identifying Sexual Activity")]
    public bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context) =>
        _Has_Diagnoses_Identifying_Sexual_Activity_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                CqlValueSet f_ = this.HIV(context);
                IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
                IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);
                CqlValueSet l_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
                IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> n_ = context.Operators.Union<object>(k_ as IEnumerable<object>, m_ as IEnumerable<object>);
                IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> q_ = context.Operators.Union<object>(n_ as IEnumerable<object>, p_ as IEnumerable<object>);
                IEnumerable<object> r_ = Status_1_15_000.Instance.verified(context, q_);

                bool? s_(object SexualActivityDiagnosis) {
                    CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SexualActivityDiagnosis);
                    CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                    bool? x_ = context.Operators.Overlaps(v_, w_, default);
                    return x_;
                }

                IEnumerable<object> t_ = context.Operators.Where<object>(r_, s_);
                bool? u_ = context.Operators.Exists<object>(t_);
                return u_;
            });


    private Cached<bool?> _Has_Active_Contraceptive_Medications_Cached = new();

    [CqlExpressionDefinition("Has Active Contraceptive Medications")]
    public bool? Has_Active_Contraceptive_Medications(CqlContext context) =>
        _Has_Active_Contraceptive_Medications_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Contraceptive_Medications(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? l_(Medication M) {
                        object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                        string s_ = context.Operators.Last<string>(r_);
                        bool? t_ = context.Operators.Equal(p_, s_);
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Contraceptive_Medications(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                        bool? y_ = context.Operators.And(t_, x_);
                        return y_;
                    }

                    IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
                    MedicationRequest n_(Medication M) => MR;
                    IEnumerable<MedicationRequest> o_ = context.Operators.Select<Medication, MedicationRequest>(m_, n_);
                    return o_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationActive(context, f_);

                bool? h_(MedicationRequest ActiveContraceptives) {
                    CqlInterval<CqlDate> z_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
                    CqlDate aa_ = z_?.low;
                    CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                    CqlDate ad_ = z_?.high;
                    CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
                    bool? ag_ = z_?.lowClosed;
                    bool? ai_ = z_?.highClosed;
                    CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ab_, ae_, ag_, ai_);
                    CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
                    bool? al_ = context.Operators.Overlaps(aj_, ak_, default);
                    return al_;
                }

                IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
                bool? j_ = context.Operators.Exists<MedicationRequest>(i_);
                return j_;
            });


    private Cached<bool?> _Has_Ordered_Contraceptive_Medications_Cached = new();

    [CqlExpressionDefinition("Has Ordered Contraceptive Medications")]
    public bool? Has_Ordered_Contraceptive_Medications(CqlContext context) =>
        _Has_Ordered_Contraceptive_Medications_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Contraceptive_Medications(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? l_(Medication M) {
                        object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                        string s_ = context.Operators.Last<string>(r_);
                        bool? t_ = context.Operators.Equal(p_, s_);
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Contraceptive_Medications(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                        bool? y_ = context.Operators.And(t_, x_);
                        return y_;
                    }

                    IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
                    MedicationRequest n_(Medication M) => MR;
                    IEnumerable<MedicationRequest> o_ = context.Operators.Select<Medication, MedicationRequest>(m_, n_);
                    return o_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

                bool? h_(MedicationRequest OrderedContraceptives) {
                    CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
                    FhirDateTime aa_ = OrderedContraceptives?.AuthoredOnElement;
                    CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
                    CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_ as object);
                    bool? ad_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ac_, "day");
                    return ad_;
                }

                IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
                bool? j_ = context.Operators.Exists<MedicationRequest>(i_);
                return j_;
            });


    private Cached<bool?> _Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy_Cached = new();

    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context) =>
        _Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Pap_Test(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                CqlValueSet c_ = this.Lab_Tests_During_Pregnancy(context);
                IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
                CqlValueSet f_ = this.Lab_Tests_for_Sexually_Transmitted_Infections(context);
                IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                IEnumerable<ServiceRequest> h_ = context.Operators.Union<ServiceRequest>(e_, g_);
                IEnumerable<ServiceRequest> i_ = Status_1_15_000.Instance.isLaboratoryTestOrder(context, h_);

                bool? j_(ServiceRequest LabOrders) {
                    CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                    FhirDateTime n_ = LabOrders?.AuthoredOnElement;
                    CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                    CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_ as object);
                    bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");
                    return q_;
                }

                IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
                bool? l_ = context.Operators.Exists<ServiceRequest>(k_);
                return l_;
            });


    private Cached<bool?> _Has_Laboratory_Tests_Identifying_Sexual_Activity_Cached = new();

    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context) =>
        _Has_Laboratory_Tests_Identifying_Sexual_Activity_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Pregnancy_Test(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                IEnumerable<ServiceRequest> c_ = Status_1_15_000.Instance.isLaboratoryTestOrder(context, b_);

                bool? d_(ServiceRequest PregnancyTest) {
                    CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
                    FhirDateTime j_ = PregnancyTest?.AuthoredOnElement;
                    CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                    CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_ as object);
                    bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, l_, "day");
                    return m_;
                }

                IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
                bool? f_ = context.Operators.Exists<ServiceRequest>(e_);
                bool? g_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
                bool? h_ = context.Operators.Or(f_, g_);
                return h_;
            });


    private Cached<bool?> _Has_Diagnostic_Studies_Identifying_Sexual_Activity_Cached = new();

    [CqlExpressionDefinition("Has Diagnostic Studies Identifying Sexual Activity")]
    public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context) =>
        _Has_Diagnostic_Studies_Identifying_Sexual_Activity_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Diagnostic_Studies_During_Pregnancy(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                IEnumerable<ServiceRequest> c_ = Status_1_15_000.Instance.isDiagnosticStudyOrder(context, b_);

                bool? d_(ServiceRequest SexualActivityDiagnostics) {
                    CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
                    FhirDateTime h_ = SexualActivityDiagnostics?.AuthoredOnElement;
                    CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                    CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_ as object);
                    bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");
                    return k_;
                }

                IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
                bool? f_ = context.Operators.Exists<ServiceRequest>(e_);
                return f_;
            });


    private Cached<bool?> _Has_Procedures_Identifying_Sexual_Activity_Cached = new();

    [CqlExpressionDefinition("Has Procedures Identifying Sexual Activity")]
    public bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context) =>
        _Has_Procedures_Identifying_Sexual_Activity_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
                IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

                bool? d_(Procedure ProceduresForSexualActivity) {
                    CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);

                    object h_() {

                        bool k_() {
                            DataType o_ = ProceduresForSexualActivity?.Performed;
                            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                            bool q_ = p_ is CqlDateTime;
                            return q_;
                        }


                        bool l_() {
                            DataType r_ = ProceduresForSexualActivity?.Performed;
                            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                            bool t_ = s_ is CqlInterval<CqlDateTime>;
                            return t_;
                        }


                        bool m_() {
                            DataType u_ = ProceduresForSexualActivity?.Performed;
                            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                            bool w_ = v_ is CqlQuantity;
                            return w_;
                        }


                        bool n_() {
                            DataType x_ = ProceduresForSexualActivity?.Performed;
                            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                            bool z_ = y_ is CqlInterval<CqlQuantity>;
                            return z_;
                        }

                        if (k_())
                        {
                            DataType aa_ = ProceduresForSexualActivity?.Performed;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            return (ab_ as CqlDateTime) as object;
                        }
                        else if (l_())
                        {
                            DataType ac_ = ProceduresForSexualActivity?.Performed;
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            return (ad_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (m_())
                        {
                            DataType ae_ = ProceduresForSexualActivity?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            return (af_ as CqlQuantity) as object;
                        }
                        else if (n_())
                        {
                            DataType ag_ = ProceduresForSexualActivity?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            return (ah_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_());
                    bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, i_, "day");
                    return j_;
                }

                IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
                bool? f_ = context.Operators.Exists<Procedure>(e_);
                return f_;
            });


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.End(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(16, 24, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);

                List<Extension> k_() {

                    bool aj_() {
                        Patient ak_ = this.Patient(context);
                        bool al_ = ak_ is DomainResource;
                        return al_;
                    }

                    if (aj_())
                    {
                        Patient am_ = this.Patient(context);
                        return (am_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    };
                }


                bool? l_(Extension @this) {
                    FhirUri an_ = @this?.UrlElement;
                    FhirString ao_ = context.Operators.Convert<FhirString>(an_);
                    string ap_ = FHIRHelpers_4_4_000.Instance.ToString(context, ao_);
                    bool? aq_ = context.Operators.Equal(ap_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                    return aq_;
                }

                IEnumerable<Extension> m_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(k_()), l_);

                DataType n_(Extension @this) {
                    DataType ar_ = @this?.Value;
                    return ar_;
                }

                IEnumerable<DataType> o_ = context.Operators.Select<Extension, DataType>(m_, n_);
                DataType p_ = context.Operators.SingletonFrom<DataType>(o_);
                bool? q_ = context.Operators.Equal(p_, "248152002");
                bool? r_ = context.Operators.And(j_, q_);
                IEnumerable<Encounter> s_ = this.Qualifying_Encounters(context);
                bool? t_ = context.Operators.Exists<Encounter>(s_);
                bool? u_ = context.Operators.And(r_, t_);
                bool? v_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
                bool? w_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
                bool? x_ = context.Operators.Or(v_, w_);
                bool? y_ = this.Has_Active_Contraceptive_Medications(context);
                bool? z_ = context.Operators.Or(x_, y_);
                bool? aa_ = this.Has_Ordered_Contraceptive_Medications(context);
                bool? ab_ = context.Operators.Or(z_, aa_);
                bool? ac_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
                bool? ad_ = context.Operators.Or(ab_, ac_);
                bool? ae_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
                bool? af_ = context.Operators.Or(ad_, ae_);
                bool? ag_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
                bool? ah_ = context.Operators.Or(af_, ag_);
                bool? ai_ = context.Operators.And(u_, ah_);
                return ai_;
            });


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<bool?> _Has_Pregnancy_Test_Exclusion_Cached = new();

    [CqlExpressionDefinition("Has Pregnancy Test Exclusion")]
    public bool? Has_Pregnancy_Test_Exclusion(CqlContext context) =>
        _Has_Pregnancy_Test_Exclusion_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Pregnancy_Test(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                IEnumerable<ServiceRequest> c_ = Status_1_15_000.Instance.isLaboratoryTestOrder(context, b_);

                IEnumerable<ServiceRequest> d_(ServiceRequest PregnancyTest) {
                    CqlValueSet q_ = this.XRay_Study(context);
                    IEnumerable<ServiceRequest> r_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                    IEnumerable<ServiceRequest> s_ = Status_1_15_000.Instance.isDiagnosticStudyOrder(context, r_);

                    bool? t_(ServiceRequest XrayOrder) {
                        FhirDateTime x_ = XrayOrder?.AuthoredOnElement;
                        CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
                        CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_ as object);
                        CqlDateTime aa_ = context.Operators.Start(z_);
                        FhirDateTime ab_ = PregnancyTest?.AuthoredOnElement;
                        CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                        CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_ as object);
                        CqlDateTime ae_ = context.Operators.End(ad_);
                        CqlDateTime ag_ = context.Operators.Convert<CqlDateTime>(ab_);
                        CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_ as object);
                        CqlDateTime ai_ = context.Operators.End(ah_);
                        CqlQuantity aj_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime ak_ = context.Operators.Add(ai_, aj_);
                        CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ae_, ak_, true, true);
                        bool? am_ = context.Operators.In<CqlDateTime>(aa_, al_, "day");
                        CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(ab_);
                        CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_ as object);
                        CqlDateTime aq_ = context.Operators.End(ap_);
                        bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                        bool? as_ = context.Operators.And(am_, ar_);
                        return as_;
                    }

                    IEnumerable<ServiceRequest> u_ = context.Operators.Where<ServiceRequest>(s_, t_);
                    ServiceRequest v_(ServiceRequest XrayOrder) => PregnancyTest;
                    IEnumerable<ServiceRequest> w_ = context.Operators.Select<ServiceRequest, ServiceRequest>(u_, v_);
                    return w_;
                }

                IEnumerable<ServiceRequest> e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);

                bool? f_(ServiceRequest PregnancyTest) {
                    CqlInterval<CqlDateTime> at_ = this.Measurement_Period(context);
                    FhirDateTime au_ = PregnancyTest?.AuthoredOnElement;
                    CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
                    CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_ as object);
                    bool? ax_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(at_, aw_, default);
                    return ax_;
                }

                IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);
                IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                IEnumerable<ServiceRequest> j_ = Status_1_15_000.Instance.isLaboratoryTestOrder(context, i_);

                IEnumerable<ServiceRequest> k_(ServiceRequest PregnancyTestOrder) {
                    CqlValueSet ay_ = this.Isotretinoin(context);
                    IEnumerable<MedicationRequest> az_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                    IEnumerable<MedicationRequest> ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                    IEnumerable<MedicationRequest> bb_(MedicationRequest MR) {
                        IEnumerable<Medication> bj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                        bool? bk_(Medication M) {
                            object bo_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                            object bp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                            IEnumerable<string> bq_ = context.Operators.Split((string)bp_, "/");
                            string br_ = context.Operators.Last<string>(bq_);
                            bool? bs_ = context.Operators.Equal(bo_, br_);
                            CodeableConcept bt_ = M?.Code;
                            CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                            CqlValueSet bv_ = this.Isotretinoin(context);
                            bool? bw_ = context.Operators.ConceptInValueSet(bu_, bv_);
                            bool? bx_ = context.Operators.And(bs_, bw_);
                            return bx_;
                        }

                        IEnumerable<Medication> bl_ = context.Operators.Where<Medication>(bj_, bk_);
                        MedicationRequest bm_(Medication M) => MR;
                        IEnumerable<MedicationRequest> bn_ = context.Operators.Select<Medication, MedicationRequest>(bl_, bm_);
                        return bn_;
                    }

                    IEnumerable<MedicationRequest> bc_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ba_, bb_);
                    IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(az_, bc_);
                    IEnumerable<MedicationRequest> be_ = Status_1_15_000.Instance.isMedicationOrder(context, bd_);

                    bool? bf_(MedicationRequest AccutaneOrder) {
                        FhirDateTime by_ = AccutaneOrder?.AuthoredOnElement;
                        CqlDateTime bz_ = context.Operators.Convert<CqlDateTime>(by_);
                        CqlInterval<CqlDateTime> ca_ = QICoreCommon_4_0_000.Instance.toInterval(context, bz_ as object);
                        CqlDateTime cb_ = context.Operators.Start(ca_);
                        FhirDateTime cc_ = PregnancyTestOrder?.AuthoredOnElement;
                        CqlDateTime cd_ = context.Operators.Convert<CqlDateTime>(cc_);
                        CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, cd_ as object);
                        CqlDateTime cf_ = context.Operators.End(ce_);
                        CqlDateTime ch_ = context.Operators.Convert<CqlDateTime>(cc_);
                        CqlInterval<CqlDateTime> ci_ = QICoreCommon_4_0_000.Instance.toInterval(context, ch_ as object);
                        CqlDateTime cj_ = context.Operators.End(ci_);
                        CqlQuantity ck_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime cl_ = context.Operators.Add(cj_, ck_);
                        CqlInterval<CqlDateTime> cm_ = context.Operators.Interval(cf_, cl_, true, true);
                        bool? cn_ = context.Operators.In<CqlDateTime>(cb_, cm_, "day");
                        CqlDateTime cp_ = context.Operators.Convert<CqlDateTime>(cc_);
                        CqlInterval<CqlDateTime> cq_ = QICoreCommon_4_0_000.Instance.toInterval(context, cp_ as object);
                        CqlDateTime cr_ = context.Operators.End(cq_);
                        bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                        bool? ct_ = context.Operators.And(cn_, cs_);
                        return ct_;
                    }

                    IEnumerable<MedicationRequest> bg_ = context.Operators.Where<MedicationRequest>(be_, bf_);
                    ServiceRequest bh_(MedicationRequest AccutaneOrder) => PregnancyTestOrder;
                    IEnumerable<ServiceRequest> bi_ = context.Operators.Select<MedicationRequest, ServiceRequest>(bg_, bh_);
                    return bi_;
                }

                IEnumerable<ServiceRequest> l_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(j_, k_);

                bool? m_(ServiceRequest PregnancyTestOrder) {
                    CqlInterval<CqlDateTime> cu_ = this.Measurement_Period(context);
                    FhirDateTime cv_ = PregnancyTestOrder?.AuthoredOnElement;
                    CqlDateTime cw_ = context.Operators.Convert<CqlDateTime>(cv_);
                    CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_ as object);
                    bool? cy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(cu_, cx_, default);
                    return cy_;
                }

                IEnumerable<ServiceRequest> n_ = context.Operators.Where<ServiceRequest>(l_, m_);
                IEnumerable<ServiceRequest> o_ = context.Operators.Union<ServiceRequest>(g_, n_);
                bool? p_ = context.Operators.Exists<ServiceRequest>(o_);
                return p_;
            });


    private Cached<bool?> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
                bool? b_ = this.Has_Pregnancy_Test_Exclusion(context);
                bool? c_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
                bool? d_ = context.Operators.Not(c_);
                bool? e_ = context.Operators.And(b_, d_);
                bool? f_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
                bool? g_ = context.Operators.Not(f_);
                bool? h_ = context.Operators.And(e_, g_);
                bool? i_ = this.Has_Active_Contraceptive_Medications(context);
                bool? j_ = context.Operators.Not(i_);
                bool? k_ = context.Operators.And(h_, j_);
                bool? l_ = this.Has_Ordered_Contraceptive_Medications(context);
                bool? m_ = context.Operators.Not(l_);
                bool? n_ = context.Operators.And(k_, m_);
                bool? o_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
                bool? p_ = context.Operators.Not(o_);
                bool? q_ = context.Operators.And(n_, p_);
                bool? r_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
                bool? s_ = context.Operators.Not(r_);
                bool? t_ = context.Operators.And(q_, s_);
                bool? u_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
                bool? v_ = context.Operators.Not(u_);
                bool? w_ = context.Operators.And(t_, v_);
                bool? x_ = context.Operators.Or(a_, w_);
                return x_;
            });


    private Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Chlamydia_Screening(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
                IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);

                bool? d_(Observation ChlamydiaTest) {

                    object g_() {

                        bool o_() {
                            DataType r_ = ChlamydiaTest?.Effective;
                            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                            bool t_ = s_ is CqlDateTime;
                            return t_;
                        }


                        bool p_() {
                            DataType u_ = ChlamydiaTest?.Effective;
                            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                            bool w_ = v_ is CqlInterval<CqlDateTime>;
                            return w_;
                        }


                        bool q_() {
                            DataType x_ = ChlamydiaTest?.Effective;
                            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                            bool z_ = y_ is CqlDateTime;
                            return z_;
                        }

                        if (o_())
                        {
                            DataType aa_ = ChlamydiaTest?.Effective;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            return (ab_ as CqlDateTime) as object;
                        }
                        else if (p_())
                        {
                            DataType ac_ = ChlamydiaTest?.Effective;
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            return (ad_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (q_())
                        {
                            DataType ae_ = ChlamydiaTest?.Effective;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            return (af_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlDateTime h_ = QICoreCommon_4_0_000.Instance.latest(context, g_());
                    CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
                    bool? j_ = context.Operators.In<CqlDateTime>(h_, i_, "day");
                    DataType k_ = ChlamydiaTest?.Value;
                    object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                    bool? m_ = context.Operators.Not((bool?)(l_ is null));
                    bool? n_ = context.Operators.And(j_, m_);
                    return n_;
                }

                IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
                bool? f_ = context.Operators.Exists<Observation>(e_);
                return f_;
            });


    private Cached<bool?> _Stratification_1_Cached = new();

    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        _Stratification_1_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.End(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(16, 20, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                return j_;
            });


    private Cached<bool?> _Stratification_2_Cached = new();

    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        _Stratification_2_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.End(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(21, 24, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                return j_;
            });


    #endregion Functions and Expressions

}
