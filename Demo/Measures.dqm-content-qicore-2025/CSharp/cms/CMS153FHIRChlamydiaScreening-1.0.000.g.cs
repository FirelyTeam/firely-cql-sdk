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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
[CqlLibrary("CMS153FHIRChlamydiaScreening", "1.0.000")]
public partial class CMS153FHIRChlamydiaScreening_1_0_000 : ILibrary, ISingleton<CMS153FHIRChlamydiaScreening_1_0_000>
{
    #region ValueSets (21)

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

    #region Codes (3)

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

    #region CodeSystems (2)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -1345411175383824253L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS153FHIRChlamydiaScreening-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (21)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -3673209837379419933L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -838269432678333816L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -6881693602031443699L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 2266474229895085448L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 510276223678970139L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = -3867250165514011721L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
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
            CqlBoolean ad_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aa_, ac_, "day");
            return ad_;
        }

        IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(x_, y_);
        return z_;
    }


    [CqlExpressionDefinition("Has Assessments Identifying Sexual Activity")]
    public bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Assessments_Identifying_Sexual_Activity, Has_Assessments_Identifying_Sexual_Activity_Compute);

    private const long _cacheIndex_Has_Assessments_Identifying_Sexual_Activity = 2115328169786990818L;

    private bool? Has_Assessments_Identifying_Sexual_Activity_Compute(CqlContext context)
    {
        CqlCode a_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

        bool? e_(Observation SexualActivityAssessment) {
            DataType g_ = SexualActivityAssessment?.Value;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlCode i_ = this.Yes__qualifier_value_(context);
            CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
            CqlBoolean k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
            DataType l_ = SexualActivityAssessment?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlInterval<CqlDateTime> o_;
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            if (s_ is null)
            {
                o_ = default;
            }
            else
            {
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, s_, true, true);
                o_ = t_;
            }
            CqlBoolean p_ = context.Operators.SameOrBefore(n_, o_, (string)default);
            CqlBoolean q_ = p_;
            return k_
                /* CQL 'and' (170:7-171:102) */ && q_;
        }

        CqlBoolean f_ = context.Operators.WhereAny<Observation>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Diagnoses Identifying Sexual Activity")]
    public bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnoses_Identifying_Sexual_Activity, Has_Diagnoses_Identifying_Sexual_Activity_Compute);

    private const long _cacheIndex_Has_Diagnoses_Identifying_Sexual_Activity = 2632990418126780023L;

    private bool? Has_Diagnoses_Identifying_Sexual_Activity_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.HIV(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);
        CqlValueSet j_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
        IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> l_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition>, k_ as IEnumerable<Condition>);
        IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> n_ = context.Operators.Union<Condition>(l_ as IEnumerable<Condition>, m_ as IEnumerable<Condition>);
        IEnumerable<Condition> o_ = Status_1_15_000.Instance.verified(context, n_);

        bool? p_(Condition SexualActivityDiagnosis) {
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SexualActivityDiagnosis);
            CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
            CqlBoolean t_ = context.Operators.Overlaps(r_, s_, (string)default);
            return t_;
        }

        CqlBoolean q_ = context.Operators.WhereAny<Condition>(o_, p_);
        return q_;
    }


    [CqlExpressionDefinition("Has Active Contraceptive Medications")]
    public bool? Has_Active_Contraceptive_Medications(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Active_Contraceptive_Medications, Has_Active_Contraceptive_Medications_Compute);

    private const long _cacheIndex_Has_Active_Contraceptive_Medications = 3164491970648369952L;

    private bool? Has_Active_Contraceptive_Medications_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                CqlBoolean q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Contraceptive_Medications(context);
                CqlBoolean u_ = context.Operators.ConceptInValueSet(s_, t_);
                CqlBoolean v_ = u_;
                return q_
                    /* CQL 'and' */ && v_;
            }

            CqlBoolean l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationActive(context, f_);

        bool? h_(MedicationRequest ActiveContraceptives) {
            CqlInterval<CqlDate> w_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
            CqlDate x_ = w_?.low;
            CqlDateTime y_ = context.Operators.ConvertDateToDateTime(x_);
            CqlDate z_ = w_?.high;
            CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
            CqlBoolean ab_ = w_?.lowClosed;
            CqlBoolean ac_ = w_?.highClosed;
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(y_, aa_, ab_, ac_);
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            CqlBoolean af_ = context.Operators.Overlaps(ad_, ae_, (string)default);
            return af_;
        }

        CqlBoolean i_ = context.Operators.WhereAny<MedicationRequest>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Has Ordered Contraceptive Medications")]
    public bool? Has_Ordered_Contraceptive_Medications(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Ordered_Contraceptive_Medications, Has_Ordered_Contraceptive_Medications_Compute);

    private const long _cacheIndex_Has_Ordered_Contraceptive_Medications = -6685451883001229759L;

    private bool? Has_Ordered_Contraceptive_Medications_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                CqlBoolean q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Contraceptive_Medications(context);
                CqlBoolean u_ = context.Operators.ConceptInValueSet(s_, t_);
                CqlBoolean v_ = u_;
                return q_
                    /* CQL 'and' */ && v_;
            }

            CqlBoolean l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest OrderedContraceptives) {
            CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
            FhirDateTime x_ = OrderedContraceptives?.AuthoredOnElement;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
            CqlBoolean aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, "day");
            return aa_;
        }

        CqlBoolean i_ = context.Operators.WhereAny<MedicationRequest>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy, Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy_Compute);

    private const long _cacheIndex_Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy = -2561976657898182732L;

    private bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy_Compute(CqlContext context)
    {
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
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            FhirDateTime m_ = LabOrders?.AuthoredOnElement;
            CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            CqlBoolean p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            return p_;
        }

        CqlBoolean k_ = context.Operators.WhereAny<ServiceRequest>(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Laboratory_Tests_Identifying_Sexual_Activity, Has_Laboratory_Tests_Identifying_Sexual_Activity_Compute);

    private const long _cacheIndex_Has_Laboratory_Tests_Identifying_Sexual_Activity = 379598359555302312L;

    private bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_ = Status_1_15_000.Instance.isLaboratoryTestOrder(context, b_);

        bool? d_(ServiceRequest PregnancyTest) {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            FhirDateTime g_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            CqlBoolean j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");
            return j_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<ServiceRequest>(c_, d_);
        return e_
            /* CQL 'or' (112:3-115:75) */ || this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
    }


    [CqlExpressionDefinition("Has Diagnostic Studies Identifying Sexual Activity")]
    public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnostic_Studies_Identifying_Sexual_Activity, Has_Diagnostic_Studies_Identifying_Sexual_Activity_Compute);

    private const long _cacheIndex_Has_Diagnostic_Studies_Identifying_Sexual_Activity = 5539533142023325111L;

    private bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Diagnostic_Studies_During_Pregnancy(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_ = Status_1_15_000.Instance.isDiagnosticStudyOrder(context, b_);

        bool? d_(ServiceRequest SexualActivityDiagnostics) {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            FhirDateTime g_ = SexualActivityDiagnostics?.AuthoredOnElement;
            CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            CqlBoolean j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");
            return j_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<ServiceRequest>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Has Procedures Identifying Sexual Activity")]
    public bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Procedures_Identifying_Sexual_Activity, Has_Procedures_Identifying_Sexual_Activity_Compute);

    private const long _cacheIndex_Has_Procedures_Identifying_Sexual_Activity = 6254113099437797292L;

    private bool? Has_Procedures_Identifying_Sexual_Activity_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure ProceduresForSexualActivity) {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            object g_;
            DataType j_ = ProceduresForSexualActivity?.Performed;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                g_ = k_ as CqlDateTime;
            }
            else
            {
                bool m_ = k_ is CqlQuantity;
                if (m_)
                {
                    g_ = k_ as CqlQuantity;
                }
                else
                {
                    bool n_ = k_ is CqlInterval<CqlDateTime>;
                    if (n_)
                    {
                        g_ = k_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool o_ = k_ is CqlInterval<CqlQuantity>;
                        if (o_)
                        {
                            g_ = k_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            g_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
            CqlBoolean i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
            return i_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 9135200379284452517L;

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
        CqlInterval<int?> i_ = context.Operators.Interval(16, 24, true, true);
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);
        List<Extension> k_;
        bool w_ = a_ is DomainResource;
        if (w_)
        {
            k_ = (a_ as DomainResource).Extension;
        }
        else
        {
            k_ = default;
        }

        bool? l_(Extension @this) {
            FhirUri x_ = @this?.UrlElement;
            string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
            CqlBoolean z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return z_;
        }


        DataType m_(Extension @this) {
            DataType aa_ = @this?.Value;
            return aa_;
        }

        IEnumerable<DataType> n_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)k_, l_, m_);
        DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
        CqlBoolean p_ = context.Operators.Equal(o_, "248152002");
        CqlBoolean q_ = p_;
        IEnumerable<Encounter> r_ = this.Qualifying_Encounters(context);
        CqlBoolean s_ = context.Operators.Exists<Encounter>(r_);
        CqlBoolean t_ = s_;
        CqlBoolean u_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        CqlBoolean v_ = u_
            /* CQL 'or' (64:11-65:58) */ || this.Has_Diagnoses_Identifying_Sexual_Activity(context)
            /* CQL 'or' (64:11-66:53) */ || this.Has_Active_Contraceptive_Medications(context)
            /* CQL 'or' (64:11-67:54) */ || this.Has_Ordered_Contraceptive_Medications(context)
            /* CQL 'or' (64:11-68:65) */ || this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context)
            /* CQL 'or' (64:11-69:67) */ || this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context)
            /* CQL 'or' (64:9-71:5) */ || this.Has_Procedures_Identifying_Sexual_Activity(context);
        return j_
            /* CQL 'and' (59:3-62:33) */ && q_
            /* CQL 'and' (59:3-63:42) */ && t_
            /* CQL 'and' (59:3-71:5) */ && v_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -2228011371027617572L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Pregnancy Test Exclusion")]
    public bool? Has_Pregnancy_Test_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Pregnancy_Test_Exclusion, Has_Pregnancy_Test_Exclusion_Compute);

    private const long _cacheIndex_Has_Pregnancy_Test_Exclusion = -1820798381545666754L;

    private bool? Has_Pregnancy_Test_Exclusion_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_ = Status_1_15_000.Instance.isLaboratoryTestOrder(context, b_);

        bool? d_(ServiceRequest PregnancyTest) {
            CqlValueSet n_ = this.XRay_Study(context);
            IEnumerable<ServiceRequest> o_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> p_ = Status_1_15_000.Instance.isDiagnosticStudyOrder(context, o_);

            bool? q_(ServiceRequest XrayOrder) {
                FhirDateTime s_ = XrayOrder?.AuthoredOnElement;
                CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                FhirDateTime w_ = PregnancyTest?.AuthoredOnElement;
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.End(y_);
                CqlQuantity aa_ = context.Operators.Quantity(6m, "days");
                CqlDateTime ab_ = context.Operators.Add(z_, aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(z_, ab_, true, true);
                CqlBoolean ad_ = context.Operators.In<CqlDateTime>(v_, ac_, "day");
                CqlBoolean ae_ = (CqlBoolean)(z_ is not null);
                return ad_
                    /* CQL 'and' (143:21-143:136) */ && ae_;
            }

            CqlBoolean r_ = context.Operators.WhereAny<ServiceRequest>(p_, q_);
            return r_;
        }

        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);

        bool? f_(ServiceRequest PregnancyTest) {
            CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
            FhirDateTime ag_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlBoolean aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(af_, ai_, (string)default);
            return aj_;
        }

        IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);

        bool? h_(ServiceRequest PregnancyTestOrder) {
            IEnumerable<MedicationRequest> ak_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? al_(MedicationRequest MR) {
                IEnumerable<Medication> at_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? au_(Medication M) {
                    object aw_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object ax_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> ay_ = context.Operators.Split((string)ax_, "/");
                    string az_ = context.Operators.Last<string>(ay_);
                    CqlBoolean ba_ = context.Operators.Equal(aw_, az_);
                    CodeableConcept bb_ = M?.Code;
                    CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                    CqlValueSet bd_ = this.Isotretinoin(context);
                    CqlBoolean be_ = context.Operators.ConceptInValueSet(bc_, bd_);
                    CqlBoolean bf_ = be_;
                    return ba_
                        /* CQL 'and' */ && bf_;
                }

                CqlBoolean av_ = context.Operators.WhereAny<Medication>(at_, au_);
                return av_;
            }

            IEnumerable<MedicationRequest> am_ = context.Operators.Where<MedicationRequest>(ak_, al_);
            CqlValueSet an_ = this.Isotretinoin(context);
            IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
            IEnumerable<MedicationRequest> aq_ = Status_1_15_000.Instance.isMedicationOrder(context, ap_);

            bool? ar_(MedicationRequest AccutaneOrder) {
                FhirDateTime bg_ = AccutaneOrder?.AuthoredOnElement;
                CqlDateTime bh_ = context.Operators.Convert<CqlDateTime>(bg_);
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                FhirDateTime bk_ = PregnancyTestOrder?.AuthoredOnElement;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
                CqlDateTime bn_ = context.Operators.End(bm_);
                CqlQuantity bo_ = context.Operators.Quantity(6m, "days");
                CqlDateTime bp_ = context.Operators.Add(bn_, bo_);
                CqlInterval<CqlDateTime> bq_ = context.Operators.Interval(bn_, bp_, true, true);
                CqlBoolean br_ = context.Operators.In<CqlDateTime>(bj_, bq_, "day");
                CqlBoolean bs_ = (CqlBoolean)(bn_ is not null);
                return br_
                    /* CQL 'and' (148:21-148:145) */ && bs_;
            }

            CqlBoolean as_ = context.Operators.WhereAny<MedicationRequest>(aq_, ar_);
            return as_;
        }

        IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(c_, h_);

        bool? j_(ServiceRequest PregnancyTestOrder) {
            CqlInterval<CqlDateTime> bt_ = this.Measurement_Period(context);
            FhirDateTime bu_ = PregnancyTestOrder?.AuthoredOnElement;
            CqlDateTime bv_ = context.Operators.Convert<CqlDateTime>(bu_);
            CqlInterval<CqlDateTime> bw_ = QICoreCommon_4_0_000.Instance.toInterval(context, bv_);
            CqlBoolean bx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bt_, bw_, (string)default);
            return bx_;
        }

        IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
        IEnumerable<ServiceRequest> l_ = context.Operators.Union<ServiceRequest>(g_, k_);
        CqlBoolean m_ = context.Operators.Exists<ServiceRequest>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 3697874071608603199L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        CqlBoolean a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        CqlBoolean b_ = this.Has_Pregnancy_Test_Exclusion(context);
        CqlBoolean c_ = b_
            /* CQL 'and' (130:10-131:65) */ && !(this.Has_Assessments_Identifying_Sexual_Activity(context))
            /* CQL 'and' (130:10-132:63) */ && !(this.Has_Diagnoses_Identifying_Sexual_Activity(context))
            /* CQL 'and' (130:10-133:58) */ && !(this.Has_Active_Contraceptive_Medications(context))
            /* CQL 'and' (130:10-134:59) */ && !(this.Has_Ordered_Contraceptive_Medications(context))
            /* CQL 'and' (130:10-135:88) */ && !(this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context))
            /* CQL 'and' (130:10-136:72) */ && !(this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context))
            /* CQL 'and' (130:8-138:5) */ && !(this.Has_Procedures_Identifying_Sexual_Activity(context));
        return a_
            /* CQL 'or' (129:3-138:5) */ || c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 7679949648353288652L;

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);

        bool? d_(Observation ChlamydiaTest) {
            object f_;
            DataType m_ = ChlamydiaTest?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            bool o_ = n_ is CqlDateTime;
            if (o_)
            {
                f_ = n_ as CqlDateTime;
            }
            else
            {
                if (o_)
                {
                    f_ = n_ as CqlDateTime;
                }
                else
                {
                    bool p_ = n_ is CqlInterval<CqlDateTime>;
                    if (p_)
                    {
                        f_ = n_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        f_ = null;
                    }
                }
            }
            CqlDateTime g_ = QICoreCommon_4_0_000.Instance.latest(context, f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlBoolean i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            DataType j_ = ChlamydiaTest?.Value;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlBoolean l_ = (CqlBoolean)(k_ is not null);
            return i_
                /* CQL 'and' (154:7-155:43) */ && l_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = -5101421012347047082L;

    private bool? Stratification_1_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(16, 20, true, true);
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = 3239130432549093830L;

    private bool? Stratification_2_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(21, 24, true, true);
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS153FHIRChlamydiaScreening_1_0_000() {}

    public static CMS153FHIRChlamydiaScreening_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS153FHIRChlamydiaScreening";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
