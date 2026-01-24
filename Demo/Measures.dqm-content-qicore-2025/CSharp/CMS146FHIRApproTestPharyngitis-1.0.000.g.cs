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
[CqlLibrary("CMS146FHIRApproTestPharyngitis", "1.0.000")]
public partial class CMS146FHIRApproTestPharyngitis_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS146FHIRApproTestPharyngitis_1_0_000>
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

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

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


    [CqlExpressionDefinition("Encounter With Antibiotic Ordered Within Three Days")]
    public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Antibiotic_Ordered_Within_Three_Days, Encounter_With_Antibiotic_Ordered_Within_Three_Days_Compute);

    private IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);

        IEnumerable<Encounter> b_(Encounter EDOrAmbulatoryVisit) {
            CqlValueSet d_ = this.Antibiotic_Medications_for_Pharyngitis(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? p_(Medication M) {
                    object t_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object u_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> v_ = context.Operators.Split((string)u_, "/");
                    string w_ = context.Operators.Last<string>(v_);
                    bool? x_ = context.Operators.Equal(t_, w_);
                    CodeableConcept y_ = M?.Code;
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                    CqlValueSet aa_ = this.Antibiotic_Medications_for_Pharyngitis(context);
                    bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                    bool? ac_ = context.Operators.And(x_, ab_);
                    return ac_;
                }

                IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
                MedicationRequest r_(Medication M) => MR;
                IEnumerable<MedicationRequest> s_ = context.Operators.Select<Medication, MedicationRequest>(q_, r_);
                return s_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);
            IEnumerable<MedicationRequest> j_ = Status_1_15_000.Instance.isMedicationOrder(context, i_);

            bool? k_(MedicationRequest AntibioticOrdered) {
                Period ad_ = EDOrAmbulatoryVisit?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_ as object);
                CqlDateTime ag_ = context.Operators.Start(af_);
                FhirDateTime ah_ = AntibioticOrdered?.AuthoredOnElement;
                CqlDateTime ai_ = context.Operators.Convert<CqlDateTime>(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(3m, "days");
                CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
                CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(ah_);
                CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDateTime>(ag_, an_, "day");
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ah_);
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                bool? as_ = context.Operators.And(ao_, ar_);
                return as_;
            }

            IEnumerable<MedicationRequest> l_ = context.Operators.Where<MedicationRequest>(j_, k_);
            Encounter m_(MedicationRequest AntibioticOrdered) => EDOrAmbulatoryVisit;
            IEnumerable<Encounter> n_ = context.Operators.Select<MedicationRequest, Encounter>(l_, m_);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Pharyngitis or Tonsillitis")]
    public IEnumerable<object> Pharyngitis_or_Tonsillitis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pharyngitis_or_Tonsillitis, Pharyngitis_or_Tonsillitis_Compute);

    private IEnumerable<object> Pharyngitis_or_Tonsillitis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        CqlValueSet c_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        object f_(Condition X) => X as object;
        IEnumerable<object> g_ = context.Operators.Select<Condition, object>(e_, f_);
        IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
    public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic, Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic_Compute);

    private IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days(context);
        IEnumerable<object> b_ = this.Pharyngitis_or_Tonsillitis(context);
        IEnumerable<ValueTuple<Encounter, object>> c_ = context.Operators.CrossJoin<Encounter, object>(a_, b_);

        (CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)? d_(ValueTuple<Encounter, object> _valueTuple) {
            (CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)? k_ = (CqlTupleMetadata_CgFHHRTZBEBaeiUhMVLiFJRQP, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)?> e_ = context.Operators.Select<ValueTuple<Encounter, object>, (CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)? tuple_dxfrqbqjrcafyrpcehuvuotch) {
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_dxfrqbqjrcafyrpcehuvuotch?.AcutePharyngitisTonsillitis);
            CqlDateTime m_ = context.Operators.Start(l_);
            Period n_ = tuple_dxfrqbqjrcafyrpcehuvuotch?.VisitWithAntibiotic?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
            return p_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)? tuple_dxfrqbqjrcafyrpcehuvuotch) => tuple_dxfrqbqjrcafyrpcehuvuotch?.VisitWithAntibiotic;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter VisitWithAntibiotic, object AcutePharyngitisTonsillitis)?, Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Distinct<Encounter>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);

        bool? b_(Encounter EncounterWithPharyngitis) {
            Patient g_ = this.Patient(context);
            Date h_ = g_?.BirthDateElement;
            string i_ = h_?.Value;
            CqlDate j_ = context.Operators.ConvertStringToDate(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            int? n_ = context.Operators.CalculateAgeAt(j_, m_, "year");
            bool? o_ = context.Operators.GreaterOrEqual(n_, 3);
            return o_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithPharyngitis) => EncounterWithPharyngitis;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_and_Assessments_with_Hospice_Patient, Encounters_and_Assessments_with_Hospice_Patient_Compute);

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

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        CqlValueSet c_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        object e_(Condition X) => X as object;
        IEnumerable<object> f_ = context.Operators.Select<Condition, object>(d_, e_);
        IEnumerable<object> g_ = Status_1_15_000.Instance.verified(context, f_);
        Condition h_(object X) => X as Condition;
        IEnumerable<Condition> i_ = context.Operators.Select<object, Condition>(g_, h_);
        IEnumerable<Encounter> j_ = Antibiotic_1_11_000.Instance.Encounter_with_Comorbid_Condition_History(context, b_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(a_, j_);
        CqlValueSet m_ = this.Antibiotic_Medications_for_Pharyngitis(context);
        IEnumerable<MedicationRequest> n_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> p_(MedicationRequest MR) {
            IEnumerable<Medication> af_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ag_(Medication M) {
                object ak_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object al_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> am_ = context.Operators.Split((string)al_, "/");
                string an_ = context.Operators.Last<string>(am_);
                bool? ao_ = context.Operators.Equal(ak_, an_);
                CodeableConcept ap_ = M?.Code;
                CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                CqlValueSet ar_ = this.Antibiotic_Medications_for_Pharyngitis(context);
                bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
                bool? at_ = context.Operators.And(ao_, as_);
                return at_;
            }

            IEnumerable<Medication> ah_ = context.Operators.Where<Medication>(af_, ag_);
            MedicationRequest ai_(Medication M) => MR;
            IEnumerable<MedicationRequest> aj_ = context.Operators.Select<Medication, MedicationRequest>(ah_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> q_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(o_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(n_, q_);
        IEnumerable<MedicationRequest> s_ = Status_1_15_000.Instance.isMedicationActive(context, r_);
        IEnumerable<Encounter> t_ = Antibiotic_1_11_000.Instance.Encounter_with_Antibiotic_Medication_History(context, b_, s_);
        CqlValueSet v_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> w_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> y_ = context.Operators.Select<Condition, object>(w_, e_);
        IEnumerable<object> z_ = Status_1_15_000.Instance.verified(context, y_);
        IEnumerable<Condition> ab_ = context.Operators.Select<object, Condition>(z_, h_);
        IEnumerable<Encounter> ac_ = Antibiotic_1_11_000.Instance.Encounter_with_Competing_Diagnosis_History(context, b_, ab_);
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(t_, ac_);
        IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(k_, ad_);
        return ae_;
    }


    [CqlExpressionDefinition("Group A Streptococcus Lab Test With Result")]
    public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Group_A_Streptococcus_Lab_Test_With_Result, Group_A_Streptococcus_Lab_Test_With_Result_Compute);

    private IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Group_A_Streptococcus_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);

        bool? d_(Observation GroupAStreptococcusTest) {
            DataType f_ = GroupAStreptococcusTest?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            bool? h_ = context.Operators.Not((bool?)(g_ is null));
            return h_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Group_A_Streptococcus_Lab_Test_With_Result(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);

        (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? d_(ValueTuple<Observation, Encounter> _valueTuple) {
            (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? k_ = (CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) {
            DataType l_ = tuple_ffguysnebcxllexfcmjoehbij?.GroupAStreptococcusTest?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            Period p_ = tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(3m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime w_ = context.Operators.End(v_);
            CqlDateTime y_ = context.Operators.Add(w_, s_);
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(t_, y_, true, true);
            bool? aa_ = context.Operators.In<CqlDateTime>(o_, z_, "day");
            return aa_;
        }

        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> g_ = context.Operators.Where<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) => tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?, Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Distinct<Encounter>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private IEnumerable<Encounter> Stratification_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);

        bool? b_(Encounter EncounterWithPharyngitis) {
            Patient g_ = this.Patient(context);
            Date h_ = g_?.BirthDateElement;
            string i_ = h_?.Value;
            CqlDate j_ = context.Operators.ConvertStringToDate(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            int? n_ = context.Operators.CalculateAgeAt(j_, m_, "year");
            CqlInterval<int?> o_ = context.Operators.Interval(3, 17, true, true);
            bool? p_ = context.Operators.In<int?>(n_, o_, default);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithPharyngitis) => EncounterWithPharyngitis;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private IEnumerable<Encounter> Stratification_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);

        bool? b_(Encounter EncounterWithPharyngitis) {
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
        Encounter d_(Encounter EncounterWithPharyngitis) => EncounterWithPharyngitis;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private IEnumerable<Encounter> Stratification_3_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);

        bool? b_(Encounter EncounterWithPharyngitis) {
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
        Encounter d_(Encounter EncounterWithPharyngitis) => EncounterWithPharyngitis;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (19)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Qualifying_Encounters = -1;
    private int _cacheIndex_Encounter_With_Antibiotic_Ordered_Within_Three_Days = -1;
    private int _cacheIndex_Pharyngitis_or_Tonsillitis = -1;
    private int _cacheIndex_Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Encounters_and_Assessments_with_Hospice_Patient = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_Group_A_Streptococcus_Lab_Test_With_Result = -1;
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
        _cacheIndex_Encounter_With_Antibiotic_Ordered_Within_Three_Days = index++;
        _cacheIndex_Pharyngitis_or_Tonsillitis = index++;
        _cacheIndex_Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Encounters_and_Assessments_with_Hospice_Patient = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_Group_A_Streptococcus_Lab_Test_With_Result = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_Stratification_1 = index++;
        _cacheIndex_Stratification_2 = index++;
        _cacheIndex_Stratification_3 = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS146FHIRApproTestPharyngitis_1_0_000() {}

    public static CMS146FHIRApproTestPharyngitis_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS146FHIRApproTestPharyngitis";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Antibiotic_1_11_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (2)

    private static CqlTupleMetadata CqlTupleMetadata_CgFHHRTZBEBaeiUhMVLiFJRQP = new(
       [typeof(Encounter), typeof(object)],
       ["VisitWithAntibiotic", "AcutePharyngitisTonsillitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV = new(
       [typeof(Observation), typeof(Encounter)],
       ["GroupAStreptococcusTest", "EncounterWithPharyngitis"]);

    #endregion CqlTupleMetadata Properties

}
