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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.7.0")]
[CqlLibrary("AppropriateTestingforPharyngitisFHIR", "0.1.001")]
public partial class AppropriateTestingforPharyngitisFHIR_0_1_001 : ILibrary, ISingleton<AppropriateTestingforPharyngitisFHIR_0_1_001>
{
    private AppropriateTestingforPharyngitisFHIR_0_1_001() {}

    public static AppropriateTestingforPharyngitisFHIR_0_1_001 Instance { get; } = new();

    #region Library Members
    public string Name => "AppropriateTestingforPharyngitisFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Antibiotic_1_7_000.Instance, Status_1_8_000.Instance, QICoreCommon_2_1_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Acute Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011")]
    public CqlValueSet Acute_Pharyngitis(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", default);


    [CqlDeclaration("Acute Tonsillitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012")]
    public CqlValueSet Acute_Tonsillitis(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", default);


    [CqlDeclaration("Antibiotic Medications for Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001")]
    public CqlValueSet Antibiotic_Medications_for_Pharyngitis(CqlContext context) => 
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


    [CqlDeclaration("Group A Streptococcus Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012")]
    public CqlValueSet Group_A_Streptococcus_Test(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", default);


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
        object d_ = context.ResolveParameter("AppropriateTestingforPharyngitisFHIR-0.1.001", "Measurement Period", c_);

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
        bool? aa_(Encounter E)
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


    [CqlDeclaration("Encounter With Antibiotic Ordered Within Three Days")]
    public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> b_(Encounter EDOrAmbulatoryVisit)
        {
            CqlValueSet d_ = this.Antibiotic_Medications_for_Pharyngitis(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
            IEnumerable<MedicationRequest> i_ = Status_1_8_000.Instance.isMedicationOrder(context, h_);
            bool? j_(MedicationRequest AntibioticOrdered)
            {
                Period n_ = EDOrAmbulatoryVisit?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
                CqlDateTime q_ = context.Operators.Start(p_);
                FhirDateTime r_ = AntibioticOrdered?.AuthoredOnElement;
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                CqlQuantity t_ = context.Operators.Quantity(3m, "days");
                CqlDateTime u_ = context.Operators.Subtract(s_, t_);
                CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(r_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(q_, x_, "day");
                CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(r_);
                bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
                bool? ac_ = context.Operators.And(y_, ab_);

                return ac_;
            };
            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            Encounter l_(MedicationRequest AntibioticOrdered) => 
                EDOrAmbulatoryVisit;
            IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);

            return m_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Pharyngitis or Tonsillitis")]
    public IEnumerable<Condition> Pharyngitis_or_Tonsillitis(CqlContext context)
    {
        CqlValueSet a_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);

        return e_;
    }


    [CqlDeclaration("Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
    public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days(context);
        IEnumerable<Condition> b_ = this.Pharyngitis_or_Tonsillitis(context);
        IEnumerable<ValueTuple<Encounter, Condition>> c_ = context.Operators.CrossJoin<Encounter, Condition>(a_, b_);
        (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? d_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? j_ = (CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU, _valueTuple.Item1, _valueTuple.Item2);

            return j_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> e_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(c_, d_);
        bool? f_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh)
        {
            CqlInterval<CqlDateTime> k_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_ypyxedbbcqbdavhxvckuwmfh?.AcutePharyngitisTonsillitis);
            CqlDateTime l_ = context.Operators.Start(k_);
            Period m_ = tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_ as object);
            bool? p_ = context.Operators.In<CqlDateTime>(l_, o_, "day");

            return p_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh) => 
            tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?, Encounter>(g_, h_);

        return i_;
    }


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? b_(Encounter EncounterWithPharyngitis)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithPharyngitis) => 
            EncounterWithPharyngitis;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
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


    [CqlDeclaration("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        CqlValueSet c_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> e_ = Antibiotic_1_7_000.Instance.Has_Comorbid_Condition_History(context, b_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(a_, e_);
        CqlValueSet h_ = this.Antibiotic_Medications_for_Pharyngitis(context);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
        IEnumerable<MedicationRequest> m_ = Status_1_8_000.Instance.isMedicationActive(context, l_);
        IEnumerable<Encounter> n_ = Antibiotic_1_7_000.Instance.Has_Antibiotic_Medication_History(context, b_, m_);
        CqlValueSet p_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> r_ = Antibiotic_1_7_000.Instance.Has_Competing_Diagnosis_History(context, b_, q_);
        IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(n_, r_);
        IEnumerable<Encounter> t_ = context.Operators.Union<Encounter>(f_, s_);

        return t_;
    }


    [CqlDeclaration("Group A Streptococcus Lab Test With Result")]
    public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result(CqlContext context)
    {
        CqlValueSet a_ = this.Group_A_Streptococcus_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> c_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, b_);
        bool? d_(Observation GroupAStreptococcusTest)
        {
            DataType f_ = GroupAStreptococcusTest?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            bool? h_ = context.Operators.Not((bool?)(g_ is null));

            return h_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Group_A_Streptococcus_Lab_Test_With_Result(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);
        (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? d_(ValueTuple<Observation, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? j_ = (CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV, _valueTuple.Item1, _valueTuple.Item2);

            return j_;
        };
        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(c_, d_);
        bool? f_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij)
        {
            DataType k_ = tuple_ffguysnebcxllexfcmjoehbij?.GroupAStreptococcusTest?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.toInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            Period o_ = tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlQuantity r_ = context.Operators.Quantity(3m, "days");
            CqlDateTime s_ = context.Operators.Subtract(q_, r_);
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime v_ = context.Operators.End(u_);
            CqlDateTime x_ = context.Operators.Add(v_, r_);
            CqlInterval<CqlDateTime> y_ = context.Operators.Interval(s_, x_, true, true);
            bool? z_ = context.Operators.In<CqlDateTime>(n_, y_, "day");

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> g_ = context.Operators.Where<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) => 
            tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?, Encounter>(g_, h_);

        return i_;
    }


    [CqlDeclaration("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? b_(Encounter EncounterWithPharyngitis)
        {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            CqlInterval<int?> n_ = context.Operators.Interval(3, 17, true, true);
            bool? o_ = context.Operators.In<int?>(m_, n_, default);

            return o_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithPharyngitis) => 
            EncounterWithPharyngitis;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? b_(Encounter EncounterWithPharyngitis)
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
        Encounter d_(Encounter EncounterWithPharyngitis) => 
            EncounterWithPharyngitis;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? b_(Encounter EncounterWithPharyngitis)
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
        Encounter d_(Encounter EncounterWithPharyngitis) => 
            EncounterWithPharyngitis;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

        return e_;
    }

    private static CqlTupleMetadata CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU = new(
        [typeof(Encounter), typeof(Condition)],
        ["VisitWithAntibiotic", "AcutePharyngitisTonsillitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV = new(
        [typeof(Observation), typeof(Encounter)],
        ["GroupAStreptococcusTest", "EncounterWithPharyngitis"]);

}
