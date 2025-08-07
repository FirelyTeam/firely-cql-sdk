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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR", "0.1.001")]
public partial class AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_minus_0_1_001 : ILibrary, ISingleton<AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_minus_0_1_001>
{
    private AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_minus_0_1_001() {}

    public static AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_minus_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_minus_4_4_000.Instance, SupplementalDataElements_minus_3_5_000.Instance, Hospice_minus_6_12_000.Instance, Status_minus_1_8_000.Instance, QICoreCommon_minus_2_1_000.Instance, Antibiotic_minus_1_7_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

    [CqlCodeDefinition("Unlisted preventive medicine service", codeId: "99429", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext _) => _Unlisted_preventive_medicine_service;
    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Unlisted_preventive_medicine_service]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR-0.1.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
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
        bool? am_(Encounter E)
        {
            List<CodeableConcept> at_ = E?.Type;
            CqlConcept au_(CodeableConcept @this)
            {
                CqlConcept az_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, @this);

                return az_;
            };
            IEnumerable<CqlConcept> av_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)at_, au_);
            bool? aw_(CqlConcept T)
            {
                CqlCode ba_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                bool? bc_ = context.Operators.Equivalent(T, bb_);

                return bc_;
            };
            IEnumerable<CqlConcept> ax_ = context.Operators.Where<CqlConcept>(av_, aw_);
            bool? ay_ = context.Operators.Exists<CqlConcept>(ax_);

            return ay_;
        };
        IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);
        IEnumerable<Encounter> ao_ = context.Operators.Union<Encounter>(ak_, an_);
        IEnumerable<Encounter> ap_ = context.Operators.Union<Encounter>(ai_, ao_);
        IEnumerable<Encounter> aq_ = Status_minus_1_8_000.Instance.isEncounterPerformed(context, ap_);
        bool? ar_(Encounter ValidEncounter)
        {
            Period bd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> be_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, bd_);
            CqlInterval<CqlDateTime> bf_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, be_ as object);
            CqlDateTime bg_ = context.Operators.End(bf_);
            CqlInterval<CqlDateTime> bh_ = this.Measurement_Period(context);
            CqlDateTime bi_ = context.Operators.Start(bh_);
            CqlDateTime bk_ = context.Operators.End(bh_);
            CqlQuantity bl_ = context.Operators.Quantity(3m, "days");
            CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
            CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bi_, bm_, true, true);
            bool? bo_ = context.Operators.In<CqlDateTime>(bg_, bn_, "day");

            return bo_;
        };
        IEnumerable<Encounter> as_ = context.Operators.Where<Encounter>(aq_, ar_);

        return as_;
    }


    [CqlExpressionDefinition("Encounter with Upper Respiratory Infection")]
    public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        CqlValueSet b_ = this.Upper_Respiratory_Infection(context);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? e_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? l_ = (CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> f_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce)
        {
            CqlInterval<CqlDateTime> m_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, tuple_figmirinmncaavfkbmahdktce?.URI);
            CqlDateTime n_ = context.Operators.Start(m_);
            Period o_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, o_);
            CqlInterval<CqlDateTime> q_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, p_ as object);
            bool? r_ = context.Operators.In<CqlDateTime>(n_, q_, "day");
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, o_);
            CqlInterval<CqlDateTime> v_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, u_ as object);
            bool? w_ = context.Operators.OverlapsBefore(m_, v_, default);
            bool? x_ = context.Operators.Or(r_, w_);

            return x_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) =>
            tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? b_(Encounter EncounterWithURI)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        bool? b_(Encounter EligibleEncounters)
        {
            bool? d_ = Hospice_minus_6_12_000.Instance.Has_Hospice_Services(context);

            return d_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        CqlValueSet c_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> e_ = Antibiotic_minus_1_7_000.Instance.Has_Comorbid_Condition_History(context, b_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(a_, e_);
        CqlValueSet h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_(MedicationRequest MR)
        {
            IEnumerable<Medication> aa_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ab_(Medication M)
            {
                object af_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ag_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ah_ = context.Operators.Split((string)ag_, "/");
                string ai_ = context.Operators.Last<string>(ah_);
                bool? aj_ = context.Operators.Equal(af_, ai_);
                CodeableConcept ak_ = M?.Code;
                CqlConcept al_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, ak_);
                CqlValueSet am_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
                bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
                bool? ao_ = context.Operators.And(aj_, an_);

                return ao_;
            };
            IEnumerable<Medication> ac_ = context.Operators.Where<Medication>(aa_, ab_);
            MedicationRequest ad_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ae_ = context.Operators.Select<Medication, MedicationRequest>(ac_, ad_);

            return ae_;
        };
        IEnumerable<MedicationRequest> l_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(j_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(i_, l_);
        IEnumerable<Encounter> n_ = Antibiotic_minus_1_7_000.Instance.Has_Antibiotic_Medication_History(context, b_, m_);
        CqlValueSet p_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet r_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> t_ = context.Operators.Union<Condition>(q_, s_);
        CqlValueSet u_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> w_ = context.Operators.Union<Condition>(t_, v_);
        IEnumerable<Encounter> x_ = Antibiotic_minus_1_7_000.Instance.Has_Competing_Diagnosis_History(context, b_, w_);
        IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(n_, x_);
        IEnumerable<Encounter> z_ = context.Operators.Union<Encounter>(f_, y_);

        return z_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        IEnumerable<Encounter> c_(Encounter EncounterWithURI)
        {
            CqlValueSet i_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
            IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> l_(MedicationRequest MR)
            {
                IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? u_(Medication M)
                {
                    object y_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object z_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> aa_ = context.Operators.Split((string)z_, "/");
                    string ab_ = context.Operators.Last<string>(aa_);
                    bool? ac_ = context.Operators.Equal(y_, ab_);
                    CodeableConcept ad_ = M?.Code;
                    CqlConcept ae_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, ad_);
                    CqlValueSet af_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
                    bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                    bool? ah_ = context.Operators.And(ac_, ag_);

                    return ah_;
                };
                IEnumerable<Medication> v_ = context.Operators.Where<Medication>(t_, u_);
                MedicationRequest w_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> x_ = context.Operators.Select<Medication, MedicationRequest>(v_, w_);

                return x_;
            };
            IEnumerable<MedicationRequest> m_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(k_, l_);
            IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(j_, m_);
            IEnumerable<MedicationRequest> o_ = Status_minus_1_8_000.Instance.isMedicationOrder(context, n_);
            bool? p_(MedicationRequest OrderedAntibiotic)
            {
                FhirDateTime ai_ = OrderedAntibiotic?.AuthoredOnElement;
                CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
                Period ak_ = EncounterWithURI?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, al_ as object);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, ak_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ap_ as object);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlQuantity as_ = context.Operators.Quantity(3m, "days");
                CqlDateTime at_ = context.Operators.Add(ar_, as_);
                CqlInterval<CqlDateTime> au_ = context.Operators.Interval(an_, at_, true, true);
                bool? av_ = context.Operators.In<CqlDateTime>(aj_, au_, default);
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, ak_);
                CqlInterval<CqlDateTime> ay_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ax_ as object);
                CqlDateTime az_ = context.Operators.Start(ay_);
                bool? ba_ = context.Operators.Not((bool?)(az_ is null));
                bool? bb_ = context.Operators.And(av_, ba_);

                return bb_;
            };
            IEnumerable<MedicationRequest> q_ = context.Operators.Where<MedicationRequest>(o_, p_);
            Encounter r_(MedicationRequest OrderedAntibiotic) =>
                EncounterWithURI;
            IEnumerable<Encounter> s_ = context.Operators.Select<MedicationRequest, Encounter>(q_, r_);

            return s_;
        };
        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(a_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(a_, d_);
        Encounter f_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> g_ = context.Operators.Select<Encounter, Encounter>(e_, f_);
        IEnumerable<Encounter> h_ = context.Operators.Distinct<Encounter>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? b_(Encounter EncounterWithURI)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? b_(Encounter EncounterWithURI)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? b_(Encounter EncounterWithURI)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
      [typeof(Encounter), typeof(Condition)],
      ["QualifyingEncounters", "URI"]);

    #endregion CqlTupleMetadata Properties

}
