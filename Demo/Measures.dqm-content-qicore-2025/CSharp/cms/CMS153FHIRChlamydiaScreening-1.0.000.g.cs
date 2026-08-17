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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
            bool? ad_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aa_, ac_, "day");
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
            bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
            // CQL 'and' (170:7-171:102): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                DataType l_ = SexualActivityAssessment?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlInterval<CqlDateTime> o_;
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                if (r_ is null)
                {
                    o_ = default;
                }
                else
                {
                    CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                    CqlDateTime t_ = context.Operators.End(s_);
                    CqlInterval<CqlDateTime> u_ = context.Operators.Interval(t_, t_, true, true);
                    o_ = u_;
                }
                bool? p_ = context.Operators.SameOrBefore(n_, o_, (string)default);
                return k_ & p_;
            }
        }

        bool? f_ = context.Operators.WhereAny<Observation>(d_, e_);
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
            bool? t_ = context.Operators.Overlaps(r_, s_, (string)default);
            return t_;
        }

        bool? q_ = context.Operators.WhereAny<Condition>(o_, p_);
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
                bool? q_ = context.Operators.Equal(m_, p_);
                // CQL 'and': right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept r_ = M?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    CqlValueSet t_ = this.Contraceptive_Medications(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return q_ & u_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationActive(context, f_);

        bool? h_(MedicationRequest ActiveContraceptives) {
            CqlInterval<CqlDate> v_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
            CqlDate w_ = v_?.low;
            CqlDateTime x_ = context.Operators.ConvertDateToDateTime(w_);
            CqlDate y_ = v_?.high;
            CqlDateTime z_ = context.Operators.ConvertDateToDateTime(y_);
            bool? aa_ = v_?.lowClosed;
            bool? ab_ = v_?.highClosed;
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(x_, z_, aa_, ab_);
            CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
            bool? ae_ = context.Operators.Overlaps(ac_, ad_, (string)default);
            return ae_;
        }

        bool? i_ = context.Operators.WhereAny<MedicationRequest>(g_, h_);
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
                bool? q_ = context.Operators.Equal(m_, p_);
                // CQL 'and': right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept r_ = M?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    CqlValueSet t_ = this.Contraceptive_Medications(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return q_ & u_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest OrderedContraceptives) {
            CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
            FhirDateTime w_ = OrderedContraceptives?.AuthoredOnElement;
            CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            bool? z_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(v_, y_, "day");
            return z_;
        }

        bool? i_ = context.Operators.WhereAny<MedicationRequest>(g_, h_);
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
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            return p_;
        }

        bool? k_ = context.Operators.WhereAny<ServiceRequest>(i_, j_);
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
            bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");
            return j_;
        }

        bool? e_ = context.Operators.WhereAny<ServiceRequest>(c_, d_);
        // CQL 'or' (112:3-115:75): right operand skipped when left is true
        if (e_ is true)
        {
            return true;
        }
        else
        {
            bool? k_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
            return e_ | k_;
        }
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
            bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");
            return j_;
        }

        bool? e_ = context.Operators.WhereAny<ServiceRequest>(c_, d_);
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
                DataType m_ = ProceduresForSexualActivity?.Performed;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                g_ = n_ as CqlDateTime;
            }
            else
            {
                DataType o_ = ProceduresForSexualActivity?.Performed;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlQuantity;
                if (q_)
                {
                    DataType r_ = ProceduresForSexualActivity?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    g_ = s_ as CqlQuantity;
                }
                else
                {
                    DataType t_ = ProceduresForSexualActivity?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        DataType w_ = ProceduresForSexualActivity?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        g_ = x_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType y_ = ProceduresForSexualActivity?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlQuantity>;
                        if (aa_)
                        {
                            DataType ab_ = ProceduresForSexualActivity?.Performed;
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            g_ = ac_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            g_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
            return i_;
        }

        bool? e_ = context.Operators.WhereAny<Procedure>(c_, d_);
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
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        bool? k_;
        // CQL 'and' (59:3-62:33): right operand skipped when left is false
        if (j_ is false)
        {
            k_ = false;
        }
        else
        {
            List<Extension> m_;
            bool s_ = a_ is DomainResource;
            if (s_)
            {
                m_ = (a_ as DomainResource).Extension;
            }
            else
            {
                m_ = default;
            }

            bool? n_(Extension @this) {
                FhirUri t_ = @this?.UrlElement;
                string u_ = FHIRHelpers_4_4_000.Instance.ToString(context, t_);
                bool? v_ = context.Operators.Equal(u_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return v_;
            }


            DataType o_(Extension @this) {
                DataType w_ = @this?.Value;
                return w_;
            }

            IEnumerable<DataType> p_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)m_, n_, o_);
            DataType q_ = context.Operators.SingletonFrom<DataType>(p_);
            bool? r_ = context.Operators.Equal(q_, "248152002");
            k_ = j_ & r_;
        }
        bool? l_;
        // CQL 'and' (59:3-63:42): right operand skipped when left is false
        if (k_ is false)
        {
            l_ = false;
        }
        else
        {
            IEnumerable<Encounter> x_ = this.Qualifying_Encounters(context);
            bool? y_ = context.Operators.Exists<Encounter>(x_);
            l_ = k_ & y_;
        }
        // CQL 'and' (59:3-71:5): right operand skipped when left is false
        if (l_ is false)
        {
            return false;
        }
        else
        {
            bool? z_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
            bool? aa_;
            // CQL 'or' (64:11-65:58): right operand skipped when left is true
            if (z_ is true)
            {
                aa_ = true;
            }
            else
            {
                bool? ag_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
                aa_ = z_ | ag_;
            }
            bool? ab_;
            // CQL 'or' (64:11-66:53): right operand skipped when left is true
            if (aa_ is true)
            {
                ab_ = true;
            }
            else
            {
                bool? ah_ = this.Has_Active_Contraceptive_Medications(context);
                ab_ = aa_ | ah_;
            }
            bool? ac_;
            // CQL 'or' (64:11-67:54): right operand skipped when left is true
            if (ab_ is true)
            {
                ac_ = true;
            }
            else
            {
                bool? ai_ = this.Has_Ordered_Contraceptive_Medications(context);
                ac_ = ab_ | ai_;
            }
            bool? ad_;
            // CQL 'or' (64:11-68:65): right operand skipped when left is true
            if (ac_ is true)
            {
                ad_ = true;
            }
            else
            {
                bool? aj_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
                ad_ = ac_ | aj_;
            }
            bool? ae_;
            // CQL 'or' (64:11-69:67): right operand skipped when left is true
            if (ad_ is true)
            {
                ae_ = true;
            }
            else
            {
                bool? ak_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
                ae_ = ad_ | ak_;
            }
            bool? af_;
            // CQL 'or' (64:9-71:5): right operand skipped when left is true
            if (ae_ is true)
            {
                af_ = true;
            }
            else
            {
                bool? al_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
                af_ = ae_ | al_;
            }
            return l_ & af_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -2228011371027617572L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
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
                bool? ad_ = context.Operators.In<CqlDateTime>(v_, ac_, "day");
                // CQL 'and' (143:21-143:136): right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    return ad_ & (!((bool?)(z_ is null)));
                }
            }

            bool? r_ = context.Operators.WhereAny<ServiceRequest>(p_, q_);
            return r_;
        }

        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);

        bool? f_(ServiceRequest PregnancyTest) {
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            FhirDateTime af_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime ag_ = context.Operators.Convert<CqlDateTime>(af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            bool? ai_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ah_, (string)default);
            return ai_;
        }

        IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);

        bool? h_(ServiceRequest PregnancyTestOrder) {
            IEnumerable<MedicationRequest> aj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? ak_(MedicationRequest MR) {
                IEnumerable<Medication> as_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? at_(Medication M) {
                    object av_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object aw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> ax_ = context.Operators.Split((string)aw_, "/");
                    string ay_ = context.Operators.Last<string>(ax_);
                    bool? az_ = context.Operators.Equal(av_, ay_);
                    // CQL 'and': right operand skipped when left is false
                    if (az_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept ba_ = M?.Code;
                        CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_);
                        CqlValueSet bc_ = this.Isotretinoin(context);
                        bool? bd_ = context.Operators.ConceptInValueSet(bb_, bc_);
                        return az_ & bd_;
                    }
                }

                bool? au_ = context.Operators.WhereAny<Medication>(as_, at_);
                return au_;
            }

            IEnumerable<MedicationRequest> al_ = context.Operators.Where<MedicationRequest>(aj_, ak_);
            CqlValueSet am_ = this.Isotretinoin(context);
            IEnumerable<MedicationRequest> an_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ao_ = context.Operators.Union<MedicationRequest>(al_, an_);
            IEnumerable<MedicationRequest> ap_ = Status_1_15_000.Instance.isMedicationOrder(context, ao_);

            bool? aq_(MedicationRequest AccutaneOrder) {
                FhirDateTime be_ = AccutaneOrder?.AuthoredOnElement;
                CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                FhirDateTime bi_ = PregnancyTestOrder?.AuthoredOnElement;
                CqlDateTime bj_ = context.Operators.Convert<CqlDateTime>(bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.End(bk_);
                CqlQuantity bm_ = context.Operators.Quantity(6m, "days");
                CqlDateTime bn_ = context.Operators.Add(bl_, bm_);
                CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bl_, bn_, true, true);
                bool? bp_ = context.Operators.In<CqlDateTime>(bh_, bo_, "day");
                // CQL 'and' (148:21-148:145): right operand skipped when left is false
                if (bp_ is false)
                {
                    return false;
                }
                else
                {
                    return bp_ & (!((bool?)(bl_ is null)));
                }
            }

            bool? ar_ = context.Operators.WhereAny<MedicationRequest>(ap_, aq_);
            return ar_;
        }

        IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(c_, h_);

        bool? j_(ServiceRequest PregnancyTestOrder) {
            CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
            FhirDateTime br_ = PregnancyTestOrder?.AuthoredOnElement;
            CqlDateTime bs_ = context.Operators.Convert<CqlDateTime>(br_);
            CqlInterval<CqlDateTime> bt_ = QICoreCommon_4_0_000.Instance.toInterval(context, bs_);
            bool? bu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bq_, bt_, (string)default);
            return bu_;
        }

        IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
        IEnumerable<ServiceRequest> l_ = context.Operators.Union<ServiceRequest>(g_, k_);
        bool? m_ = context.Operators.Exists<ServiceRequest>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 3697874071608603199L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        // CQL 'or' (129:3-138:5): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.Has_Pregnancy_Test_Exclusion(context);
            bool? c_;
            // CQL 'and' (130:10-131:65): right operand skipped when left is false
            if (b_ is false)
            {
                c_ = false;
            }
            else
            {
                bool? j_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
                c_ = b_ & !j_;
            }
            bool? d_;
            // CQL 'and' (130:10-132:63): right operand skipped when left is false
            if (c_ is false)
            {
                d_ = false;
            }
            else
            {
                bool? k_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
                d_ = c_ & !k_;
            }
            bool? e_;
            // CQL 'and' (130:10-133:58): right operand skipped when left is false
            if (d_ is false)
            {
                e_ = false;
            }
            else
            {
                bool? l_ = this.Has_Active_Contraceptive_Medications(context);
                e_ = d_ & !l_;
            }
            bool? f_;
            // CQL 'and' (130:10-134:59): right operand skipped when left is false
            if (e_ is false)
            {
                f_ = false;
            }
            else
            {
                bool? m_ = this.Has_Ordered_Contraceptive_Medications(context);
                f_ = e_ & !m_;
            }
            bool? g_;
            // CQL 'and' (130:10-135:88): right operand skipped when left is false
            if (f_ is false)
            {
                g_ = false;
            }
            else
            {
                bool? n_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
                g_ = f_ & !n_;
            }
            bool? h_;
            // CQL 'and' (130:10-136:72): right operand skipped when left is false
            if (g_ is false)
            {
                h_ = false;
            }
            else
            {
                bool? o_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
                h_ = g_ & !o_;
            }
            bool? i_;
            // CQL 'and' (130:8-138:5): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                bool? p_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
                i_ = h_ & !p_;
            }
            return a_ | i_;
        }
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
            DataType j_ = ChlamydiaTest?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                DataType m_ = ChlamydiaTest?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                f_ = n_ as CqlDateTime;
            }
            else
            {
                DataType o_ = ChlamydiaTest?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlDateTime;
                if (q_)
                {
                    DataType r_ = ChlamydiaTest?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    f_ = s_ as CqlDateTime;
                }
                else
                {
                    DataType t_ = ChlamydiaTest?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        DataType w_ = ChlamydiaTest?.Effective;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        f_ = x_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        f_ = null;
                    }
                }
            }
            CqlDateTime g_ = QICoreCommon_4_0_000.Instance.latest(context, f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            // CQL 'and' (154:7-155:43): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                DataType y_ = ChlamydiaTest?.Value;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                return i_ & (!((bool?)(z_ is null)));
            }
        }

        bool? e_ = context.Operators.WhereAny<Observation>(c_, d_);
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
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
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
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
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
