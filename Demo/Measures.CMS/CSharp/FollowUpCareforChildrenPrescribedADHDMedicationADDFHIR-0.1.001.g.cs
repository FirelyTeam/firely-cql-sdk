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
[CqlLibrary("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR", "0.1.001")]
public partial class FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001 : ILibrary, ISingleton<FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001>
{
    private FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001() {}

    public static FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001 Instance { get; } = new();

    #region Library Members
    public string Name => "FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Status_1_8_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003")]
    public CqlValueSet Ambulatory(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", default);


    [CqlDeclaration("Atomoxetine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170")]
    public CqlValueSet Atomoxetine(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", default);


    [CqlDeclaration("Behavioral Health Follow up Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054")]
    public CqlValueSet Behavioral_Health_Follow_up_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", default);


    [CqlDeclaration("Clonidine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171")]
    public CqlValueSet Clonidine(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", default);


    [CqlDeclaration("Dexmethylphenidate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172")]
    public CqlValueSet Dexmethylphenidate(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", default);


    [CqlDeclaration("Dextroamphetamine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173")]
    public CqlValueSet Dextroamphetamine(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Guanfacine Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252")]
    public CqlValueSet Guanfacine_Medications(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Lisdexamfetamine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174")]
    public CqlValueSet Lisdexamfetamine(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", default);


    [CqlDeclaration("Mental Behavioral and Neurodevelopmental Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203")]
    public CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", default);


    [CqlDeclaration("Methylphenidate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176")]
    public CqlValueSet Methylphenidate(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", default);


    [CqlDeclaration("Narcolepsy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011")]
    public CqlValueSet Narcolepsy(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);


    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);


    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);


    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);


    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", default);


    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", default);


    [CqlDeclaration("Psychotherapy and Pharmacologic Management")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055")]
    public CqlValueSet Psychotherapy_and_Pharmacologic_Management(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Virtual Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Virtual_Encounter(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("24 HR dexmethylphenidate hydrochloride 40 MG Extended Release Oral Capsule")]
    public CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule(CqlContext context) => 
        new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("methamphetamine hydrochloride 5 MG Oral Tablet")]
    public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet(CqlContext context) => 
        new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("RXNORM")]
    public CqlCode[] RXNORM(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR-0.1.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("March 1 of Year Prior to Measurement Period")]
    public CqlDateTime March_1_of_Year_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime f_ = context.Operators.DateTime(d_, 3, 1, 0, 0, 0, 0, e_);

        return f_;
    }


    [CqlDeclaration("Last Calendar Day of February of Measurement Period")]
    public CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime e_ = context.Operators.DateTime(c_, 3, 1, 23, 59, 59, 0, d_);
        CqlQuantity f_ = context.Operators.Quantity(1m, "day");
        CqlDateTime g_ = context.Operators.Subtract(e_, f_);

        return g_;
    }


    [CqlDeclaration("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime a_ = this.March_1_of_Year_Prior_to_Measurement_Period(context);
        CqlDateTime b_ = this.Last_Calendar_Day_of_February_of_Measurement_Period(context);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);

        return c_;
    }


    [CqlDeclaration("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
    public IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(CqlContext context)
    {
        CqlValueSet a_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        CqlValueSet f_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
        CqlValueSet l_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
        CqlValueSet r_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> s_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> u_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> v_ = context.Operators.Union<MedicationRequest>(s_, u_);
        IEnumerable<MedicationRequest> w_ = context.Operators.Union<MedicationRequest>(q_, v_);
        CqlValueSet x_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);
        IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(w_, ab_);
        CqlCode ad_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> ae_ = context.Operators.ToList<CqlCode>(ad_);
        IEnumerable<MedicationRequest> af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ad_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(af_, ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ac_, aj_);
        CqlValueSet al_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> am_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Union<MedicationRequest>(ak_, ap_);
        CqlValueSet ar_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(aq_, av_);
        IEnumerable<MedicationRequest> ax_ = Status_1_8_000.Instance.isMedicationOrder(context, aw_);
        bool? ay_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> dh_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate di_ = context.Operators.Start(dh_);
            CqlDateTime dj_ = context.Operators.ConvertDateToDateTime(di_);
            CqlInterval<CqlDateTime> dk_ = this.Intake_Period(context);
            bool? dl_ = context.Operators.In<CqlDateTime>(dj_, dk_, default);

            return dl_;
        };
        IEnumerable<MedicationRequest> az_ = context.Operators.Where<MedicationRequest>(ax_, ay_);
        IEnumerable<MedicationRequest> bb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> be_ = context.Operators.Union<MedicationRequest>(bb_, bd_);
        IEnumerable<MedicationRequest> bg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bg_, bi_);
        IEnumerable<MedicationRequest> bk_ = context.Operators.Union<MedicationRequest>(be_, bj_);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bm_, bo_);
        IEnumerable<MedicationRequest> bq_ = context.Operators.Union<MedicationRequest>(bk_, bp_);
        IEnumerable<MedicationRequest> bs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bv_ = context.Operators.Union<MedicationRequest>(bs_, bu_);
        IEnumerable<MedicationRequest> bw_ = context.Operators.Union<MedicationRequest>(bq_, bv_);
        IEnumerable<MedicationRequest> by_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ca_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cb_ = context.Operators.Union<MedicationRequest>(by_, ca_);
        IEnumerable<MedicationRequest> cc_ = context.Operators.Union<MedicationRequest>(bw_, cb_);
        IEnumerable<CqlCode> ce_ = context.Operators.ToList<CqlCode>(ad_);
        IEnumerable<MedicationRequest> cf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ce_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> ch_ = context.Operators.ToList<CqlCode>(ad_);
        IEnumerable<MedicationRequest> ci_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ch_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cj_ = context.Operators.Union<MedicationRequest>(cf_, ci_);
        IEnumerable<MedicationRequest> ck_ = context.Operators.Union<MedicationRequest>(cc_, cj_);
        IEnumerable<MedicationRequest> cm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> co_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cp_ = context.Operators.Union<MedicationRequest>(cm_, co_);
        IEnumerable<MedicationRequest> cq_ = context.Operators.Union<MedicationRequest>(ck_, cp_);
        IEnumerable<MedicationRequest> cs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cv_ = context.Operators.Union<MedicationRequest>(cs_, cu_);
        IEnumerable<MedicationRequest> cw_ = context.Operators.Union<MedicationRequest>(cq_, cv_);
        IEnumerable<MedicationRequest> cx_ = Status_1_8_000.Instance.isMedicationOrder(context, cw_);
        bool? cy_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> dm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate dn_ = context.Operators.Start(dm_);
            CqlDateTime do_ = context.Operators.ConvertDateToDateTime(dn_);
            CqlInterval<CqlDateTime> dp_ = this.Intake_Period(context);
            bool? dq_ = context.Operators.In<CqlDateTime>(do_, dp_, default);

            return dq_;
        };
        IEnumerable<MedicationRequest> cz_ = context.Operators.Where<MedicationRequest>(cx_, cy_);
        IEnumerable<MedicationRequest> da_(MedicationRequest ADHDMedicationOrder)
        {
            CqlValueSet dr_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> ds_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> du_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> dv_ = context.Operators.Union<MedicationRequest>(ds_, du_);
            CqlValueSet dw_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> dx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> dz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ea_ = context.Operators.Union<MedicationRequest>(dx_, dz_);
            IEnumerable<MedicationRequest> eb_ = context.Operators.Union<MedicationRequest>(dv_, ea_);
            CqlValueSet ec_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> ed_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ec_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ef_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ec_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> eg_ = context.Operators.Union<MedicationRequest>(ed_, ef_);
            IEnumerable<MedicationRequest> eh_ = context.Operators.Union<MedicationRequest>(eb_, eg_);
            CqlValueSet ei_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> ej_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ei_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> el_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ei_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> em_ = context.Operators.Union<MedicationRequest>(ej_, el_);
            IEnumerable<MedicationRequest> en_ = context.Operators.Union<MedicationRequest>(eh_, em_);
            CqlValueSet eo_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> ep_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, eo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> er_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, eo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> es_ = context.Operators.Union<MedicationRequest>(ep_, er_);
            IEnumerable<MedicationRequest> et_ = context.Operators.Union<MedicationRequest>(en_, es_);
            CqlCode eu_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> ev_ = context.Operators.ToList<CqlCode>(eu_);
            IEnumerable<MedicationRequest> ew_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ev_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<CqlCode> ey_ = context.Operators.ToList<CqlCode>(eu_);
            IEnumerable<MedicationRequest> ez_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ey_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> fa_ = context.Operators.Union<MedicationRequest>(ew_, ez_);
            IEnumerable<MedicationRequest> fb_ = context.Operators.Union<MedicationRequest>(et_, fa_);
            CqlValueSet fc_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> fd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ff_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> fg_ = context.Operators.Union<MedicationRequest>(fd_, ff_);
            IEnumerable<MedicationRequest> fh_ = context.Operators.Union<MedicationRequest>(fb_, fg_);
            CqlValueSet fi_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> fj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> fl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> fm_ = context.Operators.Union<MedicationRequest>(fj_, fl_);
            IEnumerable<MedicationRequest> fn_ = context.Operators.Union<MedicationRequest>(fh_, fm_);
            IEnumerable<MedicationRequest> fo_ = Status_1_8_000.Instance.isMedicationActive(context, fn_);
            bool? fp_(MedicationRequest ActiveADHDMedication)
            {
                CqlInterval<CqlDate> ft_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> fu_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate fv_ = context.Operators.Start(fu_);
                CqlDateTime fw_ = context.Operators.ConvertDateToDateTime(fv_);
                CqlDate fx_ = context.Operators.DateFrom(fw_);
                CqlQuantity fy_ = context.Operators.Quantity(120m, "days");
                CqlDate fz_ = context.Operators.Subtract(fx_, fy_);
                CqlDate gb_ = context.Operators.Start(fu_);
                CqlDateTime gc_ = context.Operators.ConvertDateToDateTime(gb_);
                CqlDate gd_ = context.Operators.DateFrom(gc_);
                CqlInterval<CqlDate> ge_ = context.Operators.Interval(fz_, gd_, true, false);
                bool? gf_ = context.Operators.Overlaps(ft_, ge_, default);

                return gf_;
            };
            IEnumerable<MedicationRequest> fq_ = context.Operators.Where<MedicationRequest>(fo_, fp_);
            MedicationRequest fr_(MedicationRequest ActiveADHDMedication) => 
                ADHDMedicationOrder;
            IEnumerable<MedicationRequest> fs_ = context.Operators.Select<MedicationRequest, MedicationRequest>(fq_, fr_);

            return fs_;
        };
        IEnumerable<MedicationRequest> db_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(cz_, da_);
        IEnumerable<MedicationRequest> dc_ = context.Operators.Except<MedicationRequest>(az_, db_);
        (CqlTupleMetadata, CqlDate startDate)? dd_(MedicationRequest QualifyingMed)
        {
            CqlInterval<CqlDate> gg_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate gh_ = context.Operators.Start(gg_);
            (CqlTupleMetadata, CqlDate startDate)? gi_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, gh_);

            return gi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> de_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(dc_, dd_);
        object df_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate gj_ = @this?.startDate;

            return gj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> dg_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(de_, df_, System.ComponentModel.ListSortDirection.Ascending);

        return dg_;
    }


    [CqlDeclaration("First ADHD Medication Prescribed During Intake Period")]
    public CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> a_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(context);
        bool? b_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate g_ = @this?.startDate;
            bool? h_ = context.Operators.Not((bool?)(g_ is null));

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> c_ = context.Operators.Where<(CqlTupleMetadata, CqlDate startDate)?>(a_, b_);
        CqlDate d_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate i_ = @this?.startDate;

            return i_;
        };
        IEnumerable<CqlDate> e_ = context.Operators.Select<(CqlTupleMetadata, CqlDate startDate)?, CqlDate>(c_, d_);
        CqlDate f_ = context.Operators.First<CqlDate>(e_);

        return f_;
    }


    [CqlDeclaration("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate a_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);

        return a_;
    }


    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        IEnumerable<Encounter> l_ = Status_1_8_000.Instance.isEncounterPerformed(context, k_);
        bool? m_(Encounter ValidEncounters)
        {
            CqlDate o_ = this.IPSD(context);
            CqlQuantity p_ = context.Operators.Quantity(6m, "months");
            CqlDate q_ = context.Operators.Subtract(o_, p_);
            CqlInterval<CqlDate> s_ = context.Operators.Interval(q_, o_, true, true);
            Period t_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlInterval<CqlDateTime> v_ = QICoreCommon_2_1_000.Instance.toInterval(context, u_ as object);
            CqlInterval<CqlDate> w_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, v_);
            bool? x_ = context.Operators.IntervalIncludesInterval<CqlDate>(s_, w_, "day");

            return x_;
        };
        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);

        return n_;
    }


    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_8_000.Instance.isEncounterPerformed(context, b_);
        bool? d_(Encounter InpatientStay)
        {
            Condition f_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, InpatientStay);
            CodeableConcept g_ = f_?.Code;
            CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
            CqlValueSet i_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders(context);
            bool? j_ = context.Operators.ConceptInValueSet(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? b_(Encounter InpatientStay)
        {
            Period d_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.toInterval(context, e_ as object);
            CqlInterval<CqlDate> g_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, f_);
            CqlDate h_ = context.Operators.Start(g_);
            CqlDate i_ = this.IPSD(context);
            CqlQuantity k_ = context.Operators.Quantity(30m, "days");
            CqlDate l_ = context.Operators.Add(i_, k_);
            CqlInterval<CqlDate> m_ = context.Operators.Interval(i_, l_, false, true);
            bool? n_ = context.Operators.In<CqlDate>(h_, m_, "day");
            bool? p_ = context.Operators.Not((bool?)(i_ is null));
            bool? q_ = context.Operators.And(n_, p_);

            return q_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Intake_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 6);
        Date k_ = a_?.BirthDateElement;
        string l_ = k_?.Value;
        CqlDate m_ = context.Operators.ConvertStringToDate(l_);
        CqlDateTime o_ = context.Operators.End(e_);
        CqlDate p_ = context.Operators.DateFrom(o_);
        int? q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
        bool? r_ = context.Operators.LessOrEqual(q_, 12);
        bool? s_ = context.Operators.And(i_, r_);
        IEnumerable<Encounter> t_ = this.Qualifying_Encounter(context);
        bool? u_ = context.Operators.Exists<Encounter>(t_);
        bool? v_ = context.Operators.And(s_, u_);
        CqlDate w_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? x_ = context.Operators.Not((bool?)(w_ is null));
        bool? y_ = context.Operators.And(v_, x_);
        IEnumerable<Encounter> z_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(context);
        bool? aa_ = context.Operators.Exists<Encounter>(z_);
        bool? ab_ = context.Operators.Not(aa_);
        bool? ac_ = context.Operators.And(y_, ab_);

        return ac_;
    }


    [CqlDeclaration("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? a_ = this.Initial_Population_1(context);

        return a_;
    }


    [CqlDeclaration("Narcolepsy Exclusion")]
    public IEnumerable<Condition> Narcolepsy_Exclusion(CqlContext context)
    {
        CqlValueSet a_ = this.Narcolepsy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition Narcolepsy)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Narcolepsy);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, default);

            return i_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> b_ = this.Narcolepsy_Exclusion(context);
        bool? c_ = context.Operators.Exists<Condition>(b_);
        bool? d_ = context.Operators.Or(a_, c_);

        return d_;
    }


    [CqlDeclaration("Qualifying Numerator Encounter")]
    public IEnumerable<Encounter> Qualifying_Numerator_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Behavioral_Health_Follow_up_Visit(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Psychotherapy_and_Pharmacologic_Management(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? n_(Encounter PsychPharmManagement)
        {
            List<Encounter.LocationComponent> al_ = PsychPharmManagement?.Location;
            bool? am_(Encounter.LocationComponent Location)
            {
                ResourceReference ap_ = Location?.Location;
                Location aq_ = CQMCommon_2_2_000.Instance.GetLocation(context, ap_);
                List<CodeableConcept> ar_ = aq_?.Type;
                CqlConcept as_(CodeableConcept @this)
                {
                    CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return aw_;
                };
                IEnumerable<CqlConcept> at_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ar_, as_);
                CqlValueSet au_ = this.Ambulatory(context);
                bool? av_ = context.Operators.ConceptsInValueSet(at_, au_);

                return av_;
            };
            IEnumerable<Encounter.LocationComponent> an_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)al_, am_);
            bool? ao_ = context.Operators.Exists<Encounter.LocationComponent>(an_);

            return ao_;
        };
        IEnumerable<Encounter> o_ = context.Operators.Where<Encounter>(m_, n_);
        CqlValueSet p_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(o_, q_);
        IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(k_, r_);
        CqlValueSet t_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet v_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> w_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(u_, w_);
        IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(s_, x_);
        CqlValueSet z_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ab_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(aa_, ac_);
        IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(y_, ad_);
        CqlValueSet af_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ah_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ai_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ag_, ai_);
        IEnumerable<Encounter> ak_ = context.Operators.Union<Encounter>(ae_, aj_);

        return ak_;
    }


    [CqlDeclaration("Encounter During Initiation Phase")]
    public IEnumerable<Encounter> Encounter_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> b_ = Status_1_8_000.Instance.isEncounterPerformed(context, a_);
        bool? c_(Encounter ValidNumeratorEncounter)
        {
            Period e_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_2_1_000.Instance.toInterval(context, f_ as object);
            CqlInterval<CqlDate> h_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, g_);
            CqlDate i_ = context.Operators.Start(h_);
            CqlDate j_ = this.IPSD(context);
            CqlQuantity l_ = context.Operators.Quantity(30m, "days");
            CqlDate m_ = context.Operators.Add(j_, l_);
            CqlInterval<CqlDate> n_ = context.Operators.Interval(j_, m_, false, true);
            bool? o_ = context.Operators.In<CqlDate>(i_, n_, "day");
            bool? q_ = context.Operators.Not((bool?)(j_ is null));
            bool? r_ = context.Operators.And(o_, q_);

            return r_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_During_Initiation_Phase(context);
        bool? b_ = context.Operators.Exists<Encounter>(a_);

        return b_;
    }


    [CqlDeclaration("ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
    public IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet a_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = Status_1_8_000.Instance.isMedicationOrder(context, e_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? g_(MedicationRequest AtomoxetineMed)
        {
            CqlInterval<CqlDate> eb_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate ed_ = context.Operators.Start(eb_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ee_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, eb_, ed_);

            return ee_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> h_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(f_, g_);
        object i_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate ef_ = @this?.periodStart;

            return ef_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> j_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
        bool? k_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> eg_ = @this?.period;
            bool? eh_ = context.Operators.Not((bool?)(eg_ is null));

            return eh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> l_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(j_, k_);
        CqlInterval<CqlDate> m_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ei_ = @this?.period;

            return ei_;
        };
        IEnumerable<CqlInterval<CqlDate>> n_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(l_, m_);
        IEnumerable<CqlInterval<CqlDate>> o_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, n_);
        CqlValueSet p_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> s_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(q_, s_);
        IEnumerable<MedicationRequest> u_ = Status_1_8_000.Instance.isMedicationOrder(context, t_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? v_(MedicationRequest ClonidineMed)
        {
            CqlInterval<CqlDate> ej_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate el_ = context.Operators.Start(ej_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? em_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ej_, el_);

            return em_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> w_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(u_, v_);
        object x_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate en_ = @this?.periodStart;

            return en_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> y_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
        bool? z_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> eo_ = @this?.period;
            bool? ep_ = context.Operators.Not((bool?)(eo_ is null));

            return ep_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> aa_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(y_, z_);
        CqlInterval<CqlDate> ab_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> eq_ = @this?.period;

            return eq_;
        };
        IEnumerable<CqlInterval<CqlDate>> ac_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(aa_, ab_);
        IEnumerable<CqlInterval<CqlDate>> ad_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, ac_);
        IEnumerable<CqlInterval<CqlDate>> ae_ = context.Operators.Union<CqlInterval<CqlDate>>(o_, ad_);
        CqlValueSet af_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(ag_, ai_);
        IEnumerable<MedicationRequest> ak_ = Status_1_8_000.Instance.isMedicationOrder(context, aj_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? al_(MedicationRequest DexmethylphenidateMed)
        {
            CqlInterval<CqlDate> er_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate et_ = context.Operators.Start(er_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? eu_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, er_, et_);

            return eu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> am_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ak_, al_);
        object an_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate ev_ = @this?.periodStart;

            return ev_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ao_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ap_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ew_ = @this?.period;
            bool? ex_ = context.Operators.Not((bool?)(ew_ is null));

            return ex_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> aq_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ao_, ap_);
        CqlInterval<CqlDate> ar_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ey_ = @this?.period;

            return ey_;
        };
        IEnumerable<CqlInterval<CqlDate>> as_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(aq_, ar_);
        IEnumerable<CqlInterval<CqlDate>> at_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, as_);
        CqlValueSet au_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> av_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, au_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ax_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, au_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ay_ = context.Operators.Union<MedicationRequest>(av_, ax_);
        IEnumerable<MedicationRequest> az_ = Status_1_8_000.Instance.isMedicationOrder(context, ay_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ba_(MedicationRequest DextroamphetamineMed)
        {
            CqlInterval<CqlDate> ez_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate fb_ = context.Operators.Start(ez_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fc_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ez_, fb_);

            return fc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bb_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(az_, ba_);
        object bc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate fd_ = @this?.periodStart;

            return fd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bd_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
        bool? be_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fe_ = @this?.period;
            bool? ff_ = context.Operators.Not((bool?)(fe_ is null));

            return ff_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bf_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bd_, be_);
        CqlInterval<CqlDate> bg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fg_ = @this?.period;

            return fg_;
        };
        IEnumerable<CqlInterval<CqlDate>> bh_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bf_, bg_);
        IEnumerable<CqlInterval<CqlDate>> bi_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, bh_);
        IEnumerable<CqlInterval<CqlDate>> bj_ = context.Operators.Union<CqlInterval<CqlDate>>(at_, bi_);
        IEnumerable<CqlInterval<CqlDate>> bk_ = context.Operators.Union<CqlInterval<CqlDate>>(ae_, bj_);
        CqlValueSet bl_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bm_, bo_);
        IEnumerable<MedicationRequest> bq_ = Status_1_8_000.Instance.isMedicationOrder(context, bp_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? br_(MedicationRequest LisdexamfetamineMed)
        {
            CqlInterval<CqlDate> fh_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate fj_ = context.Operators.Start(fh_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fk_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fh_, fj_);

            return fk_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bs_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bq_, br_);
        object bt_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate fl_ = @this?.periodStart;

            return fl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bu_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bs_, bt_, System.ComponentModel.ListSortDirection.Ascending);
        bool? bv_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fm_ = @this?.period;
            bool? fn_ = context.Operators.Not((bool?)(fm_ is null));

            return fn_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bw_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bu_, bv_);
        CqlInterval<CqlDate> bx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fo_ = @this?.period;

            return fo_;
        };
        IEnumerable<CqlInterval<CqlDate>> by_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bw_, bx_);
        IEnumerable<CqlInterval<CqlDate>> bz_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, by_);
        CqlValueSet ca_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> cb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ca_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ca_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ce_ = context.Operators.Union<MedicationRequest>(cb_, cd_);
        IEnumerable<MedicationRequest> cf_ = Status_1_8_000.Instance.isMedicationOrder(context, ce_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cg_(MedicationRequest MethylphenidateMed)
        {
            CqlInterval<CqlDate> fp_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate fr_ = context.Operators.Start(fp_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fs_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fp_, fr_);

            return fs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ch_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cf_, cg_);
        object ci_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate ft_ = @this?.periodStart;

            return ft_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cj_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ch_, ci_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ck_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fu_ = @this?.period;
            bool? fv_ = context.Operators.Not((bool?)(fu_ is null));

            return fv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cl_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cj_, ck_);
        CqlInterval<CqlDate> cm_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fw_ = @this?.period;

            return fw_;
        };
        IEnumerable<CqlInterval<CqlDate>> cn_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cl_, cm_);
        IEnumerable<CqlInterval<CqlDate>> co_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, cn_);
        IEnumerable<CqlInterval<CqlDate>> cp_ = context.Operators.Union<CqlInterval<CqlDate>>(bz_, co_);
        IEnumerable<CqlInterval<CqlDate>> cq_ = context.Operators.Union<CqlInterval<CqlDate>>(bk_, cp_);
        CqlValueSet cr_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> cs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cv_ = context.Operators.Union<MedicationRequest>(cs_, cu_);
        IEnumerable<MedicationRequest> cw_ = Status_1_8_000.Instance.isMedicationOrder(context, cv_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cx_(MedicationRequest GuanfacineMed)
        {
            CqlInterval<CqlDate> fx_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate fz_ = context.Operators.Start(fx_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ga_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fx_, fz_);

            return ga_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cy_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cw_, cx_);
        object cz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate gb_ = @this?.periodStart;

            return gb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> da_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cy_, cz_, System.ComponentModel.ListSortDirection.Ascending);
        bool? db_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> gc_ = @this?.period;
            bool? gd_ = context.Operators.Not((bool?)(gc_ is null));

            return gd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dc_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(da_, db_);
        CqlInterval<CqlDate> dd_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ge_ = @this?.period;

            return ge_;
        };
        IEnumerable<CqlInterval<CqlDate>> de_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dc_, dd_);
        IEnumerable<CqlInterval<CqlDate>> df_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, de_);
        CqlCode dg_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> dh_ = context.Operators.ToList<CqlCode>(dg_);
        IEnumerable<MedicationRequest> di_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, dh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> dk_ = context.Operators.ToList<CqlCode>(dg_);
        IEnumerable<MedicationRequest> dl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, dk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dm_ = context.Operators.Union<MedicationRequest>(di_, dl_);
        IEnumerable<MedicationRequest> dn_ = Status_1_8_000.Instance.isMedicationOrder(context, dm_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? do_(MedicationRequest MethamphetamineMed)
        {
            CqlInterval<CqlDate> gf_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate gh_ = context.Operators.Start(gf_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gi_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gf_, gh_);

            return gi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dp_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dn_, do_);
        object dq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate gj_ = @this?.periodStart;

            return gj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dr_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dp_, dq_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ds_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> gk_ = @this?.period;
            bool? gl_ = context.Operators.Not((bool?)(gk_ is null));

            return gl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dt_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dr_, ds_);
        CqlInterval<CqlDate> du_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> gm_ = @this?.period;

            return gm_;
        };
        IEnumerable<CqlInterval<CqlDate>> dv_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dt_, du_);
        IEnumerable<CqlInterval<CqlDate>> dw_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, dv_);
        IEnumerable<CqlInterval<CqlDate>> dx_ = context.Operators.Union<CqlInterval<CqlDate>>(df_, dw_);
        IEnumerable<CqlInterval<CqlDate>> dy_ = context.Operators.Union<CqlInterval<CqlDate>>(cq_, dx_);
        CqlInterval<CqlDate> dz_(CqlInterval<CqlDate> ADHDMedication)
        {
            CqlDate gn_ = this.IPSD(context);
            CqlQuantity gp_ = context.Operators.Quantity(300m, "days");
            CqlDate gq_ = context.Operators.Add(gn_, gp_);
            CqlInterval<CqlDate> gr_ = context.Operators.Interval(gn_, gq_, true, true);
            CqlInterval<CqlDate> gs_ = context.Operators.Intersect<CqlDate>(ADHDMedication, gr_);

            return gs_;
        };
        IEnumerable<CqlInterval<CqlDate>> ea_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(dy_, dz_);

        return ea_;
    }


    [CqlDeclaration("ADHD Cumulative Medication Duration")]
    public int? ADHD_Cumulative_Medication_Duration(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
        int? b_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, a_);

        return b_;
    }


    [CqlDeclaration("Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days")]
    public bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(CqlContext context)
    {
        int? a_ = this.ADHD_Cumulative_Medication_Duration(context);
        bool? b_ = context.Operators.GreaterOrEqual(a_, 210);

        return b_;
    }


    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? b_(Encounter InpatientStay)
        {
            Period d_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.toInterval(context, e_ as object);
            CqlInterval<CqlDate> g_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, f_);
            CqlDate h_ = context.Operators.Start(g_);
            CqlDate i_ = this.IPSD(context);
            CqlQuantity k_ = context.Operators.Quantity(300m, "days");
            CqlDate l_ = context.Operators.Add(i_, k_);
            CqlInterval<CqlDate> m_ = context.Operators.Interval(i_, l_, false, true);
            bool? n_ = context.Operators.In<CqlDate>(h_, m_, "day");
            bool? p_ = context.Operators.Not((bool?)(i_ is null));
            bool? q_ = context.Operators.And(n_, p_);

            return q_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Intake_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 6);
        Date k_ = a_?.BirthDateElement;
        string l_ = k_?.Value;
        CqlDate m_ = context.Operators.ConvertStringToDate(l_);
        CqlDateTime o_ = context.Operators.End(e_);
        CqlDate p_ = context.Operators.DateFrom(o_);
        int? q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
        bool? r_ = context.Operators.LessOrEqual(q_, 12);
        bool? s_ = context.Operators.And(i_, r_);
        IEnumerable<Encounter> t_ = this.Qualifying_Encounter(context);
        bool? u_ = context.Operators.Exists<Encounter>(t_);
        bool? v_ = context.Operators.And(s_, u_);
        CqlDate w_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? x_ = context.Operators.Not((bool?)(w_ is null));
        bool? y_ = context.Operators.And(v_, x_);
        bool? z_ = this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(context);
        bool? aa_ = context.Operators.And(y_, z_);
        IEnumerable<Encounter> ab_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(context);
        bool? ac_ = context.Operators.Exists<Encounter>(ab_);
        bool? ad_ = context.Operators.Not(ac_);
        bool? ae_ = context.Operators.And(aa_, ad_);

        return ae_;
    }


    [CqlDeclaration("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? a_ = this.Initial_Population_2(context);

        return a_;
    }


    [CqlDeclaration("Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> b_ = Status_1_8_000.Instance.isEncounterPerformed(context, a_);
        bool? c_(Encounter ValidNumeratorEncounter)
        {
            Period g_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.toInterval(context, h_ as object);
            CqlInterval<CqlDate> j_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, i_);
            CqlDate k_ = context.Operators.Start(j_);
            CqlDate l_ = this.IPSD(context);
            CqlQuantity m_ = context.Operators.Quantity(31m, "days");
            CqlDate n_ = context.Operators.Add(l_, m_);
            CqlQuantity p_ = context.Operators.Quantity(300m, "days");
            CqlDate q_ = context.Operators.Add(l_, p_);
            CqlInterval<CqlDate> r_ = context.Operators.Interval(n_, q_, true, true);
            bool? s_ = context.Operators.In<CqlDate>(k_, r_, "day");

            return s_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        CqlDate e_(Encounter ValidNumeratorEncounter)
        {
            Period t_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlDate w_ = context.Operators.DateFrom(v_);

            return w_;
        };
        IEnumerable<CqlDate> f_ = context.Operators.Select<Encounter, CqlDate>(d_, e_);

        return f_;
    }


    [CqlDeclaration("Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
    public bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        int? b_ = context.Operators.Count<CqlDate>(a_);
        bool? c_ = context.Operators.GreaterOrEqual(b_, 2);

        return c_;
    }


    [CqlDeclaration("Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet a_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_8_000.Instance.isEncounterPerformed(context, b_);
        bool? d_(Encounter VirtualEnc)
        {
            Period h_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.toInterval(context, i_ as object);
            CqlInterval<CqlDate> k_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, j_);
            CqlDate l_ = context.Operators.Start(k_);
            CqlDate m_ = this.IPSD(context);
            CqlQuantity n_ = context.Operators.Quantity(31m, "days");
            CqlDate o_ = context.Operators.Add(m_, n_);
            CqlQuantity q_ = context.Operators.Quantity(300m, "days");
            CqlDate r_ = context.Operators.Add(m_, q_);
            CqlInterval<CqlDate> s_ = context.Operators.Interval(o_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDate>(l_, s_, "day");

            return t_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        CqlDate f_(Encounter VirtualEnc)
        {
            Period u_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlDate x_ = context.Operators.DateFrom(w_);

            return x_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Encounter, CqlDate>(e_, f_);

        return g_;
    }


    [CqlDeclaration("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_During_Initiation_Phase(context);
        bool? b_ = context.Operators.Exists<Encounter>(a_);
        bool? c_ = this.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> d_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> e_(CqlDate Encounter1)
        {
            IEnumerable<CqlDate> j_ = this.Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
            bool? k_(CqlDate Encounter2)
            {
                bool? o_ = context.Operators.Not((bool?)(Encounter1 is null));
                bool? p_ = context.Operators.Not((bool?)(Encounter2 is null));
                bool? q_ = context.Operators.And(o_, p_);
                bool? r_ = context.Operators.Equivalent(Encounter1, Encounter2);
                bool? s_ = context.Operators.Not(r_);
                bool? t_ = context.Operators.And(q_, s_);

                return t_;
            };
            IEnumerable<CqlDate> l_ = context.Operators.Where<CqlDate>(j_, k_);
            CqlDate m_(CqlDate Encounter2) => 
                Encounter1;
            IEnumerable<CqlDate> n_ = context.Operators.Select<CqlDate, CqlDate>(l_, m_);

            return n_;
        };
        IEnumerable<CqlDate> f_ = context.Operators.SelectMany<CqlDate, CqlDate>(d_, e_);
        bool? g_ = context.Operators.Exists<CqlDate>(f_);
        bool? h_ = context.Operators.Or(c_, g_);
        bool? i_ = context.Operators.And(b_, h_);

        return i_;
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

    private static CqlTupleMetadata CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW = new(
        [typeof(CqlDate)],
        ["startDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
        ["period", "periodStart"]);

}
