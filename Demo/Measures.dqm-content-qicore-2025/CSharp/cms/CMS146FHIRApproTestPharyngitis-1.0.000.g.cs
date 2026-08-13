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
[CqlLibrary("CMS146FHIRApproTestPharyngitis", "1.0.000")]
public partial class CMS146FHIRApproTestPharyngitis_1_0_000 : ILibrary, ISingleton<CMS146FHIRApproTestPharyngitis_1_0_000>
{
    #region ValueSets (19)

    [CqlValueSetDefinition("Acute Pharyngitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", valueSetVersion: null)]
    public CqlValueSet Acute_Pharyngitis(CqlContext _) => _Acute_Pharyngitis;
    private static readonly CqlValueSet _Acute_Pharyngitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", null);

    [CqlValueSetDefinition("Acute Tonsillitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", valueSetVersion: null)]
    public CqlValueSet Acute_Tonsillitis(CqlContext _) => _Acute_Tonsillitis;
    private static readonly CqlValueSet _Acute_Tonsillitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", null);

    [CqlValueSetDefinition("Antibiotic Medications for Pharyngitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", valueSetVersion: null)]
    public CqlValueSet Antibiotic_Medications_for_Pharyngitis(CqlContext _) => _Antibiotic_Medications_for_Pharyngitis;
    private static readonly CqlValueSet _Antibiotic_Medications_for_Pharyngitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", null);

    [CqlValueSetDefinition("Comorbid Conditions for Respiratory Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", valueSetVersion: null)]
    public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions(CqlContext _) => _Comorbid_Conditions_for_Respiratory_Conditions;
    private static readonly CqlValueSet _Comorbid_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", null);

    [CqlValueSetDefinition("Competing Conditions for Respiratory Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", valueSetVersion: null)]
    public CqlValueSet Competing_Conditions_for_Respiratory_Conditions(CqlContext _) => _Competing_Conditions_for_Respiratory_Conditions;
    private static readonly CqlValueSet _Competing_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Group A Streptococcus Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", valueSetVersion: null)]
    public CqlValueSet Group_A_Streptococcus_Test(CqlContext _) => _Group_A_Streptococcus_Test;
    private static readonly CqlValueSet _Group_A_Streptococcus_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", null);

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

    private const long _cacheIndex_Measurement_Period = -6776689049211967329L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS146FHIRApproTestPharyngitis-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (18)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 3030144396687509539L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 8061848602820824818L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -5350681135550590122L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 2114658340450479406L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 4663127546923731554L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = -9161728147981111079L;

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
        CqlValueSet l_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        CqlValueSet x_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? aa_(Encounter E) {
            List<CodeableConcept> at_ = E?.Type;

            CqlConcept au_(CodeableConcept @this) {
                CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ay_;
            }


            bool? av_(CqlConcept T) {
                CqlCode az_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                bool? bb_ = context.Operators.Equivalent(T, ba_);
                return bb_;
            }

            IEnumerable<CqlConcept> aw_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)at_, au_, av_);
            bool? ax_ = context.Operators.Exists<CqlConcept>(aw_);
            return ax_;
        }

        IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(y_, ab_);
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(w_, ac_);
        CqlValueSet ae_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> af_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ag_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> ah_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(af_, ah_);
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ad_, ai_);
        CqlValueSet ak_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet am_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> an_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ao_ = context.Operators.Union<Encounter>(al_, an_);
        IEnumerable<Encounter> ap_ = context.Operators.Union<Encounter>(aj_, ao_);
        IEnumerable<Encounter> aq_ = Status_1_15_000.Instance.isEncounterPerformed(context, ap_);

        bool? ar_(Encounter ValidEncounter) {
            Period bc_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bc_);
            CqlDateTime be_ = context.Operators.End(bd_);
            CqlInterval<CqlDateTime> bf_ = this.Measurement_Period(context);
            CqlDateTime bg_ = context.Operators.Start(bf_);
            CqlDateTime bh_ = context.Operators.End(bf_);
            CqlQuantity bi_ = context.Operators.Quantity(3m, "days");
            CqlDateTime bj_ = context.Operators.Subtract(bh_, bi_);
            CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(bg_, bj_, true, true);
            bool? bl_ = context.Operators.In<CqlDateTime>(be_, bk_, "day");
            return bl_;
        }

        IEnumerable<Encounter> as_ = context.Operators.Where<Encounter>(aq_, ar_);
        return as_;
    }


    [CqlExpressionDefinition("Encounter With Antibiotic Ordered Within Three Days")]
    public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Antibiotic_Ordered_Within_Three_Days, Encounter_With_Antibiotic_Ordered_Within_Three_Days_Compute);

    private const long _cacheIndex_Encounter_With_Antibiotic_Ordered_Within_Three_Days = 5068032210244465453L;

    private IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);

        bool? b_(Encounter EDOrAmbulatoryVisit) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                    string s_ = context.Operators.Last<string>(r_);
                    bool? t_ = context.Operators.Equal(p_, s_);
                    // CQL 'and': right operand skipped when left is false
                    if (t_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Antibiotic_Medications_for_Pharyngitis(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                        return t_ & x_;
                    }
                }

                bool? o_ = context.Operators.WhereAny<Medication>(m_, n_);
                return o_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Antibiotic_Medications_for_Pharyngitis(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);
            IEnumerable<MedicationRequest> j_ = Status_1_15_000.Instance.isMedicationOrder(context, i_);

            bool? k_(MedicationRequest AntibioticOrdered) {
                Period y_ = EDOrAmbulatoryVisit?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                FhirDateTime ac_ = AntibioticOrdered?.AuthoredOnElement;
                CqlDateTime ad_ = context.Operators.Convert<CqlDateTime>(ac_);
                CqlQuantity ae_ = context.Operators.Quantity(3m, "days");
                CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
                CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(af_, ad_, true, true);
                bool? ah_ = context.Operators.In<CqlDateTime>(ab_, ag_, "day");
                // CQL 'and' (82:17-82:128): right operand skipped when left is false
                if (ah_ is false)
                {
                    return false;
                }
                else
                {
                    FhirDateTime ai_ = AntibioticOrdered?.AuthoredOnElement;
                    CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
                    return ah_ & (!((bool?)(aj_ is null)));
                }
            }

            bool? l_ = context.Operators.WhereAny<MedicationRequest>(j_, k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Pharyngitis or Tonsillitis")]
    public IEnumerable<Condition> Pharyngitis_or_Tonsillitis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pharyngitis_or_Tonsillitis, Pharyngitis_or_Tonsillitis_Compute);

    private const long _cacheIndex_Pharyngitis_or_Tonsillitis = -2294604684325091505L;

    private IEnumerable<Condition> Pharyngitis_or_Tonsillitis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        CqlValueSet c_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        Condition f_(Condition X) => X as Condition;
        IEnumerable<Condition> g_ = context.Operators.Select<Condition, Condition>(e_, f_);
        IEnumerable<Condition> h_ = Status_1_15_000.Instance.verified(context, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
    public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic, Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic_Compute);

    private const long _cacheIndex_Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic = 1361420039381642473L;

    private IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days(context);
        IEnumerable<Condition> b_ = this.Pharyngitis_or_Tonsillitis(context);
        IEnumerable<ValueTuple<Encounter, Condition>> c_ = context.Operators.CrossJoin<Encounter, Condition>(a_, b_);

        (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? d_(ValueTuple<Encounter, Condition> _valueTuple) {
            (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? i_ = (CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? e_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh) {
            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_ypyxedbbcqbdavhxvckuwmfh?.AcutePharyngitisTonsillitis);
            CqlDateTime k_ = context.Operators.Start(j_);
            Period l_ = tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh) => tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?, Encounter>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -7344295049066052896L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);

        bool? b_(Encounter EncounterWithPharyngitis) {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 3);
            return n_;
        }

        Encounter c_(Encounter EncounterWithPharyngitis) => EncounterWithPharyngitis;
        IEnumerable<Encounter> d_ = context.Operators.WhereSelect<Encounter, Encounter>(a_, b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 8474826842785951650L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_and_Assessments_with_Hospice_Patient, Encounters_and_Assessments_with_Hospice_Patient_Compute);

    private const long _cacheIndex_Encounters_and_Assessments_with_Hospice_Patient = 1591674743266285230L;

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


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 605034055821366566L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
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
            IEnumerable<Medication> ad_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ae_(Medication M) {
                object ag_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ah_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ai_ = context.Operators.Split((string)ah_, "/");
                string aj_ = context.Operators.Last<string>(ai_);
                bool? ak_ = context.Operators.Equal(ag_, aj_);
                // CQL 'and': right operand skipped when left is false
                if (ak_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept al_ = M?.Code;
                    CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
                    CqlValueSet an_ = this.Antibiotic_Medications_for_Pharyngitis(context);
                    bool? ao_ = context.Operators.ConceptInValueSet(am_, an_);
                    return ak_ & ao_;
                }
            }

            bool? af_ = context.Operators.WhereAny<Medication>(ad_, ae_);
            return af_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
        CqlValueSet o_ = this.Antibiotic_Medications_for_Pharyngitis(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = Status_1_15_000.Instance.isMedicationActive(context, q_);
        IEnumerable<Encounter> s_ = Antibiotic_1_11_000.Instance.Encounter_with_Antibiotic_Medication_History(context, b_, r_);
        CqlValueSet t_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> u_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        Condition v_(Condition X) => X as Condition;
        IEnumerable<Condition> w_ = context.Operators.Select<Condition, Condition>(u_, v_);
        IEnumerable<Condition> x_ = Status_1_15_000.Instance.verified(context, w_);
        Condition y_(Condition X) => X as Condition;
        IEnumerable<Condition> z_ = context.Operators.Select<Condition, Condition>(x_, y_);
        IEnumerable<Encounter> aa_ = Antibiotic_1_11_000.Instance.Encounter_with_Competing_Diagnosis_History(context, b_, z_);
        IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(s_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(k_, ab_);
        return ac_;
    }


    [CqlExpressionDefinition("Group A Streptococcus Lab Test With Result")]
    public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Group_A_Streptococcus_Lab_Test_With_Result, Group_A_Streptococcus_Lab_Test_With_Result_Compute);

    private const long _cacheIndex_Group_A_Streptococcus_Lab_Test_With_Result = 6710198913720266606L;

    private IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Group_A_Streptococcus_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);

        bool? d_(Observation GroupAStreptococcusTest) {
            DataType f_ = GroupAStreptococcusTest?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            return !((bool?)(g_ is null));
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 3241845342339342232L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Group_A_Streptococcus_Lab_Test_With_Result(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);

        (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? d_(ValueTuple<Observation, Encounter> _valueTuple) {
            (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? i_ = (CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? e_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) {
            DataType j_ = tuple_ffguysnebcxllexfcmjoehbij?.GroupAStreptococcusTest?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlDateTime m_ = context.Operators.Start(l_);
            Period n_ = tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlQuantity q_ = context.Operators.Quantity(3m, "days");
            CqlDateTime r_ = context.Operators.Subtract(p_, q_);
            CqlDateTime s_ = context.Operators.Add(p_, q_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(r_, s_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, "day");
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> f_ = context.Operators.SelectWhere<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) => tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?, Encounter>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = 3931302983264712514L;

    private IEnumerable<Encounter> Stratification_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);

        bool? b_(Encounter EncounterWithPharyngitis) {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            CqlInterval<int?> n_ = context.Operators.Interval(3, 17, true, true);
            bool? o_ = context.Operators.In<int?>(m_, n_, (string)default);
            return o_;
        }

        Encounter c_(Encounter EncounterWithPharyngitis) => EncounterWithPharyngitis;
        IEnumerable<Encounter> d_ = context.Operators.WhereSelect<Encounter, Encounter>(a_, b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -1170160420726039475L;

    private IEnumerable<Encounter> Stratification_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);

        bool? b_(Encounter EncounterWithPharyngitis) {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            CqlInterval<int?> n_ = context.Operators.Interval(18, 64, true, true);
            bool? o_ = context.Operators.In<int?>(m_, n_, (string)default);
            return o_;
        }

        Encounter c_(Encounter EncounterWithPharyngitis) => EncounterWithPharyngitis;
        IEnumerable<Encounter> d_ = context.Operators.WhereSelect<Encounter, Encounter>(a_, b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private const long _cacheIndex_Stratification_3 = 1654598656286643211L;

    private IEnumerable<Encounter> Stratification_3_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);

        bool? b_(Encounter EncounterWithPharyngitis) {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 65);
            return n_;
        }

        Encounter c_(Encounter EncounterWithPharyngitis) => EncounterWithPharyngitis;
        IEnumerable<Encounter> d_ = context.Operators.WhereSelect<Encounter, Encounter>(a_, b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS146FHIRApproTestPharyngitis_1_0_000() {}

    public static CMS146FHIRApproTestPharyngitis_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS146FHIRApproTestPharyngitis";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Antibiotic_1_11_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU = new(
       [typeof(Encounter), typeof(Condition)],
       ["VisitWithAntibiotic", "AcutePharyngitisTonsillitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV = new(
       [typeof(Observation), typeof(Encounter)],
       ["GroupAStreptococcusTest", "EncounterWithPharyngitis"]);

    #endregion CqlTupleMetadata Properties

}
