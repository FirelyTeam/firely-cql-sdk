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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS142FHIRCommWithDrManagingDiab", "1.0.000")]
public partial class CMS142FHIRCommWithDrManagingDiab_1_0_000 : ILibrary, ISingleton<CMS142FHIRCommWithDrManagingDiab_1_0_000>
{
    #region ValueSets (12)

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Diabetic Retinopathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext _) => _Diabetic_Retinopathy;
    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlValueSetDefinition("Level of Severity of Retinopathy Findings", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", valueSetVersion: null)]
    public CqlValueSet Level_of_Severity_of_Retinopathy_Findings(CqlContext _) => _Level_of_Severity_of_Retinopathy_Findings;
    private static readonly CqlValueSet _Level_of_Severity_of_Retinopathy_Findings = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", null);

    [CqlValueSetDefinition("Macular Edema Findings Present", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", valueSetVersion: null)]
    public CqlValueSet Macular_Edema_Findings_Present(CqlContext _) => _Macular_Edema_Findings_Present;
    private static readonly CqlValueSet _Macular_Edema_Findings_Present = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", null);

    [CqlValueSetDefinition("Macular Exam", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", valueSetVersion: null)]
    public CqlValueSet Macular_Exam(CqlContext _) => _Macular_Exam;
    private static readonly CqlValueSet _Macular_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlValueSetDefinition("Macular Edema Findings Absent", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", valueSetVersion: null)]
    public CqlValueSet Macular_Edema_Findings_Absent(CqlContext _) => _Macular_Edema_Findings_Absent;
    private static readonly CqlValueSet _Macular_Edema_Findings_Absent = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual,
          _AMB]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 1976367873611122928L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS142FHIRCommWithDrManagingDiab-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (20)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 3068706284596052392L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 6022114317371114575L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -1718535068658867191L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 778741275765118049L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 933811377903176788L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Day_of_Measurement_Period, Qualifying_Encounter_During_Day_of_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Day_of_Measurement_Period = 8740988171584218547L;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);

        bool? o_(Encounter QualifyingEncounter) {
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            Period r_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");
            Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
            bool? x_ = context.Operators.Equal(w_, "finished");
            bool? y_ = context.Operators.And(t_, x_);
            Coding z_ = QualifyingEncounter?.Class;
            CqlCode aa_ = FHIRHelpers_4_4_000.Instance.ToCode(context, z_);
            CqlCode ab_ = this.@virtual(context);
            bool? ac_ = context.Operators.Equivalent(aa_, ab_);
            bool? ad_ = context.Operators.Not(ac_);
            bool? ae_ = context.Operators.And(y_, ad_);
            return ae_;
        }

        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
        return p_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Diabetic_Retinopathy_Encounter, Diabetic_Retinopathy_Encounter_Compute);

    private const long _cacheIndex_Diabetic_Retinopathy_Encounter = 3997591242404268380L;

    private IEnumerable<Encounter> Diabetic_Retinopathy_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);

        IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter) {
            CqlValueSet d_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);

            bool? i_(Condition DiabeticRetinopathy) {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabeticRetinopathy);
                Period n_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.Overlaps(m_, o_, "day");
                bool? q_ = this.isVerified(context, DiabeticRetinopathy);
                bool? r_ = context.Operators.And(p_, q_);
                return r_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            Encounter k_(Condition DiabeticRetinopathy) => ValidQualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Condition, Encounter>(j_, k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 527741632884648581L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
        IEnumerable<Encounter> j_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? k_ = context.Operators.Exists<Encounter>(j_);
        bool? l_ = context.Operators.And(i_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Macular_Exam_Performed, Macular_Exam_Performed_Compute);

    private const long _cacheIndex_Macular_Exam_Performed = -3744000771213462287L;

    private IEnumerable<Observation> Macular_Exam_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Exam(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        IEnumerable<Observation> c_(Observation MacularExam) {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? h_(Encounter EncounterDiabeticRetinopathy) {
                Period l_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                DataType n_ = MacularExam?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, (string)default);
                return q_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Observation j_(Encounter EncounterDiabeticRetinopathy) => MacularExam;
            IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);

        bool? e_(Observation MacularExam) {
            DataType r_ = MacularExam?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool? t_ = context.Operators.Not((bool?)(s_ is null));
            Code<ObservationStatus> u_ = MacularExam?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
            bool? z_ = context.Operators.And(t_, y_);
            return z_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 2230274664456566776L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        IEnumerable<Observation> b_ = this.Macular_Exam_Performed(context);
        bool? c_ = context.Operators.Exists<Observation>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Level_of_Severity_of_Retinopathy_Findings_Communicated, Level_of_Severity_of_Retinopathy_Findings_Communicated_Compute);

    private const long _cacheIndex_Level_of_Severity_of_Retinopathy_Findings_Communicated = 4196601842577434193L;

    private IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));

        IEnumerable<Communication> c_(Communication LevelOfSeverityCommunicated) {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? h_(Encounter EncounterDiabeticRetinopathy) {
                FhirDateTime l_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.After(m_, p_, (string)default);
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) => LevelOfSeverityCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);
            return k_;
        }

        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);

        bool? e_(Communication LevelOfSeverityCommunicated) {
            Code<EventStatus> w_ = LevelOfSeverityCommunicated?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.Equal(y_, "completed");
            return z_;
        }

        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Macular_Edema_Absence_Communicated, Macular_Edema_Absence_Communicated_Compute);

    private const long _cacheIndex_Macular_Edema_Absence_Communicated = -45539195185216950L;

    private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Edema_Findings_Absent(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));

        IEnumerable<Communication> c_(Communication MacularEdemaAbsentCommunicated) {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? h_(Encounter EncounterDiabeticRetinopathy) {
                FhirDateTime l_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.After(m_, p_, (string)default);
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) => MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);
            return k_;
        }

        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);

        bool? e_(Communication MacularEdemaAbsentCommunicated) {
            Code<EventStatus> w_ = MacularEdemaAbsentCommunicated?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.Equal(y_, "completed");
            return z_;
        }

        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Macular_Edema_Presence_Communicated, Macular_Edema_Presence_Communicated_Compute);

    private const long _cacheIndex_Macular_Edema_Presence_Communicated = 2734595757187929994L;

    private IEnumerable<Communication> Macular_Edema_Presence_Communicated_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));

        IEnumerable<Communication> c_(Communication MacularEdemaPresentCommunicated) {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? h_(Encounter EncounterDiabeticRetinopathy) {
                FhirDateTime l_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.After(m_, p_, (string)default);
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, (string)default);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) => MacularEdemaPresentCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);
            return k_;
        }

        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);

        bool? e_(Communication MacularEdemaPresentCommunicated) {
            Code<EventStatus> w_ = MacularEdemaPresentCommunicated?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.Equal(y_, "completed");
            return z_;
        }

        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -5639094499045435904L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated(context);
        bool? d_ = context.Operators.Exists<Communication>(c_);
        IEnumerable<Communication> e_ = this.Macular_Edema_Presence_Communicated(context);
        bool? f_ = context.Operators.Exists<Communication>(e_);
        bool? g_ = context.Operators.Or(d_, f_);
        bool? h_ = context.Operators.And(b_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy, Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Compute);

    private const long _cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy = -1416730479647423916L;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));

        IEnumerable<Communication> c_(Communication LevelOfSeverityNotCommunicated) {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? h_(Encounter EncounterDiabeticRetinopathy) {

                bool? l_(Extension @this) {
                    FhirUri v_ = @this?.UrlElement;
                    string w_ = FHIRHelpers_4_4_000.Instance.ToString(context, v_);
                    bool? x_ = context.Operators.Equal(w_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return x_;
                }

                IEnumerable<Extension> m_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LevelOfSeverityNotCommunicated is DomainResource
                    ? (LevelOfSeverityNotCommunicated as DomainResource).Extension
                    : default), l_);

                DataType n_(Extension @this) {
                    DataType y_ = @this?.Value;
                    return y_;
                }

                IEnumerable<DataType> o_ = context.Operators.Select<Extension, DataType>(m_, n_);
                DataType p_ = context.Operators.SingletonFrom<DataType>(o_);
                FhirDateTime q_ = context.Operators.Convert<FhirDateTime>(p_);
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                Period s_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, "day");
                return u_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) => LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);
            return k_;
        }

        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);

        bool? e_(Communication LevelOfSeverityNotCommunicated) {
            CodeableConcept z_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
            CqlValueSet ab_ = this.Medical_Reason(context);
            bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
            CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
            CqlValueSet af_ = this.Patient_Reason(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
            bool? ah_ = context.Operators.Or(ac_, ag_);
            return ah_;
        }

        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema, Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Compute);

    private const long _cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema = 7536212958474482668L;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Edema_Findings_Absent(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));

        IEnumerable<Communication> c_(Communication MacularEdemaAbsentNotCommunicated) {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? h_(Encounter EncounterDiabeticRetinopathy) {

                bool? l_(Extension @this) {
                    FhirUri v_ = @this?.UrlElement;
                    string w_ = FHIRHelpers_4_4_000.Instance.ToString(context, v_);
                    bool? x_ = context.Operators.Equal(w_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return x_;
                }

                IEnumerable<Extension> m_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MacularEdemaAbsentNotCommunicated is DomainResource
                    ? (MacularEdemaAbsentNotCommunicated as DomainResource).Extension
                    : default), l_);

                DataType n_(Extension @this) {
                    DataType y_ = @this?.Value;
                    return y_;
                }

                IEnumerable<DataType> o_ = context.Operators.Select<Extension, DataType>(m_, n_);
                DataType p_ = context.Operators.SingletonFrom<DataType>(o_);
                FhirDateTime q_ = context.Operators.Convert<FhirDateTime>(p_);
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                Period s_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, "day");
                return u_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) => MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);
            return k_;
        }

        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);

        bool? e_(Communication MacularEdemaAbsentNotCommunicated) {
            CodeableConcept z_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
            CqlValueSet ab_ = this.Medical_Reason(context);
            bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
            CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
            CqlValueSet af_ = this.Patient_Reason(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
            bool? ah_ = context.Operators.Or(ac_, ag_);
            return ah_;
        }

        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema, Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Compute);

    private const long _cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema = 7695213645564055758L;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));

        IEnumerable<Communication> c_(Communication MacularEdemaPresentNotCommunicated) {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? h_(Encounter EncounterDiabeticRetinopathy) {

                bool? l_(Extension @this) {
                    FhirUri v_ = @this?.UrlElement;
                    string w_ = FHIRHelpers_4_4_000.Instance.ToString(context, v_);
                    bool? x_ = context.Operators.Equal(w_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return x_;
                }

                IEnumerable<Extension> m_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MacularEdemaPresentNotCommunicated is DomainResource
                    ? (MacularEdemaPresentNotCommunicated as DomainResource).Extension
                    : default), l_);

                DataType n_(Extension @this) {
                    DataType y_ = @this?.Value;
                    return y_;
                }

                IEnumerable<DataType> o_ = context.Operators.Select<Extension, DataType>(m_, n_);
                DataType p_ = context.Operators.SingletonFrom<DataType>(o_);
                FhirDateTime q_ = context.Operators.Convert<FhirDateTime>(p_);
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                Period s_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, "day");
                return u_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) => MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);
            return k_;
        }

        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);

        bool? e_(Communication MacularEdemaPresentNotCommunicated) {
            CodeableConcept z_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
            CqlValueSet ab_ = this.Medical_Reason(context);
            bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
            CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
            CqlValueSet af_ = this.Patient_Reason(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
            bool? ah_ = context.Operators.Or(ac_, ag_);
            return ah_;
        }

        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -6832273174152679485L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        IEnumerable<Communication> c_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? d_ = context.Operators.Exists<Communication>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<Communication> f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? g_ = context.Operators.Exists<Communication>(f_);
        bool? h_ = context.Operators.Or(e_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Results_of_Dilated_Macular_or_Fundus_Exam_Communicated, Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Compute);

    private const long _cacheIndex_Results_of_Dilated_Macular_or_Fundus_Exam_Communicated = -312307731247108550L;

    private bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Compute(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated(context);
        bool? d_ = context.Operators.Exists<Communication>(c_);
        IEnumerable<Communication> e_ = this.Macular_Edema_Presence_Communicated(context);
        bool? f_ = context.Operators.Exists<Communication>(e_);
        bool? g_ = context.Operators.Or(d_, f_);
        bool? h_ = context.Operators.And(b_, g_);
        return h_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS142FHIRCommWithDrManagingDiab_1_0_000() {}

    public static CMS142FHIRCommWithDrManagingDiab_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS142FHIRCommWithDrManagingDiab";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
