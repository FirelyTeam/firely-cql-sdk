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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR", "0.1.001")]
public partial class AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_001 : ILibrary, ISingleton<AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_001>
{
    private AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_001() {}

    public static AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_001 Instance { get; } = new();

    #region Library Members
    public string Name => "AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance, QICoreCommon_2_1_000.Instance, Antibiotic_1_7_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Acute Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011")]
    public CqlValueSet Acute_Pharyngitis(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", default);


    [CqlDeclaration("Acute Tonsillitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012")]
    public CqlValueSet Acute_Tonsillitis(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", default);


    [CqlDeclaration("Antibiotic Medications for Upper Respiratory Infection")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001")]
    public CqlValueSet Antibiotic_Medications_for_Upper_Respiratory_Infection(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", default);


    [CqlDeclaration("Comorbid Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025")]
    public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", default);


    [CqlDeclaration("Competing Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017")]
    public CqlValueSet Competing_Conditions_for_Respiratory_Conditions(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", default);


    [CqlDeclaration("Emergency Department Evaluation and Management Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Medical Disability Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073")]
    public CqlValueSet Medical_Disability_Exam(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);


    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);


    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Upper Respiratory Infection")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022")]
    public CqlValueSet Upper_Respiratory_Infection(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", default);


    [CqlDeclaration("Virtual Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Virtual_Encounter(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Unlisted preventive medicine service")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext context) => 
        new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR-0.1.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlDeclaration("Qualifying Encounters")]
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
                CqlConcept az_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
        IEnumerable<Encounter> aq_ = Status_1_8_000.Instance.isEncounterPerformed(context, ap_);
        bool? ar_(Encounter ValidEncounter)
        {
            Period bd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
            CqlInterval<CqlDateTime> bf_ = QICoreCommon_2_1_000.Instance.toInterval(context, be_ as object);
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


    [CqlDeclaration("Encounter with Upper Respiratory Infection")]
    public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        CqlValueSet b_ = this.Upper_Respiratory_Infection(context);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? e_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? k_ = (CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce, _valueTuple.Item1, _valueTuple.Item2);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> f_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce)
        {
            CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_figmirinmncaavfkbmahdktce?.URI);
            CqlDateTime m_ = context.Operators.Start(l_);
            Period n_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            bool? q_ = context.Operators.In<CqlDateTime>(m_, p_, "day");
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> u_ = QICoreCommon_2_1_000.Instance.toInterval(context, t_ as object);
            bool? v_ = context.Operators.OverlapsBefore(l_, u_, default);
            bool? w_ = context.Operators.Or(q_, v_);

            return w_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) => 
            tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?, Encounter>(h_, i_);

        return j_;
    }


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? b_(Encounter EncounterWithURI)
        {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "month");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 3);

            return n_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => 
            EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        bool? b_(Encounter EligibleEncounters)
        {
            bool? d_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

            return d_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        CqlValueSet c_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> e_ = Antibiotic_1_7_000.Instance.Has_Comorbid_Condition_History(context, b_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(a_, e_);
        CqlValueSet h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
        IEnumerable<Encounter> m_ = Antibiotic_1_7_000.Instance.Has_Antibiotic_Medication_History(context, b_, l_);
        CqlValueSet o_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet q_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> s_ = context.Operators.Union<Condition>(p_, r_);
        CqlValueSet t_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> u_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> v_ = context.Operators.Union<Condition>(s_, u_);
        IEnumerable<Encounter> w_ = Antibiotic_1_7_000.Instance.Has_Competing_Diagnosis_History(context, b_, v_);
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(m_, w_);
        IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(f_, x_);

        return y_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        IEnumerable<Encounter> c_(Encounter EncounterWithURI)
        {
            CqlValueSet h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
            IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
            IEnumerable<MedicationRequest> m_ = Status_1_8_000.Instance.isMedicationOrder(context, l_);
            bool? n_(MedicationRequest OrderedAntibiotic)
            {
                FhirDateTime r_ = OrderedAntibiotic?.AuthoredOnElement;
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                Period t_ = EncounterWithURI?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_2_1_000.Instance.toInterval(context, u_ as object);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlQuantity ab_ = context.Operators.Quantity(3m, "days");
                CqlDateTime ac_ = context.Operators.Add(aa_, ab_);
                CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(w_, ac_, true, true);
                bool? ae_ = context.Operators.In<CqlDateTime>(s_, ad_, default);
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_1_000.Instance.toInterval(context, ag_ as object);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ae_, aj_);

                return ak_;
            };
            IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);
            Encounter p_(MedicationRequest OrderedAntibiotic) => 
                EncounterWithURI;
            IEnumerable<Encounter> q_ = context.Operators.Select<MedicationRequest, Encounter>(o_, p_);

            return q_;
        };
        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(a_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(a_, d_);
        Encounter f_(Encounter EncounterWithURI) => 
            EncounterWithURI;
        IEnumerable<Encounter> g_ = context.Operators.Select<Encounter, Encounter>(e_, f_);

        return g_;
    }


    [CqlDeclaration("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? b_(Encounter EncounterWithURI)
        {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "month");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 3);
            Date p_ = f_?.BirthDateElement;
            string q_ = p_?.Value;
            CqlDate r_ = context.Operators.ConvertStringToDate(q_);
            CqlDateTime t_ = context.Operators.Start(j_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            int? v_ = context.Operators.CalculateAgeAt(r_, u_, "year");
            bool? w_ = context.Operators.LessOrEqual(v_, 17);
            bool? x_ = context.Operators.And(n_, w_);

            return x_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => 
            EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? b_(Encounter EncounterWithURI)
        {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            CqlInterval<int?> n_ = context.Operators.Interval(18, 64, true, true);
            bool? o_ = context.Operators.In<int?>(m_, n_, default);

            return o_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => 
            EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? b_(Encounter EncounterWithURI)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithURI) => 
            EncounterWithURI;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

        return e_;
    }

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounters", "URI"]);

}
