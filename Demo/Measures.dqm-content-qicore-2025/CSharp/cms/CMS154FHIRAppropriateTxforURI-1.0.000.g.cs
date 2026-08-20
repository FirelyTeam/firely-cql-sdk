#nullable enable annotations

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
[CqlLibrary("CMS154FHIRAppropriateTxforURI", "1.0.000")]
public partial class CMS154FHIRAppropriateTxforURI_1_0_000 : ILibrary, ISingleton<CMS154FHIRAppropriateTxforURI_1_0_000>
{
    #region ValueSets (19)

    [CqlValueSetDefinition("Acute Pharyngitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", valueSetVersion: null)]
    public CqlValueSet Acute_Pharyngitis(CqlContext _) => _Acute_Pharyngitis;
    private static readonly CqlValueSet _Acute_Pharyngitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", null);

    [CqlValueSetDefinition("Acute Tonsillitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", valueSetVersion: null)]
    public CqlValueSet Acute_Tonsillitis(CqlContext _) => _Acute_Tonsillitis;
    private static readonly CqlValueSet _Acute_Tonsillitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", null);

    [CqlValueSetDefinition("Antibiotic Medications for Upper Respiratory Infection", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", valueSetVersion: null)]
    public CqlValueSet Antibiotic_Medications_for_Upper_Respiratory_Infection(CqlContext _) => _Antibiotic_Medications_for_Upper_Respiratory_Infection;
    private static readonly CqlValueSet _Antibiotic_Medications_for_Upper_Respiratory_Infection = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", null);

    [CqlValueSetDefinition("Comorbid Conditions for Respiratory Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", valueSetVersion: null)]
    public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions(CqlContext _) => _Comorbid_Conditions_for_Respiratory_Conditions;
    private static readonly CqlValueSet _Comorbid_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", null);

    [CqlValueSetDefinition("Competing Conditions for Respiratory Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", valueSetVersion: null)]
    public CqlValueSet Competing_Conditions_for_Respiratory_Conditions(CqlContext _) => _Competing_Conditions_for_Respiratory_Conditions;
    private static readonly CqlValueSet _Competing_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Medical Disability Exam", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", valueSetVersion: null)]
    public CqlValueSet Medical_Disability_Exam(CqlContext _) => _Medical_Disability_Exam;
    private static readonly CqlValueSet _Medical_Disability_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Group Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext _) => _Preventive_Care_Services_Group_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Upper Respiratory Infection", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", valueSetVersion: null)]
    public CqlValueSet Upper_Respiratory_Infection(CqlContext _) => _Upper_Respiratory_Infection;
    private static readonly CqlValueSet _Upper_Respiratory_Infection = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Unlisted preventive medicine service", codeId: "99429", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext _) => _Unlisted_preventive_medicine_service;
    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Unlisted_preventive_medicine_service]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -6811430900502275599L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS154FHIRAppropriateTxforURI-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (15)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -9118331668445394872L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -6271755292419861640L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -4865201966087926368L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 7512533384005297550L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 2523205904150552682L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter?>? Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = -8184800519206240530L;

    private IEnumerable<Encounter?>? Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? c_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);
        CqlValueSet? f_ = this.Medical_Disability_Exam(context);
        IEnumerable<Encounter?>? g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? h_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter?>(g_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(e_, j_);
        CqlValueSet? l_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter?>? m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? n_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter?>? o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? p_ = context.Operators.Union<Encounter?>(m_, o_);
        IEnumerable<Encounter?>? q_ = context.Operators.Union<Encounter?>(k_, p_);
        CqlValueSet? r_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter?>? s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter?>? u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? v_ = context.Operators.Union<Encounter?>(s_, u_);
        IEnumerable<Encounter?>? w_ = context.Operators.Union<Encounter?>(q_, v_);
        CqlValueSet? x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter?>? y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? z_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter?>? aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? ab_ = context.Operators.Union<Encounter?>(y_, aa_);
        IEnumerable<Encounter?>? ac_ = context.Operators.Union<Encounter?>(w_, ab_);
        CqlValueSet? ad_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter?>? ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? af_ = this.Telephone_Visits(context);
        IEnumerable<Encounter?>? ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? ah_ = context.Operators.Union<Encounter?>(ae_, ag_);
        IEnumerable<Encounter?>? ai_ = context.Operators.Union<Encounter?>(ac_, ah_);
        CqlValueSet? aj_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter?>? ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? am_(Encounter? E) {
            List<CodeableConcept>? at_ = E?.Type;

            CqlConcept? au_(CodeableConcept? @this) {
                CqlConcept? ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ay_;
            }


            bool? av_(CqlConcept? T) {
                CqlCode? az_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept? ba_ = context.Operators.ConvertCodeToConcept(az_);
                bool? bb_ = context.Operators.Equivalent(T, ba_);
                return bb_;
            }

            IEnumerable<CqlConcept?>? aw_ = context.Operators.SelectWhere<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)at_, au_, av_);
            bool? ax_ = context.Operators.Exists<CqlConcept?>(aw_);
            return ax_;
        }

        IEnumerable<Encounter?>? an_ = context.Operators.Where<Encounter?>(al_, am_);
        IEnumerable<Encounter?>? ao_ = context.Operators.Union<Encounter?>(ak_, an_);
        IEnumerable<Encounter?>? ap_ = context.Operators.Union<Encounter?>(ai_, ao_);
        IEnumerable<Encounter?>? aq_ = Status_1_15_000.Instance.isEncounterPerformed(context, ap_);

        bool? ar_(Encounter? ValidEncounter) {
            Period? bc_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime?>? bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bc_);
            CqlDateTime? be_ = context.Operators.End(bd_);
            CqlInterval<CqlDateTime?>? bf_ = this.Measurement_Period(context);
            CqlDateTime? bg_ = context.Operators.Start(bf_);
            CqlDateTime? bh_ = context.Operators.End(bf_);
            CqlQuantity? bi_ = context.Operators.Quantity(3m, "days");
            CqlDateTime? bj_ = context.Operators.Subtract(bh_, bi_);
            CqlInterval<CqlDateTime?>? bk_ = context.Operators.Interval(bg_, bj_, true, true);
            bool? bl_ = context.Operators.In<CqlDateTime?>(be_, bk_, "day");
            return bl_;
        }

        IEnumerable<Encounter?>? as_ = context.Operators.Where<Encounter?>(aq_, ar_);
        return as_;
    }


    [CqlExpressionDefinition("Encounter with Upper Respiratory Infection")]
    public IEnumerable<Encounter?>? Encounter_with_Upper_Respiratory_Infection(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Upper_Respiratory_Infection, Encounter_with_Upper_Respiratory_Infection_Compute);

    private const long _cacheIndex_Encounter_with_Upper_Respiratory_Infection = -3687519631180147673L;

    private IEnumerable<Encounter?>? Encounter_with_Upper_Respiratory_Infection_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Qualifying_Encounters(context);
        CqlValueSet? b_ = this.Upper_Respiratory_Infection(context);
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        Condition? d_(Condition? X) => X as Condition;
        IEnumerable<Condition?>? e_ = context.Operators.Select<Condition?, Condition?>(c_, d_);
        IEnumerable<Condition?>? f_ = Status_1_15_000.Instance.verified(context, e_);
        IEnumerable<ValueTuple<Encounter?, Condition?>>? g_ = context.Operators.CrossJoin<Encounter?, Condition?>(a_, f_);

        (CqlTupleMetadata, Encounter? QualifyingEncounters, Condition? URI)? h_(ValueTuple<Encounter?, Condition?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounters, Condition? URI)? m_ = (CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce, _valueTuple.Item1, _valueTuple.Item2);
            return m_;
        }


        bool? i_((CqlTupleMetadata, Encounter? QualifyingEncounters, Condition? URI)? tuple_figmirinmncaavfkbmahdktce) {
            CqlInterval<CqlDateTime?>? n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_figmirinmncaavfkbmahdktce?.URI);
            CqlDateTime? o_ = context.Operators.Start(n_);
            Period? p_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
            CqlInterval<CqlDateTime?>? q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            bool? r_ = context.Operators.In<CqlDateTime?>(o_, q_, "day");
            bool? s_ = context.Operators.OverlapsBefore(n_, q_, (string?)default);
            bool? t_ = context.Operators.Or(r_, s_);
            return t_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounters, Condition? URI)?>? j_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Condition?>, (CqlTupleMetadata, Encounter? QualifyingEncounters, Condition? URI)?>(g_, h_, i_);
        Encounter? k_((CqlTupleMetadata, Encounter? QualifyingEncounters, Condition? URI)? tuple_figmirinmncaavfkbmahdktce) => tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
        IEnumerable<Encounter?>? l_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounters, Condition? URI)?, Encounter?>(j_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter?>? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -5632040505747419286L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter? EncounterWithURI) {
            Patient? f_ = this.Patient(context);
            Date? g_ = f_?.BirthDateElement;
            string? h_ = g_?.Value;
            CqlDate? i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime?>? j_ = this.Measurement_Period(context);
            CqlDateTime? k_ = context.Operators.Start(j_);
            CqlDate? l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "month");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 3);
            return n_;
        }

        Encounter? c_(Encounter? EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter?>? d_ = context.Operators.WhereSelect<Encounter?, Encounter?>(a_, b_, c_);
        IEnumerable<Encounter?>? e_ = context.Operators.Distinct<Encounter?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter?>? Encounters_and_Assessments_with_Hospice_Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_and_Assessments_with_Hospice_Patient, Encounters_and_Assessments_with_Hospice_Patient_Compute);

    private const long _cacheIndex_Encounters_and_Assessments_with_Hospice_Patient = -6262491148793906459L;

    private IEnumerable<Encounter?>? Encounters_and_Assessments_with_Hospice_Patient_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);

        bool? b_(Encounter? EligibleEncounters) {
            bool? d_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
            return d_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter?>? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -4108508898050543235L;

    private IEnumerable<Encounter?>? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter?>? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -1983622220391695028L;

    private IEnumerable<Encounter?>? Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter?>? b_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        CqlValueSet? c_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition?>? d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        Condition? e_(Condition? X) => X as Condition;
        IEnumerable<Condition?>? f_ = context.Operators.Select<Condition?, Condition?>(d_, e_);
        IEnumerable<Condition?>? g_ = Status_1_15_000.Instance.verified(context, f_);
        Condition? h_(Condition? X) => X as Condition;
        IEnumerable<Condition?>? i_ = context.Operators.Select<Condition?, Condition?>(g_, h_);
        IEnumerable<Encounter?>? j_ = Antibiotic_1_11_000.Instance.Encounter_with_Comorbid_Condition_History(context, b_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(a_, j_);
        IEnumerable<MedicationRequest?>? l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? m_(MedicationRequest? MR) {
            IEnumerable<Medication?>? aj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ak_(Medication? M) {
                object? am_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? an_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ao_ = context.Operators.Split((string?)an_, "/");
                string? ap_ = context.Operators.Last<string?>(ao_);
                bool? aq_ = context.Operators.Equal(am_, ap_);
                CodeableConcept? ar_ = M?.Code;
                CqlConcept? as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ar_);
                CqlValueSet? at_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
                bool? au_ = context.Operators.ConceptInValueSet(as_, at_);
                bool? av_ = context.Operators.And(aq_, au_);
                return av_;
            }

            bool? al_ = context.Operators.WhereAny<Medication?>(aj_, ak_);
            return al_;
        }

        IEnumerable<MedicationRequest?>? n_ = context.Operators.Where<MedicationRequest?>(l_, m_);
        CqlValueSet? o_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
        IEnumerable<MedicationRequest?>? p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? q_ = context.Operators.Union<MedicationRequest?>(n_, p_);
        IEnumerable<MedicationRequest?>? r_ = Status_1_15_000.Instance.isMedicationActive(context, q_);
        IEnumerable<Encounter?>? s_ = Antibiotic_1_11_000.Instance.Encounter_with_Antibiotic_Medication_History(context, b_, r_);
        CqlValueSet? t_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition?>? u_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        CqlValueSet? v_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition?>? w_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? x_ = context.Operators.Union<Condition?>(u_, w_);
        CqlValueSet? y_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition?>? z_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? aa_ = context.Operators.Union<Condition?>(x_, z_);
        Condition? ab_(Condition? X) => X as Condition;
        IEnumerable<Condition?>? ac_ = context.Operators.Select<Condition?, Condition?>(aa_, ab_);
        IEnumerable<Condition?>? ad_ = Status_1_15_000.Instance.verified(context, ac_);
        Condition? ae_(Condition? X) => X as Condition;
        IEnumerable<Condition?>? af_ = context.Operators.Select<Condition?, Condition?>(ad_, ae_);
        IEnumerable<Encounter?>? ag_ = Antibiotic_1_11_000.Instance.Encounter_with_Competing_Diagnosis_History(context, b_, af_);
        IEnumerable<Encounter?>? ah_ = context.Operators.Union<Encounter?>(s_, ag_);
        IEnumerable<Encounter?>? ai_ = context.Operators.Union<Encounter?>(k_, ah_);
        return ai_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter?>? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -2125790364497770499L;

    private IEnumerable<Encounter?>? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter? EncounterWithURI) {
            IEnumerable<MedicationRequest?>? f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? g_(MedicationRequest? MR) {
                IEnumerable<Medication?>? p_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? q_(Medication? M) {
                    object? s_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? t_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? u_ = context.Operators.Split((string?)t_, "/");
                    string? v_ = context.Operators.Last<string?>(u_);
                    bool? w_ = context.Operators.Equal(s_, v_);
                    CodeableConcept? x_ = M?.Code;
                    CqlConcept? y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet? z_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);
                    return ab_;
                }

                bool? r_ = context.Operators.WhereAny<Medication?>(p_, q_);
                return r_;
            }

            IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(f_, g_);
            CqlValueSet? i_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
            IEnumerable<MedicationRequest?>? j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? k_ = context.Operators.Union<MedicationRequest?>(h_, j_);
            IEnumerable<MedicationRequest?>? l_ = Status_1_15_000.Instance.isMedicationOrder(context, k_);

            bool? m_(MedicationRequest? OrderedAntibiotic) {
                FhirDateTime? ac_ = OrderedAntibiotic?.AuthoredOnElement;
                CqlDateTime? ad_ = context.Operators.Convert<CqlDateTime?>(ac_);
                Period? ae_ = EncounterWithURI?.Period;
                CqlInterval<CqlDateTime?>? af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime? ag_ = context.Operators.Start(af_);
                CqlQuantity? ah_ = context.Operators.Quantity(3m, "days");
                CqlDateTime? ai_ = context.Operators.Add(ag_, ah_);
                CqlInterval<CqlDateTime?>? aj_ = context.Operators.Interval(ag_, ai_, true, true);
                bool? ak_ = context.Operators.In<CqlDateTime?>(ad_, aj_, (string?)default);
                bool? al_ = context.Operators.Not((bool?)(ag_ is null));
                bool? am_ = context.Operators.And(ak_, al_);
                return am_;
            }

            bool? n_ = context.Operators.WhereAny<MedicationRequest?>(l_, m_);
            bool? o_ = context.Operators.Not(n_);
            return o_;
        }

        Encounter? c_(Encounter? EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter?>? d_ = context.Operators.WhereSelect<Encounter?, Encounter?>(a_, b_, c_);
        IEnumerable<Encounter?>? e_ = context.Operators.Distinct<Encounter?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter?>? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = 3245442145778577805L;

    private IEnumerable<Encounter?>? Stratification_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter? EncounterWithURI) {
            Patient? f_ = this.Patient(context);
            Date? g_ = f_?.BirthDateElement;
            string? h_ = g_?.Value;
            CqlDate? i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime?>? j_ = this.Measurement_Period(context);
            CqlDateTime? k_ = context.Operators.Start(j_);
            CqlDate? l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "month");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 3);
            int? o_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            bool? p_ = context.Operators.LessOrEqual(o_, 17);
            bool? q_ = context.Operators.And(n_, p_);
            return q_;
        }

        Encounter? c_(Encounter? EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter?>? d_ = context.Operators.WhereSelect<Encounter?, Encounter?>(a_, b_, c_);
        IEnumerable<Encounter?>? e_ = context.Operators.Distinct<Encounter?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter?>? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -727425837425859133L;

    private IEnumerable<Encounter?>? Stratification_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter? EncounterWithURI) {
            Patient? f_ = this.Patient(context);
            Date? g_ = f_?.BirthDateElement;
            string? h_ = g_?.Value;
            CqlDate? i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime?>? j_ = this.Measurement_Period(context);
            CqlDateTime? k_ = context.Operators.Start(j_);
            CqlDate? l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            CqlInterval<int?>? n_ = context.Operators.Interval(18, 64, true, true);
            bool? o_ = context.Operators.In<int?>(m_, n_, (string?)default);
            return o_;
        }

        Encounter? c_(Encounter? EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter?>? d_ = context.Operators.WhereSelect<Encounter?, Encounter?>(a_, b_, c_);
        IEnumerable<Encounter?>? e_ = context.Operators.Distinct<Encounter?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter?>? Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private const long _cacheIndex_Stratification_3 = -5746511768018411774L;

    private IEnumerable<Encounter?>? Stratification_3_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter? EncounterWithURI) {
            Patient? f_ = this.Patient(context);
            Date? g_ = f_?.BirthDateElement;
            string? h_ = g_?.Value;
            CqlDate? i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime?>? j_ = this.Measurement_Period(context);
            CqlDateTime? k_ = context.Operators.Start(j_);
            CqlDate? l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 65);
            return n_;
        }

        Encounter? c_(Encounter? EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter?>? d_ = context.Operators.WhereSelect<Encounter?, Encounter?>(a_, b_, c_);
        IEnumerable<Encounter?>? e_ = context.Operators.Distinct<Encounter?>(d_);
        return e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS154FHIRAppropriateTxforURI_1_0_000() {}

    public static CMS154FHIRAppropriateTxforURI_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS154FHIRAppropriateTxforURI";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance, Antibiotic_1_11_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
       [typeof(Encounter), typeof(Condition)],
       ["QualifyingEncounters", "URI"]);

    #endregion CqlTupleMetadata Properties

}
