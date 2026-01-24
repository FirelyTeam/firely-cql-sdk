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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS154FHIRAppropriateTxforURI", "1.0.000")]
public partial class CMS154FHIRAppropriateTxforURI_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS154FHIRAppropriateTxforURI_1_0_000>
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
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

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
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

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
            CqlDateTime bj_ = context.Operators.End(bg_);
            CqlQuantity bk_ = context.Operators.Quantity(3m, "days");
            CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
            CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(bh_, bl_, true, true);
            bool? bn_ = context.Operators.In<CqlDateTime>(bf_, bm_, "day");
            return bn_;
        }

        IEnumerable<Encounter> as_ = context.Operators.Where<Encounter>(aq_, ar_);
        return as_;
    }


    [CqlExpressionDefinition("Encounter with Upper Respiratory Infection")]
    public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Encounter_with_Upper_Respiratory_Infection, Encounter_with_Upper_Respiratory_Infection_Compute);

    private IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        CqlValueSet b_ = this.Upper_Respiratory_Infection(context);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        object d_(Condition X) => X as object;
        IEnumerable<object> e_ = context.Operators.Select<Condition, object>(c_, d_);
        IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
        IEnumerable<ValueTuple<Encounter, object>> g_ = context.Operators.CrossJoin<Encounter, object>(a_, f_);

        (CqlTupleMetadata, Encounter QualifyingEncounters, object URI)? h_(ValueTuple<Encounter, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounters, object URI)? o_ = (CqlTupleMetadata_EVVfJAIMBNEGYhKEHLiZLhEGQ, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, object URI)?> i_ = context.Operators.Select<ValueTuple<Encounter, object>, (CqlTupleMetadata, Encounter QualifyingEncounters, object URI)?>(g_, h_);

        bool? j_((CqlTupleMetadata, Encounter QualifyingEncounters, object URI)? tuple_evvfjaimbnegyhkehlizlhegq) {
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_evvfjaimbnegyhkehlizlhegq?.URI);
            CqlDateTime q_ = context.Operators.Start(p_);
            Period r_ = tuple_evvfjaimbnegyhkehlizlhegq?.QualifyingEncounters?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? x_ = context.Operators.OverlapsBefore(p_, w_, default);
            bool? y_ = context.Operators.Or(t_, x_);
            return y_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, object URI)?> k_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounters, object URI)?>(i_, j_);
        Encounter l_((CqlTupleMetadata, Encounter QualifyingEncounters, object URI)? tuple_evvfjaimbnegyhkehlizlhegq) => tuple_evvfjaimbnegyhkehlizlhegq?.QualifyingEncounters;
        IEnumerable<Encounter> m_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounters, object URI)?, Encounter>(k_, l_);
        IEnumerable<Encounter> n_ = context.Operators.Distinct<Encounter>(m_);
        return n_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

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
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Encounters_and_Assessments_with_Hospice_Patient, Encounters_and_Assessments_with_Hospice_Patient_Compute);

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
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        CqlValueSet c_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        object e_(Condition X) => X as object;
        IEnumerable<object> f_ = context.Operators.Select<Condition, object>(d_, e_);
        IEnumerable<object> g_ = Status_1_15_000.Instance.verified(context, f_);
        Condition h_(object X) => X as Condition;
        IEnumerable<Condition> i_ = context.Operators.Select<object, Condition>(g_, h_);
        IEnumerable<Encounter> j_ = Antibiotic_1_11_000.Instance.Encounter_with_Comorbid_Condition_History(context, b_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(a_, j_);
        CqlValueSet m_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
        IEnumerable<MedicationRequest> n_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> p_(MedicationRequest MR) {
            IEnumerable<Medication> al_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? am_(Medication M) {
                object aq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ar_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> as_ = context.Operators.Split((string)ar_, "/");
                string at_ = context.Operators.Last<string>(as_);
                bool? au_ = context.Operators.Equal(aq_, at_);
                CodeableConcept av_ = M?.Code;
                CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
                CqlValueSet ax_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
                bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
                bool? az_ = context.Operators.And(au_, ay_);
                return az_;
            }

            IEnumerable<Medication> an_ = context.Operators.Where<Medication>(al_, am_);
            MedicationRequest ao_(Medication M) => MR;
            IEnumerable<MedicationRequest> ap_ = context.Operators.Select<Medication, MedicationRequest>(an_, ao_);
            return ap_;
        }

        IEnumerable<MedicationRequest> q_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(o_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(n_, q_);
        IEnumerable<MedicationRequest> s_ = Status_1_15_000.Instance.isMedicationActive(context, r_);
        IEnumerable<Encounter> t_ = Antibiotic_1_11_000.Instance.Encounter_with_Antibiotic_Medication_History(context, b_, s_);
        CqlValueSet v_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> w_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        CqlValueSet x_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> y_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> z_ = context.Operators.Union<Condition>(w_, y_);
        CqlValueSet aa_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> ab_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> ac_ = context.Operators.Union<Condition>(z_, ab_);
        IEnumerable<object> ae_ = context.Operators.Select<Condition, object>(ac_, e_);
        IEnumerable<object> af_ = Status_1_15_000.Instance.verified(context, ae_);
        IEnumerable<Condition> ah_ = context.Operators.Select<object, Condition>(af_, h_);
        IEnumerable<Encounter> ai_ = Antibiotic_1_11_000.Instance.Encounter_with_Competing_Diagnosis_History(context, b_, ah_);
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(t_, ai_);
        IEnumerable<Encounter> ak_ = context.Operators.Union<Encounter>(k_, aj_);
        return ak_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);

        IEnumerable<Encounter> c_(Encounter EncounterWithURI) {
            CqlValueSet i_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
            IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            IEnumerable<MedicationRequest> l_(MedicationRequest MR) {
                IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? u_(Medication M) {
                    object y_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object z_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> aa_ = context.Operators.Split((string)z_, "/");
                    string ab_ = context.Operators.Last<string>(aa_);
                    bool? ac_ = context.Operators.Equal(y_, ab_);
                    CodeableConcept ad_ = M?.Code;
                    CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                    CqlValueSet af_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
                    bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                    bool? ah_ = context.Operators.And(ac_, ag_);
                    return ah_;
                }

                IEnumerable<Medication> v_ = context.Operators.Where<Medication>(t_, u_);
                MedicationRequest w_(Medication M) => MR;
                IEnumerable<MedicationRequest> x_ = context.Operators.Select<Medication, MedicationRequest>(v_, w_);
                return x_;
            }

            IEnumerable<MedicationRequest> m_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(k_, l_);
            IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(j_, m_);
            IEnumerable<MedicationRequest> o_ = Status_1_15_000.Instance.isMedicationOrder(context, n_);

            bool? p_(MedicationRequest OrderedAntibiotic) {
                FhirDateTime ai_ = OrderedAntibiotic?.AuthoredOnElement;
                CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
                Period ak_ = EncounterWithURI?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime am_ = context.Operators.Start(al_);
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlQuantity aq_ = context.Operators.Quantity(3m, "days");
                CqlDateTime ar_ = context.Operators.Add(ap_, aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(am_, ar_, true, true);
                bool? at_ = context.Operators.In<CqlDateTime>(aj_, as_, default);
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
                bool? ay_ = context.Operators.And(at_, ax_);
                return ay_;
            }

            IEnumerable<MedicationRequest> q_ = context.Operators.Where<MedicationRequest>(o_, p_);
            Encounter r_(MedicationRequest OrderedAntibiotic) => EncounterWithURI;
            IEnumerable<Encounter> s_ = context.Operators.Select<MedicationRequest, Encounter>(q_, r_);
            return s_;
        }

        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(a_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(a_, d_);
        Encounter f_(Encounter EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter> g_ = context.Operators.Select<Encounter, Encounter>(e_, f_);
        IEnumerable<Encounter> h_ = context.Operators.Distinct<Encounter>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

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
            Date q_ = g_?.BirthDateElement;
            string r_ = q_?.Value;
            CqlDate s_ = context.Operators.ConvertStringToDate(r_);
            CqlDateTime u_ = context.Operators.Start(k_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            int? w_ = context.Operators.CalculateAgeAt(s_, v_, "year");
            bool? x_ = context.Operators.LessOrEqual(w_, 17);
            bool? y_ = context.Operators.And(o_, x_);
            return y_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

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
            bool? p_ = context.Operators.In<int?>(n_, o_, default);
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
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

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

    #region Cache Index Fields (16)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Qualifying_Encounters = -1;
    private int _cacheIndex_Encounter_with_Upper_Respiratory_Infection = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Encounters_and_Assessments_with_Hospice_Patient = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_Numerator = -1;
    private int _cacheIndex_Stratification_1 = -1;
    private int _cacheIndex_Stratification_2 = -1;
    private int _cacheIndex_Stratification_3 = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        _cacheIndex_Qualifying_Encounters = index++;
        _cacheIndex_Encounter_with_Upper_Respiratory_Infection = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Encounters_and_Assessments_with_Hospice_Patient = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_Stratification_1 = index++;
        _cacheIndex_Stratification_2 = index++;
        _cacheIndex_Stratification_3 = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS154FHIRAppropriateTxforURI_1_0_000() {}

    public static CMS154FHIRAppropriateTxforURI_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS154FHIRAppropriateTxforURI";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance, Antibiotic_1_11_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (1)

    private static CqlTupleMetadata CqlTupleMetadata_EVVfJAIMBNEGYhKEHLiZLhEGQ = new(
       [typeof(Encounter), typeof(object)],
       ["QualifyingEncounters", "URI"]);

    #endregion CqlTupleMetadata Properties

}
