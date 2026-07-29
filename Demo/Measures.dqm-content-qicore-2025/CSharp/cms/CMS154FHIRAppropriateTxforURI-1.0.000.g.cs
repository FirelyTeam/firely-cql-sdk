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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -6811430900502275599L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS154FHIRAppropriateTxforURI-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (15)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -9118331668445394872L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -6271755292419861640L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -4865201966087926368L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 7512533384005297550L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 2523205904150552682L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = -8184800519206240530L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Medical_Disability_Exam(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Office_Visit(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet z_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
        CqlValueSet ad_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet af_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ah_ = context.Operators.Union<Encounter>(ae_, ag_);
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ac_, ah_);
        CqlValueSet aj_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? am_(Encounter E) {
            List<CodeableConcept> at_ = E?.Type;

            CqlConcept au_(CodeableConcept @this) {
                CqlConcept az_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return az_;
            }

            IEnumerable<CqlConcept> av_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)at_, au_);

            bool? aw_(CqlConcept T) {
                CqlCode ba_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                bool? bc_ = context.Operators.Equivalent(T, bb_);
                return bc_;
            }

            IEnumerable<CqlConcept> ax_ = context.Operators.Where<CqlConcept>(av_, aw_);
            bool? ay_ = context.Operators.Exists<CqlConcept>(ax_);
            return ay_;
        }

        IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);
        IEnumerable<Encounter> ao_ = context.Operators.Union<Encounter>(ak_, an_);
        IEnumerable<Encounter> ap_ = context.Operators.Union<Encounter>(ai_, ao_);
        IEnumerable<Encounter> aq_ = Status_1_15_000.Instance.isEncounterPerformed(context, ap_);

        bool? ar_(Encounter ValidEncounter) {
            Period bd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
            CqlDateTime bf_ = context.Operators.End(be_);
            CqlInterval<CqlDateTime> bg_ = this.Measurement_Period(context);
            CqlDateTime bh_ = context.Operators.Start(bg_);
            CqlDateTime bi_ = context.Operators.End(bg_);
            CqlQuantity bj_ = context.Operators.Quantity(3m, "days");
            CqlDateTime bk_ = context.Operators.Subtract(bi_, bj_);
            CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bh_, bk_, true, true);
            bool? bm_ = context.Operators.In<CqlDateTime>(bf_, bl_, "day");
            return bm_;
        }

        IEnumerable<Encounter> as_ = context.Operators.Where<Encounter>(aq_, ar_);
        return as_;
    }


    [CqlExpressionDefinition("Encounter with Upper Respiratory Infection")]
    public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Upper_Respiratory_Infection, Encounter_with_Upper_Respiratory_Infection_Compute);

    private const long _cacheIndex_Encounter_with_Upper_Respiratory_Infection = -3687519631180147673L;

    private IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        CqlValueSet b_ = this.Upper_Respiratory_Infection(context);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        Condition d_(Condition X) => X as Condition;
        IEnumerable<Condition> e_ = context.Operators.Select<Condition, Condition>(c_, d_);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);
        IEnumerable<ValueTuple<Encounter, Condition>> g_ = context.Operators.CrossJoin<Encounter, Condition>(a_, f_);

        (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? h_(ValueTuple<Encounter, Condition> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? o_ = (CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> i_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(g_, h_);

        bool? j_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) {
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_figmirinmncaavfkbmahdktce?.URI);
            CqlDateTime q_ = context.Operators.Start(p_);
            Period r_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
            bool? u_ = context.Operators.OverlapsBefore(p_, s_, (string)default);
            bool? v_ = context.Operators.Or(t_, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> k_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(i_, j_);
        Encounter l_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) => tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
        IEnumerable<Encounter> m_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?, Encounter>(k_, l_);
        IEnumerable<Encounter> n_ = context.Operators.Distinct<Encounter>(m_);
        return n_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -5632040505747419286L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter EncounterWithURI) {
            Patient g_ = this.Patient(context);
            Date h_ = g_?.BirthDateElement;
            string i_ = h_?.Value;
            CqlDate j_ = context.Operators.ConvertStringToDate(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            int? n_ = context.Operators.CalculateAgeAt(j_, m_, "month");
            bool? o_ = context.Operators.GreaterOrEqual(n_, 3);
            return o_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_and_Assessments_with_Hospice_Patient, Encounters_and_Assessments_with_Hospice_Patient_Compute);

    private const long _cacheIndex_Encounters_and_Assessments_with_Hospice_Patient = -6262491148793906459L;

    private IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        bool? b_(Encounter EligibleEncounters) {
            bool? d_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
            return d_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -4108508898050543235L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -1983622220391695028L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        CqlValueSet c_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        Condition e_(Condition X) => X as Condition;
        IEnumerable<Condition> f_ = context.Operators.Select<Condition, Condition>(d_, e_);
        IEnumerable<Condition> g_ = Status_1_15_000.Instance.verified(context, f_);
        Condition h_(Condition X) => X as Condition;
        IEnumerable<Condition> i_ = context.Operators.Select<Condition, Condition>(g_, h_);
        IEnumerable<Encounter> j_ = Antibiotic_1_11_000.Instance.Encounter_with_Comorbid_Condition_History(context, b_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(a_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> aj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ak_(Medication M) {
                object an_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ao_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ap_ = context.Operators.Split((string)ao_, "/");
                string aq_ = context.Operators.Last<string>(ap_);
                bool? ar_ = context.Operators.Equal(an_, aq_);
                CodeableConcept as_ = M?.Code;
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, as_);
                CqlValueSet au_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
                bool? av_ = context.Operators.ConceptInValueSet(at_, au_);
                bool? aw_ = context.Operators.And(ar_, av_);
                return aw_;
            }

            IEnumerable<Medication> al_ = context.Operators.Where<Medication>(aj_, ak_);
            bool? am_ = context.Operators.Exists<Medication>(al_);
            return am_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
        CqlValueSet o_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = Status_1_15_000.Instance.isMedicationActive(context, q_);
        IEnumerable<Encounter> s_ = Antibiotic_1_11_000.Instance.Encounter_with_Antibiotic_Medication_History(context, b_, r_);
        CqlValueSet t_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> u_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        CqlValueSet v_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> w_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> x_ = context.Operators.Union<Condition>(u_, w_);
        CqlValueSet y_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> z_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> aa_ = context.Operators.Union<Condition>(x_, z_);
        Condition ab_(Condition X) => X as Condition;
        IEnumerable<Condition> ac_ = context.Operators.Select<Condition, Condition>(aa_, ab_);
        IEnumerable<Condition> ad_ = Status_1_15_000.Instance.verified(context, ac_);
        Condition ae_(Condition X) => X as Condition;
        IEnumerable<Condition> af_ = context.Operators.Select<Condition, Condition>(ad_, ae_);
        IEnumerable<Encounter> ag_ = Antibiotic_1_11_000.Instance.Encounter_with_Competing_Diagnosis_History(context, b_, af_);
        IEnumerable<Encounter> ah_ = context.Operators.Union<Encounter>(s_, ag_);
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(k_, ah_);
        return ai_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -2125790364497770499L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter EncounterWithURI) {
            IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? h_(MedicationRequest MR) {
                IEnumerable<Medication> r_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? s_(Medication M) {
                    object v_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object w_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> x_ = context.Operators.Split((string)w_, "/");
                    string y_ = context.Operators.Last<string>(x_);
                    bool? z_ = context.Operators.Equal(v_, y_);
                    CodeableConcept aa_ = M?.Code;
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                    CqlValueSet ac_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
                    bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                    bool? ae_ = context.Operators.And(z_, ad_);
                    return ae_;
                }

                IEnumerable<Medication> t_ = context.Operators.Where<Medication>(r_, s_);
                bool? u_ = context.Operators.Exists<Medication>(t_);
                return u_;
            }

            IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
            CqlValueSet j_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
            IEnumerable<MedicationRequest> m_ = Status_1_15_000.Instance.isMedicationOrder(context, l_);

            bool? n_(MedicationRequest OrderedAntibiotic) {
                FhirDateTime af_ = OrderedAntibiotic?.AuthoredOnElement;
                CqlDateTime ag_ = context.Operators.Convert<CqlDateTime>(af_);
                Period ah_ = EncounterWithURI?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                CqlQuantity ak_ = context.Operators.Quantity(3m, "days");
                CqlDateTime al_ = context.Operators.Add(aj_, ak_);
                CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aj_, al_, true, true);
                bool? an_ = context.Operators.In<CqlDateTime>(ag_, am_, (string)default);
                bool? ao_ = context.Operators.Not((bool?)(aj_ is null));
                bool? ap_ = context.Operators.And(an_, ao_);
                return ap_;
            }

            IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);
            bool? p_ = context.Operators.Exists<MedicationRequest>(o_);
            bool? q_ = context.Operators.Not(p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = 3245442145778577805L;

    private IEnumerable<Encounter> Stratification_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter EncounterWithURI) {
            Patient g_ = this.Patient(context);
            Date h_ = g_?.BirthDateElement;
            string i_ = h_?.Value;
            CqlDate j_ = context.Operators.ConvertStringToDate(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            int? n_ = context.Operators.CalculateAgeAt(j_, m_, "month");
            bool? o_ = context.Operators.GreaterOrEqual(n_, 3);
            int? p_ = context.Operators.CalculateAgeAt(j_, m_, "year");
            bool? q_ = context.Operators.LessOrEqual(p_, 17);
            bool? r_ = context.Operators.And(o_, q_);
            return r_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -727425837425859133L;

    private IEnumerable<Encounter> Stratification_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter EncounterWithURI) {
            Patient g_ = this.Patient(context);
            Date h_ = g_?.BirthDateElement;
            string i_ = h_?.Value;
            CqlDate j_ = context.Operators.ConvertStringToDate(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            int? n_ = context.Operators.CalculateAgeAt(j_, m_, "year");
            CqlInterval<int?> o_ = context.Operators.Interval(18, 64, true, true);
            bool? p_ = context.Operators.In<int?>(n_, o_, (string)default);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private const long _cacheIndex_Stratification_3 = -5746511768018411774L;

    private IEnumerable<Encounter> Stratification_3_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        bool? b_(Encounter EncounterWithURI) {
            Patient g_ = this.Patient(context);
            Date h_ = g_?.BirthDateElement;
            string i_ = h_?.Value;
            CqlDate j_ = context.Operators.ConvertStringToDate(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            int? n_ = context.Operators.CalculateAgeAt(j_, m_, "year");
            bool? o_ = context.Operators.GreaterOrEqual(n_, 65);
            return o_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
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
