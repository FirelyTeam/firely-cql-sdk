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
[CqlLibrary("CMS136FHIRChildADHDMedFollowUp", "1.0.000")]
public partial class CMS136FHIRChildADHDMedFollowUp_1_0_000 : ILibrary, ISingleton<CMS136FHIRChildADHDMedFollowUp_1_0_000>
{
    private CMS136FHIRChildADHDMedFollowUp_1_0_000() {}

    public static CMS136FHIRChildADHDMedFollowUp_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS136FHIRChildADHDMedFollowUp";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance, Hospice_6_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", valueSetVersion: null)]
    public CqlValueSet Ambulatory(CqlContext _) => _Ambulatory;
    private static readonly CqlValueSet _Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", null);

    [CqlValueSetDefinition("Atomoxetine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", valueSetVersion: null)]
    public CqlValueSet Atomoxetine(CqlContext _) => _Atomoxetine;
    private static readonly CqlValueSet _Atomoxetine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", null);

    [CqlValueSetDefinition("Behavioral Health Follow up Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", valueSetVersion: null)]
    public CqlValueSet Behavioral_Health_Follow_up_Visit(CqlContext _) => _Behavioral_Health_Follow_up_Visit;
    private static readonly CqlValueSet _Behavioral_Health_Follow_up_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", null);

    [CqlValueSetDefinition("Clonidine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", valueSetVersion: null)]
    public CqlValueSet Clonidine(CqlContext _) => _Clonidine;
    private static readonly CqlValueSet _Clonidine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", null);

    [CqlValueSetDefinition("Dexmethylphenidate", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", valueSetVersion: null)]
    public CqlValueSet Dexmethylphenidate(CqlContext _) => _Dexmethylphenidate;
    private static readonly CqlValueSet _Dexmethylphenidate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", null);

    [CqlValueSetDefinition("Dextroamphetamine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", valueSetVersion: null)]
    public CqlValueSet Dextroamphetamine(CqlContext _) => _Dextroamphetamine;
    private static readonly CqlValueSet _Dextroamphetamine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Guanfacine Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", valueSetVersion: null)]
    public CqlValueSet Guanfacine_Medications(CqlContext _) => _Guanfacine_Medications;
    private static readonly CqlValueSet _Guanfacine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Lisdexamfetamine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", valueSetVersion: null)]
    public CqlValueSet Lisdexamfetamine(CqlContext _) => _Lisdexamfetamine;
    private static readonly CqlValueSet _Lisdexamfetamine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", null);

    [CqlValueSetDefinition("Mental Behavioral and Neurodevelopmental Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", valueSetVersion: null)]
    public CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders(CqlContext _) => _Mental_Behavioral_and_Neurodevelopmental_Disorders;
    private static readonly CqlValueSet _Mental_Behavioral_and_Neurodevelopmental_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", null);

    [CqlValueSetDefinition("Methylphenidate", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", valueSetVersion: null)]
    public CqlValueSet Methylphenidate(CqlContext _) => _Methylphenidate;
    private static readonly CqlValueSet _Methylphenidate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", null);

    [CqlValueSetDefinition("Narcolepsy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", valueSetVersion: null)]
    public CqlValueSet Narcolepsy(CqlContext _) => _Narcolepsy;
    private static readonly CqlValueSet _Narcolepsy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Group Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext _) => _Preventive_Care_Services_Group_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Psychotherapy and Pharmacologic Management", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", valueSetVersion: null)]
    public CqlValueSet Psychotherapy_and_Pharmacologic_Management(CqlContext _) => _Psychotherapy_and_Pharmacologic_Management;
    private static readonly CqlValueSet _Psychotherapy_and_Pharmacologic_Management = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Viloxazine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1260", valueSetVersion: null)]
    public CqlValueSet Viloxazine(CqlContext _) => _Viloxazine;
    private static readonly CqlValueSet _Viloxazine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1260", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("methamphetamine hydrochloride 5 MG Oral Tablet", codeId: "977860", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet(CqlContext _) => _methamphetamine_hydrochloride_5_MG_Oral_Tablet;
    private static readonly CqlCode _methamphetamine_hydrochloride_5_MG_Oral_Tablet = new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("RXNORM", codeSystemId: "http://www.nlm.nih.gov/research/umls/rxnorm", codeSystemVersion: null)]
    public CqlCodeSystem RXNORM(CqlContext _) => _RXNORM;
    private static readonly CqlCodeSystem _RXNORM =
      new CqlCodeSystem("http://www.nlm.nih.gov/research/umls/rxnorm", null, [
          _methamphetamine_hydrochloride_5_MG_Oral_Tablet]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS136FHIRChildADHDMedFollowUp-1.0.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
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


    [CqlExpressionDefinition("March 1 of Year Prior to Measurement Period")]
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


    [CqlExpressionDefinition("Last Calendar Day of February of Measurement Period")]
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


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime a_ = this.March_1_of_Year_Prior_to_Measurement_Period(context);
        CqlDateTime b_ = this.Last_Calendar_Day_of_February_of_Measurement_Period(context);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);

        return c_;
    }


    [CqlExpressionDefinition("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
    public IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(CqlContext context)
    {
        CqlValueSet a_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> ej_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ek_(Medication M)
            {
                object eo_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ep_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> eq_ = context.Operators.Split((string)ep_, "/");
                string er_ = context.Operators.Last<string>(eq_);
                bool? es_ = context.Operators.Equal(eo_, er_);
                CodeableConcept et_ = M?.Code;
                CqlConcept eu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, et_);
                CqlValueSet ev_ = this.Atomoxetine(context);
                bool? ew_ = context.Operators.ConceptInValueSet(eu_, ev_);
                bool? ex_ = context.Operators.And(es_, ew_);

                return ex_;
            };
            IEnumerable<Medication> el_ = context.Operators.Where<Medication>(ej_, ek_);
            MedicationRequest em_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> en_ = context.Operators.Select<Medication, MedicationRequest>(el_, em_);

            return en_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_(MedicationRequest MR)
        {
            IEnumerable<Medication> ey_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ez_(Medication M)
            {
                object fd_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fe_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ff_ = context.Operators.Split((string)fe_, "/");
                string fg_ = context.Operators.Last<string>(ff_);
                bool? fh_ = context.Operators.Equal(fd_, fg_);
                CodeableConcept fi_ = M?.Code;
                CqlConcept fj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fi_);
                CqlValueSet fk_ = this.Clonidine(context);
                bool? fl_ = context.Operators.ConceptInValueSet(fj_, fk_);
                bool? fm_ = context.Operators.And(fh_, fl_);

                return fm_;
            };
            IEnumerable<Medication> fa_ = context.Operators.Where<Medication>(ey_, ez_);
            MedicationRequest fb_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> fc_ = context.Operators.Select<Medication, MedicationRequest>(fa_, fb_);

            return fc_;
        };
        IEnumerable<MedicationRequest> k_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        CqlValueSet n_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_(MedicationRequest MR)
        {
            IEnumerable<Medication> fn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? fo_(Medication M)
            {
                object fs_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ft_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fu_ = context.Operators.Split((string)ft_, "/");
                string fv_ = context.Operators.Last<string>(fu_);
                bool? fw_ = context.Operators.Equal(fs_, fv_);
                CodeableConcept fx_ = M?.Code;
                CqlConcept fy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fx_);
                CqlValueSet fz_ = this.Dexmethylphenidate(context);
                bool? ga_ = context.Operators.ConceptInValueSet(fy_, fz_);
                bool? gb_ = context.Operators.And(fw_, ga_);

                return gb_;
            };
            IEnumerable<Medication> fp_ = context.Operators.Where<Medication>(fn_, fo_);
            MedicationRequest fq_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> fr_ = context.Operators.Select<Medication, MedicationRequest>(fp_, fq_);

            return fr_;
        };
        IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, q_);
        IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(o_, r_);
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(m_, s_);
        CqlValueSet u_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> x_(MedicationRequest MR)
        {
            IEnumerable<Medication> gc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? gd_(Medication M)
            {
                object gh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gj_ = context.Operators.Split((string)gi_, "/");
                string gk_ = context.Operators.Last<string>(gj_);
                bool? gl_ = context.Operators.Equal(gh_, gk_);
                CodeableConcept gm_ = M?.Code;
                CqlConcept gn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gm_);
                CqlValueSet go_ = this.Dextroamphetamine(context);
                bool? gp_ = context.Operators.ConceptInValueSet(gn_, go_);
                bool? gq_ = context.Operators.And(gl_, gp_);

                return gq_;
            };
            IEnumerable<Medication> ge_ = context.Operators.Where<Medication>(gc_, gd_);
            MedicationRequest gf_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> gg_ = context.Operators.Select<Medication, MedicationRequest>(ge_, gf_);

            return gg_;
        };
        IEnumerable<MedicationRequest> y_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, x_);
        IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(v_, y_);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(t_, z_);
        CqlValueSet ab_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> ac_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ae_(MedicationRequest MR)
        {
            IEnumerable<Medication> gr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? gs_(Medication M)
            {
                object gw_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gx_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gy_ = context.Operators.Split((string)gx_, "/");
                string gz_ = context.Operators.Last<string>(gy_);
                bool? ha_ = context.Operators.Equal(gw_, gz_);
                CodeableConcept hb_ = M?.Code;
                CqlConcept hc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hb_);
                CqlValueSet hd_ = this.Lisdexamfetamine(context);
                bool? he_ = context.Operators.ConceptInValueSet(hc_, hd_);
                bool? hf_ = context.Operators.And(ha_, he_);

                return hf_;
            };
            IEnumerable<Medication> gt_ = context.Operators.Where<Medication>(gr_, gs_);
            MedicationRequest gu_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> gv_ = context.Operators.Select<Medication, MedicationRequest>(gt_, gu_);

            return gv_;
        };
        IEnumerable<MedicationRequest> af_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ae_);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ac_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(aa_, ag_);
        CqlCode ai_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> aj_ = context.Operators.ToList<CqlCode>(ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, aj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> am_(MedicationRequest MR)
        {
            IEnumerable<Medication> hg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? hh_(Medication M)
            {
                object hl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hn_ = context.Operators.Split((string)hm_, "/");
                string ho_ = context.Operators.Last<string>(hn_);
                bool? hp_ = context.Operators.Equal(hl_, ho_);
                CodeableConcept hq_ = M?.Code;
                CqlConcept hr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hq_);
                CqlCode hs_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept ht_ = context.Operators.ConvertCodeToConcept(hs_);
                bool? hu_ = context.Operators.Equivalent(hr_, ht_);
                bool? hv_ = context.Operators.And(hp_, hu_);

                return hv_;
            };
            IEnumerable<Medication> hi_ = context.Operators.Where<Medication>(hg_, hh_);
            MedicationRequest hj_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> hk_ = context.Operators.Select<Medication, MedicationRequest>(hi_, hj_);

            return hk_;
        };
        IEnumerable<MedicationRequest> an_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, am_);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Union<MedicationRequest>(ak_, an_);
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(ah_, ao_);
        CqlValueSet aq_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> ar_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> at_(MedicationRequest MR)
        {
            IEnumerable<Medication> hw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? hx_(Medication M)
            {
                object ib_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ic_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> id_ = context.Operators.Split((string)ic_, "/");
                string ie_ = context.Operators.Last<string>(id_);
                bool? if_ = context.Operators.Equal(ib_, ie_);
                CodeableConcept ig_ = M?.Code;
                CqlConcept ih_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ig_);
                CqlValueSet ii_ = this.Methylphenidate(context);
                bool? ij_ = context.Operators.ConceptInValueSet(ih_, ii_);
                bool? ik_ = context.Operators.And(if_, ij_);

                return ik_;
            };
            IEnumerable<Medication> hy_ = context.Operators.Where<Medication>(hw_, hx_);
            MedicationRequest hz_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> ia_ = context.Operators.Select<Medication, MedicationRequest>(hy_, hz_);

            return ia_;
        };
        IEnumerable<MedicationRequest> au_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, at_);
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(ar_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(ap_, av_);
        CqlValueSet ax_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ba_(MedicationRequest MR)
        {
            IEnumerable<Medication> il_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? im_(Medication M)
            {
                object iq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ir_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> is_ = context.Operators.Split((string)ir_, "/");
                string it_ = context.Operators.Last<string>(is_);
                bool? iu_ = context.Operators.Equal(iq_, it_);
                CodeableConcept iv_ = M?.Code;
                CqlConcept iw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, iv_);
                CqlValueSet ix_ = this.Guanfacine_Medications(context);
                bool? iy_ = context.Operators.ConceptInValueSet(iw_, ix_);
                bool? iz_ = context.Operators.And(iu_, iy_);

                return iz_;
            };
            IEnumerable<Medication> in_ = context.Operators.Where<Medication>(il_, im_);
            MedicationRequest io_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> ip_ = context.Operators.Select<Medication, MedicationRequest>(in_, io_);

            return ip_;
        };
        IEnumerable<MedicationRequest> bb_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ay_, bb_);
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(aw_, bc_);
        CqlValueSet be_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> bf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bh_(MedicationRequest MR)
        {
            IEnumerable<Medication> ja_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? jb_(Medication M)
            {
                object jf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object jg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jh_ = context.Operators.Split((string)jg_, "/");
                string ji_ = context.Operators.Last<string>(jh_);
                bool? jj_ = context.Operators.Equal(jf_, ji_);
                CodeableConcept jk_ = M?.Code;
                CqlConcept jl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jk_);
                CqlValueSet jm_ = this.Viloxazine(context);
                bool? jn_ = context.Operators.ConceptInValueSet(jl_, jm_);
                bool? jo_ = context.Operators.And(jj_, jn_);

                return jo_;
            };
            IEnumerable<Medication> jc_ = context.Operators.Where<Medication>(ja_, jb_);
            MedicationRequest jd_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> je_ = context.Operators.Select<Medication, MedicationRequest>(jc_, jd_);

            return je_;
        };
        IEnumerable<MedicationRequest> bi_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bh_);
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bf_, bi_);
        IEnumerable<MedicationRequest> bk_ = context.Operators.Union<MedicationRequest>(bd_, bj_);
        IEnumerable<MedicationRequest> bl_ = Status_1_15_000.Instance.isMedicationOrder(context, bk_);
        bool? bm_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> jp_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate jq_ = context.Operators.Start(jp_);
            CqlDateTime jr_ = context.Operators.ConvertDateToDateTime(jq_);
            CqlInterval<CqlDateTime> js_ = this.Intake_Period(context);
            bool? jt_ = context.Operators.In<CqlDateTime>(jr_, js_, default);

            return jt_;
        };
        IEnumerable<MedicationRequest> bn_ = context.Operators.Where<MedicationRequest>(bl_, bm_);
        IEnumerable<MedicationRequest> bp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> br_(MedicationRequest MR)
        {
            IEnumerable<Medication> ju_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? jv_(Medication M)
            {
                object jz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ka_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kb_ = context.Operators.Split((string)ka_, "/");
                string kc_ = context.Operators.Last<string>(kb_);
                bool? kd_ = context.Operators.Equal(jz_, kc_);
                CodeableConcept ke_ = M?.Code;
                CqlConcept kf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ke_);
                CqlValueSet kg_ = this.Atomoxetine(context);
                bool? kh_ = context.Operators.ConceptInValueSet(kf_, kg_);
                bool? ki_ = context.Operators.And(kd_, kh_);

                return ki_;
            };
            IEnumerable<Medication> jw_ = context.Operators.Where<Medication>(ju_, jv_);
            MedicationRequest jx_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> jy_ = context.Operators.Select<Medication, MedicationRequest>(jw_, jx_);

            return jy_;
        };
        IEnumerable<MedicationRequest> bs_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, br_);
        IEnumerable<MedicationRequest> bt_ = context.Operators.Union<MedicationRequest>(bp_, bs_);
        IEnumerable<MedicationRequest> bv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bx_(MedicationRequest MR)
        {
            IEnumerable<Medication> kj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? kk_(Medication M)
            {
                object ko_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kq_ = context.Operators.Split((string)kp_, "/");
                string kr_ = context.Operators.Last<string>(kq_);
                bool? ks_ = context.Operators.Equal(ko_, kr_);
                CodeableConcept kt_ = M?.Code;
                CqlConcept ku_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kt_);
                CqlValueSet kv_ = this.Clonidine(context);
                bool? kw_ = context.Operators.ConceptInValueSet(ku_, kv_);
                bool? kx_ = context.Operators.And(ks_, kw_);

                return kx_;
            };
            IEnumerable<Medication> kl_ = context.Operators.Where<Medication>(kj_, kk_);
            MedicationRequest km_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> kn_ = context.Operators.Select<Medication, MedicationRequest>(kl_, km_);

            return kn_;
        };
        IEnumerable<MedicationRequest> by_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bx_);
        IEnumerable<MedicationRequest> bz_ = context.Operators.Union<MedicationRequest>(bv_, by_);
        IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bt_, bz_);
        IEnumerable<MedicationRequest> cc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ce_(MedicationRequest MR)
        {
            IEnumerable<Medication> ky_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? kz_(Medication M)
            {
                object ld_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object le_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> lf_ = context.Operators.Split((string)le_, "/");
                string lg_ = context.Operators.Last<string>(lf_);
                bool? lh_ = context.Operators.Equal(ld_, lg_);
                CodeableConcept li_ = M?.Code;
                CqlConcept lj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, li_);
                CqlValueSet lk_ = this.Dexmethylphenidate(context);
                bool? ll_ = context.Operators.ConceptInValueSet(lj_, lk_);
                bool? lm_ = context.Operators.And(lh_, ll_);

                return lm_;
            };
            IEnumerable<Medication> la_ = context.Operators.Where<Medication>(ky_, kz_);
            MedicationRequest lb_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> lc_ = context.Operators.Select<Medication, MedicationRequest>(la_, lb_);

            return lc_;
        };
        IEnumerable<MedicationRequest> cf_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ce_);
        IEnumerable<MedicationRequest> cg_ = context.Operators.Union<MedicationRequest>(cc_, cf_);
        IEnumerable<MedicationRequest> ch_ = context.Operators.Union<MedicationRequest>(ca_, cg_);
        IEnumerable<MedicationRequest> cj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cl_(MedicationRequest MR)
        {
            IEnumerable<Medication> ln_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? lo_(Medication M)
            {
                object ls_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lt_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> lu_ = context.Operators.Split((string)lt_, "/");
                string lv_ = context.Operators.Last<string>(lu_);
                bool? lw_ = context.Operators.Equal(ls_, lv_);
                CodeableConcept lx_ = M?.Code;
                CqlConcept ly_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lx_);
                CqlValueSet lz_ = this.Dextroamphetamine(context);
                bool? ma_ = context.Operators.ConceptInValueSet(ly_, lz_);
                bool? mb_ = context.Operators.And(lw_, ma_);

                return mb_;
            };
            IEnumerable<Medication> lp_ = context.Operators.Where<Medication>(ln_, lo_);
            MedicationRequest lq_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> lr_ = context.Operators.Select<Medication, MedicationRequest>(lp_, lq_);

            return lr_;
        };
        IEnumerable<MedicationRequest> cm_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, cl_);
        IEnumerable<MedicationRequest> cn_ = context.Operators.Union<MedicationRequest>(cj_, cm_);
        IEnumerable<MedicationRequest> co_ = context.Operators.Union<MedicationRequest>(ch_, cn_);
        IEnumerable<MedicationRequest> cq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cs_(MedicationRequest MR)
        {
            IEnumerable<Medication> mc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? md_(Medication M)
            {
                object mh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> mj_ = context.Operators.Split((string)mi_, "/");
                string mk_ = context.Operators.Last<string>(mj_);
                bool? ml_ = context.Operators.Equal(mh_, mk_);
                CodeableConcept mm_ = M?.Code;
                CqlConcept mn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mm_);
                CqlValueSet mo_ = this.Lisdexamfetamine(context);
                bool? mp_ = context.Operators.ConceptInValueSet(mn_, mo_);
                bool? mq_ = context.Operators.And(ml_, mp_);

                return mq_;
            };
            IEnumerable<Medication> me_ = context.Operators.Where<Medication>(mc_, md_);
            MedicationRequest mf_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> mg_ = context.Operators.Select<Medication, MedicationRequest>(me_, mf_);

            return mg_;
        };
        IEnumerable<MedicationRequest> ct_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, cs_);
        IEnumerable<MedicationRequest> cu_ = context.Operators.Union<MedicationRequest>(cq_, ct_);
        IEnumerable<MedicationRequest> cv_ = context.Operators.Union<MedicationRequest>(co_, cu_);
        IEnumerable<CqlCode> cx_ = context.Operators.ToList<CqlCode>(ai_);
        IEnumerable<MedicationRequest> cy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, cx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> da_(MedicationRequest MR)
        {
            IEnumerable<Medication> mr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ms_(Medication M)
            {
                object mw_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mx_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> my_ = context.Operators.Split((string)mx_, "/");
                string mz_ = context.Operators.Last<string>(my_);
                bool? na_ = context.Operators.Equal(mw_, mz_);
                CodeableConcept nb_ = M?.Code;
                CqlConcept nc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nb_);
                CqlCode nd_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept ne_ = context.Operators.ConvertCodeToConcept(nd_);
                bool? nf_ = context.Operators.Equivalent(nc_, ne_);
                bool? ng_ = context.Operators.And(na_, nf_);

                return ng_;
            };
            IEnumerable<Medication> mt_ = context.Operators.Where<Medication>(mr_, ms_);
            MedicationRequest mu_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> mv_ = context.Operators.Select<Medication, MedicationRequest>(mt_, mu_);

            return mv_;
        };
        IEnumerable<MedicationRequest> db_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, da_);
        IEnumerable<MedicationRequest> dc_ = context.Operators.Union<MedicationRequest>(cy_, db_);
        IEnumerable<MedicationRequest> dd_ = context.Operators.Union<MedicationRequest>(cv_, dc_);
        IEnumerable<MedicationRequest> df_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dh_(MedicationRequest MR)
        {
            IEnumerable<Medication> nh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ni_(Medication M)
            {
                object nm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object nn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> no_ = context.Operators.Split((string)nn_, "/");
                string np_ = context.Operators.Last<string>(no_);
                bool? nq_ = context.Operators.Equal(nm_, np_);
                CodeableConcept nr_ = M?.Code;
                CqlConcept ns_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nr_);
                CqlValueSet nt_ = this.Methylphenidate(context);
                bool? nu_ = context.Operators.ConceptInValueSet(ns_, nt_);
                bool? nv_ = context.Operators.And(nq_, nu_);

                return nv_;
            };
            IEnumerable<Medication> nj_ = context.Operators.Where<Medication>(nh_, ni_);
            MedicationRequest nk_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> nl_ = context.Operators.Select<Medication, MedicationRequest>(nj_, nk_);

            return nl_;
        };
        IEnumerable<MedicationRequest> di_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, dh_);
        IEnumerable<MedicationRequest> dj_ = context.Operators.Union<MedicationRequest>(df_, di_);
        IEnumerable<MedicationRequest> dk_ = context.Operators.Union<MedicationRequest>(dd_, dj_);
        IEnumerable<MedicationRequest> dm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> do_(MedicationRequest MR)
        {
            IEnumerable<Medication> nw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? nx_(Medication M)
            {
                object ob_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object oc_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> od_ = context.Operators.Split((string)oc_, "/");
                string oe_ = context.Operators.Last<string>(od_);
                bool? of_ = context.Operators.Equal(ob_, oe_);
                CodeableConcept og_ = M?.Code;
                CqlConcept oh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, og_);
                CqlValueSet oi_ = this.Guanfacine_Medications(context);
                bool? oj_ = context.Operators.ConceptInValueSet(oh_, oi_);
                bool? ok_ = context.Operators.And(of_, oj_);

                return ok_;
            };
            IEnumerable<Medication> ny_ = context.Operators.Where<Medication>(nw_, nx_);
            MedicationRequest nz_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> oa_ = context.Operators.Select<Medication, MedicationRequest>(ny_, nz_);

            return oa_;
        };
        IEnumerable<MedicationRequest> dp_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, do_);
        IEnumerable<MedicationRequest> dq_ = context.Operators.Union<MedicationRequest>(dm_, dp_);
        IEnumerable<MedicationRequest> dr_ = context.Operators.Union<MedicationRequest>(dk_, dq_);
        IEnumerable<MedicationRequest> dt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dv_(MedicationRequest MR)
        {
            IEnumerable<Medication> ol_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? om_(Medication M)
            {
                object oq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object or_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> os_ = context.Operators.Split((string)or_, "/");
                string ot_ = context.Operators.Last<string>(os_);
                bool? ou_ = context.Operators.Equal(oq_, ot_);
                CodeableConcept ov_ = M?.Code;
                CqlConcept ow_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ov_);
                CqlValueSet ox_ = this.Viloxazine(context);
                bool? oy_ = context.Operators.ConceptInValueSet(ow_, ox_);
                bool? oz_ = context.Operators.And(ou_, oy_);

                return oz_;
            };
            IEnumerable<Medication> on_ = context.Operators.Where<Medication>(ol_, om_);
            MedicationRequest oo_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> op_ = context.Operators.Select<Medication, MedicationRequest>(on_, oo_);

            return op_;
        };
        IEnumerable<MedicationRequest> dw_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, dv_);
        IEnumerable<MedicationRequest> dx_ = context.Operators.Union<MedicationRequest>(dt_, dw_);
        IEnumerable<MedicationRequest> dy_ = context.Operators.Union<MedicationRequest>(dr_, dx_);
        IEnumerable<MedicationRequest> dz_ = Status_1_15_000.Instance.isMedicationOrder(context, dy_);
        bool? ea_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> pa_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate pb_ = context.Operators.Start(pa_);
            CqlDateTime pc_ = context.Operators.ConvertDateToDateTime(pb_);
            CqlInterval<CqlDateTime> pd_ = this.Intake_Period(context);
            bool? pe_ = context.Operators.In<CqlDateTime>(pc_, pd_, default);

            return pe_;
        };
        IEnumerable<MedicationRequest> eb_ = context.Operators.Where<MedicationRequest>(dz_, ea_);
        IEnumerable<MedicationRequest> ec_(MedicationRequest ADHDMedicationOrder)
        {
            CqlValueSet pf_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> pg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ph_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> pi_(MedicationRequest MR)
            {
                IEnumerable<Medication> rv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? rw_(Medication M)
                {
                    object sa_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object sb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> sc_ = context.Operators.Split((string)sb_, "/");
                    string sd_ = context.Operators.Last<string>(sc_);
                    bool? se_ = context.Operators.Equal(sa_, sd_);
                    CodeableConcept sf_ = M?.Code;
                    CqlConcept sg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, sf_);
                    CqlValueSet sh_ = this.Atomoxetine(context);
                    bool? si_ = context.Operators.ConceptInValueSet(sg_, sh_);
                    bool? sj_ = context.Operators.And(se_, si_);

                    return sj_;
                };
                IEnumerable<Medication> rx_ = context.Operators.Where<Medication>(rv_, rw_);
                MedicationRequest ry_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> rz_ = context.Operators.Select<Medication, MedicationRequest>(rx_, ry_);

                return rz_;
            };
            IEnumerable<MedicationRequest> pj_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, pi_);
            IEnumerable<MedicationRequest> pk_ = context.Operators.Union<MedicationRequest>(pg_, pj_);
            CqlValueSet pl_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> pm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> po_(MedicationRequest MR)
            {
                IEnumerable<Medication> sk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? sl_(Medication M)
                {
                    object sp_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object sq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> sr_ = context.Operators.Split((string)sq_, "/");
                    string ss_ = context.Operators.Last<string>(sr_);
                    bool? st_ = context.Operators.Equal(sp_, ss_);
                    CodeableConcept su_ = M?.Code;
                    CqlConcept sv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, su_);
                    CqlValueSet sw_ = this.Clonidine(context);
                    bool? sx_ = context.Operators.ConceptInValueSet(sv_, sw_);
                    bool? sy_ = context.Operators.And(st_, sx_);

                    return sy_;
                };
                IEnumerable<Medication> sm_ = context.Operators.Where<Medication>(sk_, sl_);
                MedicationRequest sn_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> so_ = context.Operators.Select<Medication, MedicationRequest>(sm_, sn_);

                return so_;
            };
            IEnumerable<MedicationRequest> pp_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, po_);
            IEnumerable<MedicationRequest> pq_ = context.Operators.Union<MedicationRequest>(pm_, pp_);
            IEnumerable<MedicationRequest> pr_ = context.Operators.Union<MedicationRequest>(pk_, pq_);
            CqlValueSet ps_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> pt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ps_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> pv_(MedicationRequest MR)
            {
                IEnumerable<Medication> sz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? ta_(Medication M)
                {
                    object te_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object tf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> tg_ = context.Operators.Split((string)tf_, "/");
                    string th_ = context.Operators.Last<string>(tg_);
                    bool? ti_ = context.Operators.Equal(te_, th_);
                    CodeableConcept tj_ = M?.Code;
                    CqlConcept tk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tj_);
                    CqlValueSet tl_ = this.Dexmethylphenidate(context);
                    bool? tm_ = context.Operators.ConceptInValueSet(tk_, tl_);
                    bool? tn_ = context.Operators.And(ti_, tm_);

                    return tn_;
                };
                IEnumerable<Medication> tb_ = context.Operators.Where<Medication>(sz_, ta_);
                MedicationRequest tc_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> td_ = context.Operators.Select<Medication, MedicationRequest>(tb_, tc_);

                return td_;
            };
            IEnumerable<MedicationRequest> pw_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, pv_);
            IEnumerable<MedicationRequest> px_ = context.Operators.Union<MedicationRequest>(pt_, pw_);
            IEnumerable<MedicationRequest> py_ = context.Operators.Union<MedicationRequest>(pr_, px_);
            CqlValueSet pz_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> qa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qc_(MedicationRequest MR)
            {
                IEnumerable<Medication> to_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? tp_(Medication M)
                {
                    object tt_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object tu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> tv_ = context.Operators.Split((string)tu_, "/");
                    string tw_ = context.Operators.Last<string>(tv_);
                    bool? tx_ = context.Operators.Equal(tt_, tw_);
                    CodeableConcept ty_ = M?.Code;
                    CqlConcept tz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ty_);
                    CqlValueSet ua_ = this.Dextroamphetamine(context);
                    bool? ub_ = context.Operators.ConceptInValueSet(tz_, ua_);
                    bool? uc_ = context.Operators.And(tx_, ub_);

                    return uc_;
                };
                IEnumerable<Medication> tq_ = context.Operators.Where<Medication>(to_, tp_);
                MedicationRequest tr_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> ts_ = context.Operators.Select<Medication, MedicationRequest>(tq_, tr_);

                return ts_;
            };
            IEnumerable<MedicationRequest> qd_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, qc_);
            IEnumerable<MedicationRequest> qe_ = context.Operators.Union<MedicationRequest>(qa_, qd_);
            IEnumerable<MedicationRequest> qf_ = context.Operators.Union<MedicationRequest>(py_, qe_);
            CqlValueSet qg_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> qh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qj_(MedicationRequest MR)
            {
                IEnumerable<Medication> ud_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? ue_(Medication M)
                {
                    object ui_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object uj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> uk_ = context.Operators.Split((string)uj_, "/");
                    string ul_ = context.Operators.Last<string>(uk_);
                    bool? um_ = context.Operators.Equal(ui_, ul_);
                    CodeableConcept un_ = M?.Code;
                    CqlConcept uo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, un_);
                    CqlValueSet up_ = this.Lisdexamfetamine(context);
                    bool? uq_ = context.Operators.ConceptInValueSet(uo_, up_);
                    bool? ur_ = context.Operators.And(um_, uq_);

                    return ur_;
                };
                IEnumerable<Medication> uf_ = context.Operators.Where<Medication>(ud_, ue_);
                MedicationRequest ug_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> uh_ = context.Operators.Select<Medication, MedicationRequest>(uf_, ug_);

                return uh_;
            };
            IEnumerable<MedicationRequest> qk_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, qj_);
            IEnumerable<MedicationRequest> ql_ = context.Operators.Union<MedicationRequest>(qh_, qk_);
            IEnumerable<MedicationRequest> qm_ = context.Operators.Union<MedicationRequest>(qf_, ql_);
            CqlCode qn_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> qo_ = context.Operators.ToList<CqlCode>(qn_);
            IEnumerable<MedicationRequest> qp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, qo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qr_(MedicationRequest MR)
            {
                IEnumerable<Medication> us_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? ut_(Medication M)
                {
                    object ux_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object uy_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> uz_ = context.Operators.Split((string)uy_, "/");
                    string va_ = context.Operators.Last<string>(uz_);
                    bool? vb_ = context.Operators.Equal(ux_, va_);
                    CodeableConcept vc_ = M?.Code;
                    CqlConcept vd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vc_);
                    CqlCode ve_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                    CqlConcept vf_ = context.Operators.ConvertCodeToConcept(ve_);
                    bool? vg_ = context.Operators.Equivalent(vd_, vf_);
                    bool? vh_ = context.Operators.And(vb_, vg_);

                    return vh_;
                };
                IEnumerable<Medication> uu_ = context.Operators.Where<Medication>(us_, ut_);
                MedicationRequest uv_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> uw_ = context.Operators.Select<Medication, MedicationRequest>(uu_, uv_);

                return uw_;
            };
            IEnumerable<MedicationRequest> qs_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, qr_);
            IEnumerable<MedicationRequest> qt_ = context.Operators.Union<MedicationRequest>(qp_, qs_);
            IEnumerable<MedicationRequest> qu_ = context.Operators.Union<MedicationRequest>(qm_, qt_);
            CqlValueSet qv_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> qw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qy_(MedicationRequest MR)
            {
                IEnumerable<Medication> vi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? vj_(Medication M)
                {
                    object vn_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object vo_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> vp_ = context.Operators.Split((string)vo_, "/");
                    string vq_ = context.Operators.Last<string>(vp_);
                    bool? vr_ = context.Operators.Equal(vn_, vq_);
                    CodeableConcept vs_ = M?.Code;
                    CqlConcept vt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vs_);
                    CqlValueSet vu_ = this.Methylphenidate(context);
                    bool? vv_ = context.Operators.ConceptInValueSet(vt_, vu_);
                    bool? vw_ = context.Operators.And(vr_, vv_);

                    return vw_;
                };
                IEnumerable<Medication> vk_ = context.Operators.Where<Medication>(vi_, vj_);
                MedicationRequest vl_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> vm_ = context.Operators.Select<Medication, MedicationRequest>(vk_, vl_);

                return vm_;
            };
            IEnumerable<MedicationRequest> qz_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, qy_);
            IEnumerable<MedicationRequest> ra_ = context.Operators.Union<MedicationRequest>(qw_, qz_);
            IEnumerable<MedicationRequest> rb_ = context.Operators.Union<MedicationRequest>(qu_, ra_);
            CqlValueSet rc_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> rd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> rf_(MedicationRequest MR)
            {
                IEnumerable<Medication> vx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? vy_(Medication M)
                {
                    object wc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object wd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> we_ = context.Operators.Split((string)wd_, "/");
                    string wf_ = context.Operators.Last<string>(we_);
                    bool? wg_ = context.Operators.Equal(wc_, wf_);
                    CodeableConcept wh_ = M?.Code;
                    CqlConcept wi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wh_);
                    CqlValueSet wj_ = this.Guanfacine_Medications(context);
                    bool? wk_ = context.Operators.ConceptInValueSet(wi_, wj_);
                    bool? wl_ = context.Operators.And(wg_, wk_);

                    return wl_;
                };
                IEnumerable<Medication> vz_ = context.Operators.Where<Medication>(vx_, vy_);
                MedicationRequest wa_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> wb_ = context.Operators.Select<Medication, MedicationRequest>(vz_, wa_);

                return wb_;
            };
            IEnumerable<MedicationRequest> rg_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, rf_);
            IEnumerable<MedicationRequest> rh_ = context.Operators.Union<MedicationRequest>(rd_, rg_);
            IEnumerable<MedicationRequest> ri_ = context.Operators.Union<MedicationRequest>(rb_, rh_);
            CqlValueSet rj_ = this.Viloxazine(context);
            IEnumerable<MedicationRequest> rk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> rm_(MedicationRequest MR)
            {
                IEnumerable<Medication> wm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? wn_(Medication M)
                {
                    object wr_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object ws_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> wt_ = context.Operators.Split((string)ws_, "/");
                    string wu_ = context.Operators.Last<string>(wt_);
                    bool? wv_ = context.Operators.Equal(wr_, wu_);
                    CodeableConcept ww_ = M?.Code;
                    CqlConcept wx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ww_);
                    CqlValueSet wy_ = this.Viloxazine(context);
                    bool? wz_ = context.Operators.ConceptInValueSet(wx_, wy_);
                    bool? xa_ = context.Operators.And(wv_, wz_);

                    return xa_;
                };
                IEnumerable<Medication> wo_ = context.Operators.Where<Medication>(wm_, wn_);
                MedicationRequest wp_(Medication M) =>
                MR;
                IEnumerable<MedicationRequest> wq_ = context.Operators.Select<Medication, MedicationRequest>(wo_, wp_);

                return wq_;
            };
            IEnumerable<MedicationRequest> rn_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ph_, rm_);
            IEnumerable<MedicationRequest> ro_ = context.Operators.Union<MedicationRequest>(rk_, rn_);
            IEnumerable<MedicationRequest> rp_ = context.Operators.Union<MedicationRequest>(ri_, ro_);
            IEnumerable<MedicationRequest> rq_ = Status_1_15_000.Instance.isMedicationActive(context, rp_);
            bool? rr_(MedicationRequest ActiveADHDMedication)
            {
                CqlInterval<CqlDate> xb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> xc_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate xd_ = context.Operators.Start(xc_);
                CqlDateTime xe_ = context.Operators.ConvertDateToDateTime(xd_);
                CqlDate xf_ = context.Operators.DateFrom(xe_);
                CqlQuantity xg_ = context.Operators.Quantity(120m, "days");
                CqlDate xh_ = context.Operators.Subtract(xf_, xg_);
                CqlDate xj_ = context.Operators.Start(xc_);
                CqlDateTime xk_ = context.Operators.ConvertDateToDateTime(xj_);
                CqlDate xl_ = context.Operators.DateFrom(xk_);
                CqlInterval<CqlDate> xm_ = context.Operators.Interval(xh_, xl_, true, false);
                bool? xn_ = context.Operators.Overlaps(xb_, xm_, default);

                return xn_;
            };
            IEnumerable<MedicationRequest> rs_ = context.Operators.Where<MedicationRequest>(rq_, rr_);
            MedicationRequest rt_(MedicationRequest ActiveADHDMedication) =>
            ADHDMedicationOrder;
            IEnumerable<MedicationRequest> ru_ = context.Operators.Select<MedicationRequest, MedicationRequest>(rs_, rt_);

            return ru_;
        };
        IEnumerable<MedicationRequest> ed_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(eb_, ec_);
        IEnumerable<MedicationRequest> ee_ = context.Operators.Except<MedicationRequest>(bn_, ed_);
        (CqlTupleMetadata, CqlDate startDate)? ef_(MedicationRequest QualifyingMed)
        {
            CqlInterval<CqlDate> xo_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate xp_ = context.Operators.Start(xo_);
            (CqlTupleMetadata, CqlDate startDate)? xq_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, xp_);

            return xq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> eg_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(ee_, ef_);
        object eh_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate xr_ = @this?.startDate;

            return xr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ei_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(eg_, eh_, System.ComponentModel.ListSortDirection.Ascending);

        return ei_;
    }


    [CqlExpressionDefinition("First ADHD Medication Prescribed During Intake Period")]
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


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate a_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);

        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
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
        IEnumerable<Encounter> l_ = Status_1_15_000.Instance.isEncounterPerformed(context, k_);
        bool? m_(Encounter ValidEncounters)
        {
            CqlDate o_ = this.IPSD(context);
            CqlQuantity p_ = context.Operators.Quantity(6m, "months");
            CqlDate q_ = context.Operators.Subtract(o_, p_);
            CqlInterval<CqlDate> s_ = context.Operators.Interval(q_, o_, true, true);
            Period t_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlInterval<CqlDate> v_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, u_);
            bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(s_, v_, "day");

            return w_;
        };
        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);

        return n_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);
        bool? d_(Encounter InpatientStay)
        {
            CqlValueSet f_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders(context);
            bool? g_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, InpatientStay, f_);

            return g_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? b_(Encounter InpatientStay)
        {
            Period d_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlInterval<CqlDate> f_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, e_);
            CqlDate g_ = context.Operators.Start(f_);
            CqlDate h_ = this.IPSD(context);
            CqlQuantity j_ = context.Operators.Quantity(30m, "days");
            CqlDate k_ = context.Operators.Add(h_, j_);
            CqlInterval<CqlDate> l_ = context.Operators.Interval(h_, k_, false, true);
            bool? m_ = context.Operators.In<CqlDate>(g_, l_, "day");
            bool? o_ = context.Operators.Not((bool?)(h_ is null));
            bool? p_ = context.Operators.And(m_, o_);

            return p_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
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


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? a_ = this.Initial_Population_1(context);

        return a_;
    }


    [CqlExpressionDefinition("Narcolepsy Exclusion")]
    public IEnumerable<object> Narcolepsy_Exclusion(CqlContext context)
    {
        CqlValueSet a_ = this.Narcolepsy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
        bool? g_(object NarcolepsyDx)
        {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NarcolepsyDx);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, default);

            return m_;
        };
        IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> b_ = this.Narcolepsy_Exclusion(context);
        bool? c_ = context.Operators.Exists<object>(b_);
        bool? d_ = context.Operators.Or(a_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Qualifying Numerator Encounter")]
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
                Location aq_ = CQMCommon_4_1_000.Instance.GetLocation(context, ap_);
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


    [CqlExpressionDefinition("Encounter During Initiation Phase")]
    public IEnumerable<Encounter> Encounter_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> b_ = Status_1_15_000.Instance.isEncounterPerformed(context, a_);
        bool? c_(Encounter ValidNumeratorEncounter)
        {
            Period e_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlInterval<CqlDate> g_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, f_);
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
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_During_Initiation_Phase(context);
        bool? b_ = context.Operators.Exists<Encounter>(a_);

        return b_;
    }


    [CqlExpressionDefinition("ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
    public IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet a_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> ez_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? fa_(Medication M)
            {
                object fe_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ff_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fg_ = context.Operators.Split((string)ff_, "/");
                string fh_ = context.Operators.Last<string>(fg_);
                bool? fi_ = context.Operators.Equal(fe_, fh_);
                CodeableConcept fj_ = M?.Code;
                CqlConcept fk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fj_);
                CqlValueSet fl_ = this.Atomoxetine(context);
                bool? fm_ = context.Operators.ConceptInValueSet(fk_, fl_);
                bool? fn_ = context.Operators.And(fi_, fm_);

                return fn_;
            };
            IEnumerable<Medication> fb_ = context.Operators.Where<Medication>(ez_, fa_);
            MedicationRequest fc_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> fd_ = context.Operators.Select<Medication, MedicationRequest>(fb_, fc_);

            return fd_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? h_(MedicationRequest AtomoxetineMed)
        {
            CqlInterval<CqlDate> fo_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate fq_ = context.Operators.Start(fo_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fr_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fo_, fq_);

            return fr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(g_, h_);
        object j_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate fs_ = @this?.periodStart;

            return fs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
        bool? l_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ft_ = @this?.period;
            bool? fu_ = context.Operators.Not((bool?)(ft_ is null));

            return fu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> m_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(k_, l_);
        CqlInterval<CqlDate> n_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fv_ = @this?.period;

            return fv_;
        };
        IEnumerable<CqlInterval<CqlDate>> o_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(m_, n_);
        IEnumerable<CqlInterval<CqlDate>> p_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, o_);
        CqlValueSet q_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> r_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> t_(MedicationRequest MR)
        {
            IEnumerable<Medication> fw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? fx_(Medication M)
            {
                object gb_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gc_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gd_ = context.Operators.Split((string)gc_, "/");
                string ge_ = context.Operators.Last<string>(gd_);
                bool? gf_ = context.Operators.Equal(gb_, ge_);
                CodeableConcept gg_ = M?.Code;
                CqlConcept gh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gg_);
                CqlValueSet gi_ = this.Clonidine(context);
                bool? gj_ = context.Operators.ConceptInValueSet(gh_, gi_);
                bool? gk_ = context.Operators.And(gf_, gj_);

                return gk_;
            };
            IEnumerable<Medication> fy_ = context.Operators.Where<Medication>(fw_, fx_);
            MedicationRequest fz_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> ga_ = context.Operators.Select<Medication, MedicationRequest>(fy_, fz_);

            return ga_;
        };
        IEnumerable<MedicationRequest> u_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, t_);
        IEnumerable<MedicationRequest> v_ = context.Operators.Union<MedicationRequest>(r_, u_);
        IEnumerable<MedicationRequest> w_ = Status_1_15_000.Instance.isMedicationOrder(context, v_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? x_(MedicationRequest ClonidineMed)
        {
            CqlInterval<CqlDate> gl_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate gn_ = context.Operators.Start(gl_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? go_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gl_, gn_);

            return go_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> y_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(w_, x_);
        object z_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate gp_ = @this?.periodStart;

            return gp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> aa_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(y_, z_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ab_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> gq_ = @this?.period;
            bool? gr_ = context.Operators.Not((bool?)(gq_ is null));

            return gr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ac_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(aa_, ab_);
        CqlInterval<CqlDate> ad_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> gs_ = @this?.period;

            return gs_;
        };
        IEnumerable<CqlInterval<CqlDate>> ae_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ac_, ad_);
        IEnumerable<CqlInterval<CqlDate>> af_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ae_);
        IEnumerable<CqlInterval<CqlDate>> ag_ = context.Operators.Union<CqlInterval<CqlDate>>(p_, af_);
        CqlValueSet ah_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ak_(MedicationRequest MR)
        {
            IEnumerable<Medication> gt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? gu_(Medication M)
            {
                object gy_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ha_ = context.Operators.Split((string)gz_, "/");
                string hb_ = context.Operators.Last<string>(ha_);
                bool? hc_ = context.Operators.Equal(gy_, hb_);
                CodeableConcept hd_ = M?.Code;
                CqlConcept he_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hd_);
                CqlValueSet hf_ = this.Dexmethylphenidate(context);
                bool? hg_ = context.Operators.ConceptInValueSet(he_, hf_);
                bool? hh_ = context.Operators.And(hc_, hg_);

                return hh_;
            };
            IEnumerable<Medication> gv_ = context.Operators.Where<Medication>(gt_, gu_);
            MedicationRequest gw_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> gx_ = context.Operators.Select<Medication, MedicationRequest>(gv_, gw_);

            return gx_;
        };
        IEnumerable<MedicationRequest> al_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ak_);
        IEnumerable<MedicationRequest> am_ = context.Operators.Union<MedicationRequest>(ai_, al_);
        IEnumerable<MedicationRequest> an_ = Status_1_15_000.Instance.isMedicationOrder(context, am_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ao_(MedicationRequest DexmethylphenidateMed)
        {
            CqlInterval<CqlDate> hi_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate hk_ = context.Operators.Start(hi_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hl_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, hi_, hk_);

            return hl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ap_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(an_, ao_);
        object aq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate hm_ = @this?.periodStart;

            return hm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ar_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
        bool? as_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> hn_ = @this?.period;
            bool? ho_ = context.Operators.Not((bool?)(hn_ is null));

            return ho_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> at_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ar_, as_);
        CqlInterval<CqlDate> au_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> hp_ = @this?.period;

            return hp_;
        };
        IEnumerable<CqlInterval<CqlDate>> av_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(at_, au_);
        IEnumerable<CqlInterval<CqlDate>> aw_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, av_);
        CqlValueSet ax_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ba_(MedicationRequest MR)
        {
            IEnumerable<Medication> hq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? hr_(Medication M)
            {
                object hv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hx_ = context.Operators.Split((string)hw_, "/");
                string hy_ = context.Operators.Last<string>(hx_);
                bool? hz_ = context.Operators.Equal(hv_, hy_);
                CodeableConcept ia_ = M?.Code;
                CqlConcept ib_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ia_);
                CqlValueSet ic_ = this.Dextroamphetamine(context);
                bool? id_ = context.Operators.ConceptInValueSet(ib_, ic_);
                bool? ie_ = context.Operators.And(hz_, id_);

                return ie_;
            };
            IEnumerable<Medication> hs_ = context.Operators.Where<Medication>(hq_, hr_);
            MedicationRequest ht_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> hu_ = context.Operators.Select<Medication, MedicationRequest>(hs_, ht_);

            return hu_;
        };
        IEnumerable<MedicationRequest> bb_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ay_, bb_);
        IEnumerable<MedicationRequest> bd_ = Status_1_15_000.Instance.isMedicationOrder(context, bc_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? be_(MedicationRequest DextroamphetamineMed)
        {
            CqlInterval<CqlDate> if_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate ih_ = context.Operators.Start(if_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ii_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, if_, ih_);

            return ii_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bf_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bd_, be_);
        object bg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate ij_ = @this?.periodStart;

            return ij_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
        bool? bi_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ik_ = @this?.period;
            bool? il_ = context.Operators.Not((bool?)(ik_ is null));

            return il_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bj_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bh_, bi_);
        CqlInterval<CqlDate> bk_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> im_ = @this?.period;

            return im_;
        };
        IEnumerable<CqlInterval<CqlDate>> bl_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bj_, bk_);
        IEnumerable<CqlInterval<CqlDate>> bm_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, bl_);
        IEnumerable<CqlInterval<CqlDate>> bn_ = context.Operators.Union<CqlInterval<CqlDate>>(aw_, bm_);
        IEnumerable<CqlInterval<CqlDate>> bo_ = context.Operators.Union<CqlInterval<CqlDate>>(ag_, bn_);
        CqlValueSet bp_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> bq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bs_(MedicationRequest MR)
        {
            IEnumerable<Medication> in_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? io_(Medication M)
            {
                object is_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object it_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> iu_ = context.Operators.Split((string)it_, "/");
                string iv_ = context.Operators.Last<string>(iu_);
                bool? iw_ = context.Operators.Equal(is_, iv_);
                CodeableConcept ix_ = M?.Code;
                CqlConcept iy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ix_);
                CqlValueSet iz_ = this.Lisdexamfetamine(context);
                bool? ja_ = context.Operators.ConceptInValueSet(iy_, iz_);
                bool? jb_ = context.Operators.And(iw_, ja_);

                return jb_;
            };
            IEnumerable<Medication> ip_ = context.Operators.Where<Medication>(in_, io_);
            MedicationRequest iq_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> ir_ = context.Operators.Select<Medication, MedicationRequest>(ip_, iq_);

            return ir_;
        };
        IEnumerable<MedicationRequest> bt_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bs_);
        IEnumerable<MedicationRequest> bu_ = context.Operators.Union<MedicationRequest>(bq_, bt_);
        IEnumerable<MedicationRequest> bv_ = Status_1_15_000.Instance.isMedicationOrder(context, bu_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? bw_(MedicationRequest LisdexamfetamineMed)
        {
            CqlInterval<CqlDate> jc_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate je_ = context.Operators.Start(jc_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jf_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jc_, je_);

            return jf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bx_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bv_, bw_);
        object by_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate jg_ = @this?.periodStart;

            return jg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bz_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bx_, by_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ca_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jh_ = @this?.period;
            bool? ji_ = context.Operators.Not((bool?)(jh_ is null));

            return ji_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cb_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bz_, ca_);
        CqlInterval<CqlDate> cc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jj_ = @this?.period;

            return jj_;
        };
        IEnumerable<CqlInterval<CqlDate>> cd_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cb_, cc_);
        IEnumerable<CqlInterval<CqlDate>> ce_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, cd_);
        CqlValueSet cf_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> cg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ci_(MedicationRequest MR)
        {
            IEnumerable<Medication> jk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? jl_(Medication M)
            {
                object jp_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object jq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jr_ = context.Operators.Split((string)jq_, "/");
                string js_ = context.Operators.Last<string>(jr_);
                bool? jt_ = context.Operators.Equal(jp_, js_);
                CodeableConcept ju_ = M?.Code;
                CqlConcept jv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ju_);
                CqlValueSet jw_ = this.Methylphenidate(context);
                bool? jx_ = context.Operators.ConceptInValueSet(jv_, jw_);
                bool? jy_ = context.Operators.And(jt_, jx_);

                return jy_;
            };
            IEnumerable<Medication> jm_ = context.Operators.Where<Medication>(jk_, jl_);
            MedicationRequest jn_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> jo_ = context.Operators.Select<Medication, MedicationRequest>(jm_, jn_);

            return jo_;
        };
        IEnumerable<MedicationRequest> cj_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ci_);
        IEnumerable<MedicationRequest> ck_ = context.Operators.Union<MedicationRequest>(cg_, cj_);
        IEnumerable<MedicationRequest> cl_ = Status_1_15_000.Instance.isMedicationOrder(context, ck_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cm_(MedicationRequest MethylphenidateMed)
        {
            CqlInterval<CqlDate> jz_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate kb_ = context.Operators.Start(jz_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kc_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jz_, kb_);

            return kc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cn_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cl_, cm_);
        object co_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate kd_ = @this?.periodStart;

            return kd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cp_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cn_, co_, System.ComponentModel.ListSortDirection.Ascending);
        bool? cq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ke_ = @this?.period;
            bool? kf_ = context.Operators.Not((bool?)(ke_ is null));

            return kf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cr_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cp_, cq_);
        CqlInterval<CqlDate> cs_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kg_ = @this?.period;

            return kg_;
        };
        IEnumerable<CqlInterval<CqlDate>> ct_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cr_, cs_);
        IEnumerable<CqlInterval<CqlDate>> cu_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ct_);
        IEnumerable<CqlInterval<CqlDate>> cv_ = context.Operators.Union<CqlInterval<CqlDate>>(ce_, cu_);
        IEnumerable<CqlInterval<CqlDate>> cw_ = context.Operators.Union<CqlInterval<CqlDate>>(bo_, cv_);
        CqlValueSet cx_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> cy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> da_(MedicationRequest MR)
        {
            IEnumerable<Medication> kh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ki_(Medication M)
            {
                object km_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ko_ = context.Operators.Split((string)kn_, "/");
                string kp_ = context.Operators.Last<string>(ko_);
                bool? kq_ = context.Operators.Equal(km_, kp_);
                CodeableConcept kr_ = M?.Code;
                CqlConcept ks_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kr_);
                CqlValueSet kt_ = this.Guanfacine_Medications(context);
                bool? ku_ = context.Operators.ConceptInValueSet(ks_, kt_);
                bool? kv_ = context.Operators.And(kq_, ku_);

                return kv_;
            };
            IEnumerable<Medication> kj_ = context.Operators.Where<Medication>(kh_, ki_);
            MedicationRequest kk_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> kl_ = context.Operators.Select<Medication, MedicationRequest>(kj_, kk_);

            return kl_;
        };
        IEnumerable<MedicationRequest> db_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, da_);
        IEnumerable<MedicationRequest> dc_ = context.Operators.Union<MedicationRequest>(cy_, db_);
        IEnumerable<MedicationRequest> dd_ = Status_1_15_000.Instance.isMedicationOrder(context, dc_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? de_(MedicationRequest GuanfacineMed)
        {
            CqlInterval<CqlDate> kw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate ky_ = context.Operators.Start(kw_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kz_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kw_, ky_);

            return kz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> df_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dd_, de_);
        object dg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate la_ = @this?.periodStart;

            return la_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(df_, dg_, System.ComponentModel.ListSortDirection.Ascending);
        bool? di_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lb_ = @this?.period;
            bool? lc_ = context.Operators.Not((bool?)(lb_ is null));

            return lc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dj_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dh_, di_);
        CqlInterval<CqlDate> dk_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ld_ = @this?.period;

            return ld_;
        };
        IEnumerable<CqlInterval<CqlDate>> dl_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dj_, dk_);
        IEnumerable<CqlInterval<CqlDate>> dm_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, dl_);
        CqlCode dn_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> do_ = context.Operators.ToList<CqlCode>(dn_);
        IEnumerable<MedicationRequest> dp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, do_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dr_(MedicationRequest MR)
        {
            IEnumerable<Medication> le_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? lf_(Medication M)
            {
                object lj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ll_ = context.Operators.Split((string)lk_, "/");
                string lm_ = context.Operators.Last<string>(ll_);
                bool? ln_ = context.Operators.Equal(lj_, lm_);
                CodeableConcept lo_ = M?.Code;
                CqlConcept lp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lo_);
                CqlCode lq_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept lr_ = context.Operators.ConvertCodeToConcept(lq_);
                bool? ls_ = context.Operators.Equivalent(lp_, lr_);
                bool? lt_ = context.Operators.And(ln_, ls_);

                return lt_;
            };
            IEnumerable<Medication> lg_ = context.Operators.Where<Medication>(le_, lf_);
            MedicationRequest lh_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> li_ = context.Operators.Select<Medication, MedicationRequest>(lg_, lh_);

            return li_;
        };
        IEnumerable<MedicationRequest> ds_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, dr_);
        IEnumerable<MedicationRequest> dt_ = context.Operators.Union<MedicationRequest>(dp_, ds_);
        IEnumerable<MedicationRequest> du_ = Status_1_15_000.Instance.isMedicationOrder(context, dt_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dv_(MedicationRequest MethamphetamineMed)
        {
            CqlInterval<CqlDate> lu_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate lw_ = context.Operators.Start(lu_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lx_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, lu_, lw_);

            return lx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dw_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(du_, dv_);
        object dx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate ly_ = @this?.periodStart;

            return ly_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dy_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dw_, dx_, System.ComponentModel.ListSortDirection.Ascending);
        bool? dz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lz_ = @this?.period;
            bool? ma_ = context.Operators.Not((bool?)(lz_ is null));

            return ma_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ea_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dy_, dz_);
        CqlInterval<CqlDate> eb_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mb_ = @this?.period;

            return mb_;
        };
        IEnumerable<CqlInterval<CqlDate>> ec_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ea_, eb_);
        IEnumerable<CqlInterval<CqlDate>> ed_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ec_);
        IEnumerable<CqlInterval<CqlDate>> ee_ = context.Operators.Union<CqlInterval<CqlDate>>(dm_, ed_);
        IEnumerable<CqlInterval<CqlDate>> ef_ = context.Operators.Union<CqlInterval<CqlDate>>(cw_, ee_);
        CqlValueSet eg_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> eh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, eg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ej_(MedicationRequest MR)
        {
            IEnumerable<Medication> mc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? md_(Medication M)
            {
                object mh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> mj_ = context.Operators.Split((string)mi_, "/");
                string mk_ = context.Operators.Last<string>(mj_);
                bool? ml_ = context.Operators.Equal(mh_, mk_);
                CodeableConcept mm_ = M?.Code;
                CqlConcept mn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mm_);
                CqlValueSet mo_ = this.Viloxazine(context);
                bool? mp_ = context.Operators.ConceptInValueSet(mn_, mo_);
                bool? mq_ = context.Operators.And(ml_, mp_);

                return mq_;
            };
            IEnumerable<Medication> me_ = context.Operators.Where<Medication>(mc_, md_);
            MedicationRequest mf_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> mg_ = context.Operators.Select<Medication, MedicationRequest>(me_, mf_);

            return mg_;
        };
        IEnumerable<MedicationRequest> ek_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ej_);
        IEnumerable<MedicationRequest> el_ = context.Operators.Union<MedicationRequest>(eh_, ek_);
        IEnumerable<MedicationRequest> em_ = Status_1_15_000.Instance.isMedicationOrder(context, el_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? en_(MedicationRequest ViloxazineMed)
        {
            CqlInterval<CqlDate> mr_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ViloxazineMed);
            CqlDate mt_ = context.Operators.Start(mr_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? mu_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, mr_, mt_);

            return mu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> eo_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(em_, en_);
        object ep_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate mv_ = @this?.periodStart;

            return mv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> eq_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(eo_, ep_, System.ComponentModel.ListSortDirection.Ascending);
        bool? er_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mw_ = @this?.period;
            bool? mx_ = context.Operators.Not((bool?)(mw_ is null));

            return mx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> es_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(eq_, er_);
        CqlInterval<CqlDate> et_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> my_ = @this?.period;

            return my_;
        };
        IEnumerable<CqlInterval<CqlDate>> eu_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(es_, et_);
        IEnumerable<CqlInterval<CqlDate>> ev_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, eu_);
        IEnumerable<CqlInterval<CqlDate>> ew_ = context.Operators.Union<CqlInterval<CqlDate>>(ef_, ev_);
        CqlInterval<CqlDate> ex_(CqlInterval<CqlDate> ADHDMedication)
        {
            CqlDate mz_ = this.IPSD(context);
            CqlQuantity nb_ = context.Operators.Quantity(300m, "days");
            CqlDate nc_ = context.Operators.Add(mz_, nb_);
            CqlInterval<CqlDate> nd_ = context.Operators.Interval(mz_, nc_, true, true);
            CqlInterval<CqlDate> ne_ = context.Operators.Intersect<CqlDate>(ADHDMedication, nd_);

            return ne_;
        };
        IEnumerable<CqlInterval<CqlDate>> ey_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(ew_, ex_);

        return ey_;
    }


    [CqlExpressionDefinition("ADHD Cumulative Medication Duration")]
    public int? ADHD_Cumulative_Medication_Duration(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
        int? b_ = CumulativeMedicationDuration_6_0_000.Instance.cumulativeDuration(context, a_);

        return b_;
    }


    [CqlExpressionDefinition("Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days")]
    public bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(CqlContext context)
    {
        int? a_ = this.ADHD_Cumulative_Medication_Duration(context);
        bool? b_ = context.Operators.GreaterOrEqual(a_, 210);

        return b_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? b_(Encounter InpatientStay)
        {
            Period d_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlInterval<CqlDate> f_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, e_);
            CqlDate g_ = context.Operators.Start(f_);
            CqlDate h_ = this.IPSD(context);
            CqlQuantity j_ = context.Operators.Quantity(300m, "days");
            CqlDate k_ = context.Operators.Add(h_, j_);
            CqlInterval<CqlDate> l_ = context.Operators.Interval(h_, k_, false, true);
            bool? m_ = context.Operators.In<CqlDate>(g_, l_, "day");
            bool? o_ = context.Operators.Not((bool?)(h_ is null));
            bool? p_ = context.Operators.And(m_, o_);

            return p_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
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


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? a_ = this.Initial_Population_2(context);

        return a_;
    }


    [CqlExpressionDefinition("Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> b_ = Status_1_15_000.Instance.isEncounterPerformed(context, a_);
        bool? c_(Encounter ValidNumeratorEncounter)
        {
            Period h_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlInterval<CqlDate> j_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, i_);
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
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);

        return g_;
    }


    [CqlExpressionDefinition("Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
    public bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        int? b_ = context.Operators.Count<CqlDate>(a_);
        bool? c_ = context.Operators.GreaterOrEqual(b_, 2);

        return c_;
    }


    [CqlExpressionDefinition("Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet a_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);
        bool? d_(Encounter VirtualEnc)
        {
            Period i_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlInterval<CqlDate> k_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, j_);
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
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Numerator 2")]
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


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW = new(
      [typeof(CqlDate)],
      ["startDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD = new(
      [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
      ["period", "periodStart"]);

    #endregion CqlTupleMetadata Properties

}
