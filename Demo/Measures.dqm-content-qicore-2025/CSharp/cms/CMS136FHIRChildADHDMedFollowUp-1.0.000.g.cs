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
[CqlLibrary("CMS136FHIRChildADHDMedFollowUp", "1.0.000")]
public partial class CMS136FHIRChildADHDMedFollowUp_1_0_000 : ILibrary, ISingleton<CMS136FHIRChildADHDMedFollowUp_1_0_000>
{
    #region ValueSets (25)

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

    #region Codes (1)

    [CqlCodeDefinition("methamphetamine hydrochloride 5 MG Oral Tablet", codeId: "977860", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet(CqlContext _) => _methamphetamine_hydrochloride_5_MG_Oral_Tablet;
    private static readonly CqlCode _methamphetamine_hydrochloride_5_MG_Oral_Tablet = new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("RXNORM", codeSystemId: "http://www.nlm.nih.gov/research/umls/rxnorm", codeSystemVersion: null)]
    public CqlCodeSystem RXNORM(CqlContext _) => _RXNORM;
    private static readonly CqlCodeSystem _RXNORM =
      new CqlCodeSystem("http://www.nlm.nih.gov/research/umls/rxnorm", null, [
          _methamphetamine_hydrochloride_5_MG_Oral_Tablet]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 4855730798156578906L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS136FHIRChildADHDMedFollowUp-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (31)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4641227550436577792L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("March 1 of Year Prior to Measurement Period")]
    public CqlDateTime March_1_of_Year_Prior_to_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_March_1_of_Year_Prior_to_Measurement_Period, March_1_of_Year_Prior_to_Measurement_Period_Compute);

    private const long _cacheIndex_March_1_of_Year_Prior_to_Measurement_Period = 3709971840043392196L;

    private CqlDateTime March_1_of_Year_Prior_to_Measurement_Period_Compute(CqlContext context)
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
    public CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Last_Calendar_Day_of_February_of_Measurement_Period, Last_Calendar_Day_of_February_of_Measurement_Period_Compute);

    private const long _cacheIndex_Last_Calendar_Day_of_February_of_Measurement_Period = -4226591970914106183L;

    private CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period_Compute(CqlContext context)
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
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intake_Period, Intake_Period_Compute);

    private const long _cacheIndex_Intake_Period = -706599413819521966L;

    private CqlInterval<CqlDateTime> Intake_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = this.March_1_of_Year_Prior_to_Measurement_Period(context);
        CqlDateTime b_ = this.Last_Calendar_Day_of_February_of_Measurement_Period(context);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        return c_;
    }


    [CqlExpressionDefinition("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
    public IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication, ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication_Compute);

    private const long _cacheIndex_ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication = 3223880368776900477L;

    private IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> bm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bn_(Medication M) {
                object bq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object br_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bs_ = context.Operators.Split((string)br_, "/");
                string bt_ = context.Operators.Last<string>(bs_);
                bool? bu_ = context.Operators.Equal(bq_, bt_);
                CodeableConcept bv_ = M?.Code;
                CqlConcept bw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bv_);
                CqlValueSet bx_ = this.Atomoxetine(context);
                bool? by_ = context.Operators.ConceptInValueSet(bw_, bx_);
                bool? bz_ = context.Operators.And(bu_, by_);
                return bz_;
            }

            IEnumerable<Medication> bo_ = context.Operators.Where<Medication>(bm_, bn_);
            bool? bp_ = context.Operators.Exists<Medication>(bo_);
            return bp_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ca_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cb_(Medication M) {
                object ce_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cg_ = context.Operators.Split((string)cf_, "/");
                string ch_ = context.Operators.Last<string>(cg_);
                bool? ci_ = context.Operators.Equal(ce_, ch_);
                CodeableConcept cj_ = M?.Code;
                CqlConcept ck_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cj_);
                CqlValueSet cl_ = this.Clonidine(context);
                bool? cm_ = context.Operators.ConceptInValueSet(ck_, cl_);
                bool? cn_ = context.Operators.And(ci_, cm_);
                return cn_;
            }

            IEnumerable<Medication> cc_ = context.Operators.Where<Medication>(ca_, cb_);
            bool? cd_ = context.Operators.Exists<Medication>(cc_);
            return cd_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> co_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cp_(Medication M) {
                object cs_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ct_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cu_ = context.Operators.Split((string)ct_, "/");
                string cv_ = context.Operators.Last<string>(cu_);
                bool? cw_ = context.Operators.Equal(cs_, cv_);
                CodeableConcept cx_ = M?.Code;
                CqlConcept cy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cx_);
                CqlValueSet cz_ = this.Dexmethylphenidate(context);
                bool? da_ = context.Operators.ConceptInValueSet(cy_, cz_);
                bool? db_ = context.Operators.And(cw_, da_);
                return db_;
            }

            IEnumerable<Medication> cq_ = context.Operators.Where<Medication>(co_, cp_);
            bool? cr_ = context.Operators.Exists<Medication>(cq_);
            return cr_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(a_, m_);
        CqlValueSet o_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest MR) {
            IEnumerable<Medication> dc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dd_(Medication M) {
                object dg_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dh_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> di_ = context.Operators.Split((string)dh_, "/");
                string dj_ = context.Operators.Last<string>(di_);
                bool? dk_ = context.Operators.Equal(dg_, dj_);
                CodeableConcept dl_ = M?.Code;
                CqlConcept dm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dl_);
                CqlValueSet dn_ = this.Dextroamphetamine(context);
                bool? do_ = context.Operators.ConceptInValueSet(dm_, dn_);
                bool? dp_ = context.Operators.And(dk_, do_);
                return dp_;
            }

            IEnumerable<Medication> de_ = context.Operators.Where<Medication>(dc_, dd_);
            bool? df_ = context.Operators.Exists<Medication>(de_);
            return df_;
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(a_, s_);
        CqlValueSet u_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> w_ = context.Operators.Union<MedicationRequest>(t_, v_);
        IEnumerable<MedicationRequest> x_ = context.Operators.Union<MedicationRequest>(r_, w_);

        bool? y_(MedicationRequest MR) {
            IEnumerable<Medication> dq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dr_(Medication M) {
                object du_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dw_ = context.Operators.Split((string)dv_, "/");
                string dx_ = context.Operators.Last<string>(dw_);
                bool? dy_ = context.Operators.Equal(du_, dx_);
                CodeableConcept dz_ = M?.Code;
                CqlConcept ea_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dz_);
                CqlValueSet eb_ = this.Lisdexamfetamine(context);
                bool? ec_ = context.Operators.ConceptInValueSet(ea_, eb_);
                bool? ed_ = context.Operators.And(dy_, ec_);
                return ed_;
            }

            IEnumerable<Medication> ds_ = context.Operators.Where<Medication>(dq_, dr_);
            bool? dt_ = context.Operators.Exists<Medication>(ds_);
            return dt_;
        }

        IEnumerable<MedicationRequest> z_ = context.Operators.Where<MedicationRequest>(a_, y_);
        CqlValueSet aa_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(z_, ab_);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(x_, ac_);

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> ee_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ef_(Medication M) {
                object ei_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ej_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ek_ = context.Operators.Split((string)ej_, "/");
                string el_ = context.Operators.Last<string>(ek_);
                bool? em_ = context.Operators.Equal(ei_, el_);
                CodeableConcept en_ = M?.Code;
                CqlConcept eo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, en_);
                CqlCode ep_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept eq_ = context.Operators.ConvertCodeToConcept(ep_);
                bool? er_ = context.Operators.Equivalent(eo_, eq_);
                bool? es_ = context.Operators.And(em_, er_);
                return es_;
            }

            IEnumerable<Medication> eg_ = context.Operators.Where<Medication>(ee_, ef_);
            bool? eh_ = context.Operators.Exists<Medication>(eg_);
            return eh_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(a_, ae_);
        CqlCode ag_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(af_, ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ad_, aj_);

        bool? al_(MedicationRequest MR) {
            IEnumerable<Medication> et_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? eu_(Medication M) {
                object ex_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ey_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ez_ = context.Operators.Split((string)ey_, "/");
                string fa_ = context.Operators.Last<string>(ez_);
                bool? fb_ = context.Operators.Equal(ex_, fa_);
                CodeableConcept fc_ = M?.Code;
                CqlConcept fd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fc_);
                CqlValueSet fe_ = this.Methylphenidate(context);
                bool? ff_ = context.Operators.ConceptInValueSet(fd_, fe_);
                bool? fg_ = context.Operators.And(fb_, ff_);
                return fg_;
            }

            IEnumerable<Medication> ev_ = context.Operators.Where<Medication>(et_, eu_);
            bool? ew_ = context.Operators.Exists<Medication>(ev_);
            return ew_;
        }

        IEnumerable<MedicationRequest> am_ = context.Operators.Where<MedicationRequest>(a_, al_);
        CqlValueSet an_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Union<MedicationRequest>(ak_, ap_);

        bool? ar_(MedicationRequest MR) {
            IEnumerable<Medication> fh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fi_(Medication M) {
                object fl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fn_ = context.Operators.Split((string)fm_, "/");
                string fo_ = context.Operators.Last<string>(fn_);
                bool? fp_ = context.Operators.Equal(fl_, fo_);
                CodeableConcept fq_ = M?.Code;
                CqlConcept fr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fq_);
                CqlValueSet fs_ = this.Guanfacine_Medications(context);
                bool? ft_ = context.Operators.ConceptInValueSet(fr_, fs_);
                bool? fu_ = context.Operators.And(fp_, ft_);
                return fu_;
            }

            IEnumerable<Medication> fj_ = context.Operators.Where<Medication>(fh_, fi_);
            bool? fk_ = context.Operators.Exists<Medication>(fj_);
            return fk_;
        }

        IEnumerable<MedicationRequest> as_ = context.Operators.Where<MedicationRequest>(a_, ar_);
        CqlValueSet at_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(aq_, av_);

        bool? ax_(MedicationRequest MR) {
            IEnumerable<Medication> fv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fw_(Medication M) {
                object fz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ga_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gb_ = context.Operators.Split((string)ga_, "/");
                string gc_ = context.Operators.Last<string>(gb_);
                bool? gd_ = context.Operators.Equal(fz_, gc_);
                CodeableConcept ge_ = M?.Code;
                CqlConcept gf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ge_);
                CqlValueSet gg_ = this.Viloxazine(context);
                bool? gh_ = context.Operators.ConceptInValueSet(gf_, gg_);
                bool? gi_ = context.Operators.And(gd_, gh_);
                return gi_;
            }

            IEnumerable<Medication> fx_ = context.Operators.Where<Medication>(fv_, fw_);
            bool? fy_ = context.Operators.Exists<Medication>(fx_);
            return fy_;
        }

        IEnumerable<MedicationRequest> ay_ = context.Operators.Where<MedicationRequest>(a_, ax_);
        CqlValueSet az_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, az_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(ay_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(aw_, bb_);
        IEnumerable<MedicationRequest> bd_ = Status_1_15_000.Instance.isMedicationOrder(context, bc_);

        bool? be_(MedicationRequest ADHDMedications) {
            CqlInterval<CqlDate> gj_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate gk_ = context.Operators.Start(gj_);
            CqlDateTime gl_ = context.Operators.ConvertDateToDateTime(gk_);
            CqlInterval<CqlDateTime> gm_ = this.Intake_Period(context);
            bool? gn_ = context.Operators.In<CqlDateTime>(gl_, gm_, (string)default);
            return gn_;
        }

        IEnumerable<MedicationRequest> bf_ = context.Operators.Where<MedicationRequest>(bd_, be_);

        bool? bg_(MedicationRequest ADHDMedicationOrder) {
            IEnumerable<MedicationRequest> go_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? gp_(MedicationRequest MR) {
                IEnumerable<Medication> iw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ix_(Medication M) {
                    object ja_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object jb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> jc_ = context.Operators.Split((string)jb_, "/");
                    string jd_ = context.Operators.Last<string>(jc_);
                    bool? je_ = context.Operators.Equal(ja_, jd_);
                    CodeableConcept jf_ = M?.Code;
                    CqlConcept jg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jf_);
                    CqlValueSet jh_ = this.Atomoxetine(context);
                    bool? ji_ = context.Operators.ConceptInValueSet(jg_, jh_);
                    bool? jj_ = context.Operators.And(je_, ji_);
                    return jj_;
                }

                IEnumerable<Medication> iy_ = context.Operators.Where<Medication>(iw_, ix_);
                bool? iz_ = context.Operators.Exists<Medication>(iy_);
                return iz_;
            }

            IEnumerable<MedicationRequest> gq_ = context.Operators.Where<MedicationRequest>(go_, gp_);
            CqlValueSet gr_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> gs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gt_ = context.Operators.Union<MedicationRequest>(gq_, gs_);

            bool? gu_(MedicationRequest MR) {
                IEnumerable<Medication> jk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? jl_(Medication M) {
                    object jo_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object jp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> jq_ = context.Operators.Split((string)jp_, "/");
                    string jr_ = context.Operators.Last<string>(jq_);
                    bool? js_ = context.Operators.Equal(jo_, jr_);
                    CodeableConcept jt_ = M?.Code;
                    CqlConcept ju_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jt_);
                    CqlValueSet jv_ = this.Clonidine(context);
                    bool? jw_ = context.Operators.ConceptInValueSet(ju_, jv_);
                    bool? jx_ = context.Operators.And(js_, jw_);
                    return jx_;
                }

                IEnumerable<Medication> jm_ = context.Operators.Where<Medication>(jk_, jl_);
                bool? jn_ = context.Operators.Exists<Medication>(jm_);
                return jn_;
            }

            IEnumerable<MedicationRequest> gv_ = context.Operators.Where<MedicationRequest>(go_, gu_);
            CqlValueSet gw_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> gx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gy_ = context.Operators.Union<MedicationRequest>(gv_, gx_);
            IEnumerable<MedicationRequest> gz_ = context.Operators.Union<MedicationRequest>(gt_, gy_);

            bool? ha_(MedicationRequest MR) {
                IEnumerable<Medication> jy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? jz_(Medication M) {
                    object kc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object kd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> ke_ = context.Operators.Split((string)kd_, "/");
                    string kf_ = context.Operators.Last<string>(ke_);
                    bool? kg_ = context.Operators.Equal(kc_, kf_);
                    CodeableConcept kh_ = M?.Code;
                    CqlConcept ki_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kh_);
                    CqlValueSet kj_ = this.Dexmethylphenidate(context);
                    bool? kk_ = context.Operators.ConceptInValueSet(ki_, kj_);
                    bool? kl_ = context.Operators.And(kg_, kk_);
                    return kl_;
                }

                IEnumerable<Medication> ka_ = context.Operators.Where<Medication>(jy_, jz_);
                bool? kb_ = context.Operators.Exists<Medication>(ka_);
                return kb_;
            }

            IEnumerable<MedicationRequest> hb_ = context.Operators.Where<MedicationRequest>(go_, ha_);
            CqlValueSet hc_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> hd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> he_ = context.Operators.Union<MedicationRequest>(hb_, hd_);
            IEnumerable<MedicationRequest> hf_ = context.Operators.Union<MedicationRequest>(gz_, he_);

            bool? hg_(MedicationRequest MR) {
                IEnumerable<Medication> km_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? kn_(Medication M) {
                    object kq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object kr_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> ks_ = context.Operators.Split((string)kr_, "/");
                    string kt_ = context.Operators.Last<string>(ks_);
                    bool? ku_ = context.Operators.Equal(kq_, kt_);
                    CodeableConcept kv_ = M?.Code;
                    CqlConcept kw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kv_);
                    CqlValueSet kx_ = this.Dextroamphetamine(context);
                    bool? ky_ = context.Operators.ConceptInValueSet(kw_, kx_);
                    bool? kz_ = context.Operators.And(ku_, ky_);
                    return kz_;
                }

                IEnumerable<Medication> ko_ = context.Operators.Where<Medication>(km_, kn_);
                bool? kp_ = context.Operators.Exists<Medication>(ko_);
                return kp_;
            }

            IEnumerable<MedicationRequest> hh_ = context.Operators.Where<MedicationRequest>(go_, hg_);
            CqlValueSet hi_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> hj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hk_ = context.Operators.Union<MedicationRequest>(hh_, hj_);
            IEnumerable<MedicationRequest> hl_ = context.Operators.Union<MedicationRequest>(hf_, hk_);

            bool? hm_(MedicationRequest MR) {
                IEnumerable<Medication> la_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? lb_(Medication M) {
                    object le_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object lf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> lg_ = context.Operators.Split((string)lf_, "/");
                    string lh_ = context.Operators.Last<string>(lg_);
                    bool? li_ = context.Operators.Equal(le_, lh_);
                    CodeableConcept lj_ = M?.Code;
                    CqlConcept lk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lj_);
                    CqlValueSet ll_ = this.Lisdexamfetamine(context);
                    bool? lm_ = context.Operators.ConceptInValueSet(lk_, ll_);
                    bool? ln_ = context.Operators.And(li_, lm_);
                    return ln_;
                }

                IEnumerable<Medication> lc_ = context.Operators.Where<Medication>(la_, lb_);
                bool? ld_ = context.Operators.Exists<Medication>(lc_);
                return ld_;
            }

            IEnumerable<MedicationRequest> hn_ = context.Operators.Where<MedicationRequest>(go_, hm_);
            CqlValueSet ho_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> hp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ho_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hq_ = context.Operators.Union<MedicationRequest>(hn_, hp_);
            IEnumerable<MedicationRequest> hr_ = context.Operators.Union<MedicationRequest>(hl_, hq_);

            bool? hs_(MedicationRequest MR) {
                IEnumerable<Medication> lo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? lp_(Medication M) {
                    object ls_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object lt_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> lu_ = context.Operators.Split((string)lt_, "/");
                    string lv_ = context.Operators.Last<string>(lu_);
                    bool? lw_ = context.Operators.Equal(ls_, lv_);
                    CodeableConcept lx_ = M?.Code;
                    CqlConcept ly_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lx_);
                    CqlCode lz_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                    CqlConcept ma_ = context.Operators.ConvertCodeToConcept(lz_);
                    bool? mb_ = context.Operators.Equivalent(ly_, ma_);
                    bool? mc_ = context.Operators.And(lw_, mb_);
                    return mc_;
                }

                IEnumerable<Medication> lq_ = context.Operators.Where<Medication>(lo_, lp_);
                bool? lr_ = context.Operators.Exists<Medication>(lq_);
                return lr_;
            }

            IEnumerable<MedicationRequest> ht_ = context.Operators.Where<MedicationRequest>(go_, hs_);
            CqlCode hu_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> hv_ = context.Operators.ToList<CqlCode>(hu_);
            IEnumerable<MedicationRequest> hw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, hv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hx_ = context.Operators.Union<MedicationRequest>(ht_, hw_);
            IEnumerable<MedicationRequest> hy_ = context.Operators.Union<MedicationRequest>(hr_, hx_);

            bool? hz_(MedicationRequest MR) {
                IEnumerable<Medication> md_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? me_(Medication M) {
                    object mh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object mi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> mj_ = context.Operators.Split((string)mi_, "/");
                    string mk_ = context.Operators.Last<string>(mj_);
                    bool? ml_ = context.Operators.Equal(mh_, mk_);
                    CodeableConcept mm_ = M?.Code;
                    CqlConcept mn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mm_);
                    CqlValueSet mo_ = this.Methylphenidate(context);
                    bool? mp_ = context.Operators.ConceptInValueSet(mn_, mo_);
                    bool? mq_ = context.Operators.And(ml_, mp_);
                    return mq_;
                }

                IEnumerable<Medication> mf_ = context.Operators.Where<Medication>(md_, me_);
                bool? mg_ = context.Operators.Exists<Medication>(mf_);
                return mg_;
            }

            IEnumerable<MedicationRequest> ia_ = context.Operators.Where<MedicationRequest>(go_, hz_);
            CqlValueSet ib_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> ic_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ib_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> id_ = context.Operators.Union<MedicationRequest>(ia_, ic_);
            IEnumerable<MedicationRequest> ie_ = context.Operators.Union<MedicationRequest>(hy_, id_);

            bool? if_(MedicationRequest MR) {
                IEnumerable<Medication> mr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ms_(Medication M) {
                    object mv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object mw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> mx_ = context.Operators.Split((string)mw_, "/");
                    string my_ = context.Operators.Last<string>(mx_);
                    bool? mz_ = context.Operators.Equal(mv_, my_);
                    CodeableConcept na_ = M?.Code;
                    CqlConcept nb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, na_);
                    CqlValueSet nc_ = this.Guanfacine_Medications(context);
                    bool? nd_ = context.Operators.ConceptInValueSet(nb_, nc_);
                    bool? ne_ = context.Operators.And(mz_, nd_);
                    return ne_;
                }

                IEnumerable<Medication> mt_ = context.Operators.Where<Medication>(mr_, ms_);
                bool? mu_ = context.Operators.Exists<Medication>(mt_);
                return mu_;
            }

            IEnumerable<MedicationRequest> ig_ = context.Operators.Where<MedicationRequest>(go_, if_);
            CqlValueSet ih_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> ii_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ih_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ij_ = context.Operators.Union<MedicationRequest>(ig_, ii_);
            IEnumerable<MedicationRequest> ik_ = context.Operators.Union<MedicationRequest>(ie_, ij_);

            bool? il_(MedicationRequest MR) {
                IEnumerable<Medication> nf_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ng_(Medication M) {
                    object nj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object nk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> nl_ = context.Operators.Split((string)nk_, "/");
                    string nm_ = context.Operators.Last<string>(nl_);
                    bool? nn_ = context.Operators.Equal(nj_, nm_);
                    CodeableConcept no_ = M?.Code;
                    CqlConcept np_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, no_);
                    CqlValueSet nq_ = this.Viloxazine(context);
                    bool? nr_ = context.Operators.ConceptInValueSet(np_, nq_);
                    bool? ns_ = context.Operators.And(nn_, nr_);
                    return ns_;
                }

                IEnumerable<Medication> nh_ = context.Operators.Where<Medication>(nf_, ng_);
                bool? ni_ = context.Operators.Exists<Medication>(nh_);
                return ni_;
            }

            IEnumerable<MedicationRequest> im_ = context.Operators.Where<MedicationRequest>(go_, il_);
            CqlValueSet in_ = this.Viloxazine(context);
            IEnumerable<MedicationRequest> io_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, in_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ip_ = context.Operators.Union<MedicationRequest>(im_, io_);
            IEnumerable<MedicationRequest> iq_ = context.Operators.Union<MedicationRequest>(ik_, ip_);
            IEnumerable<MedicationRequest> ir_ = Status_1_15_000.Instance.isMedicationActive(context, iq_);

            bool? is_(MedicationRequest ActiveADHDMedication) {
                CqlInterval<CqlDate> nt_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> nu_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate nv_ = context.Operators.Start(nu_);
                CqlDateTime nw_ = context.Operators.ConvertDateToDateTime(nv_);
                CqlDate nx_ = context.Operators.DateFrom(nw_);
                CqlQuantity ny_ = context.Operators.Quantity(120m, "days");
                CqlDate nz_ = context.Operators.Subtract(nx_, ny_);
                CqlInterval<CqlDate> oa_ = context.Operators.Interval(nz_, nx_, true, false);
                bool? ob_ = context.Operators.Overlaps(nt_, oa_, (string)default);
                return ob_;
            }

            IEnumerable<MedicationRequest> it_ = context.Operators.Where<MedicationRequest>(ir_, is_);
            bool? iu_ = context.Operators.Exists<MedicationRequest>(it_);
            bool? iv_ = context.Operators.Not(iu_);
            return iv_;
        }

        IEnumerable<MedicationRequest> bh_ = context.Operators.Where<MedicationRequest>(bf_, bg_);

        (CqlTupleMetadata, CqlDate startDate)? bi_(MedicationRequest QualifyingMed) {
            CqlInterval<CqlDate> oc_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate od_ = context.Operators.Start(oc_);
            (CqlTupleMetadata, CqlDate startDate)? oe_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, od_);
            return oe_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> bj_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(bh_, bi_);

        object bk_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate of_ = @this?.startDate;
            return of_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> bl_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(bj_, bk_, System.ComponentModel.ListSortDirection.Ascending);
        return bl_;
    }


    [CqlExpressionDefinition("First ADHD Medication Prescribed During Intake Period")]
    public CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_ADHD_Medication_Prescribed_During_Intake_Period, First_ADHD_Medication_Prescribed_During_Intake_Period_Compute);

    private const long _cacheIndex_First_ADHD_Medication_Prescribed_During_Intake_Period = -4639298654653847318L;

    private CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> a_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(context);

        bool? b_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate g_ = @this?.startDate;
            bool? h_ = context.Operators.Not((bool?)(g_ is null));
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> c_ = context.Operators.Where<(CqlTupleMetadata, CqlDate startDate)?>(a_, b_);

        CqlDate d_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate i_ = @this?.startDate;
            return i_;
        }

        IEnumerable<CqlDate> e_ = context.Operators.Select<(CqlTupleMetadata, CqlDate startDate)?, CqlDate>(c_, d_);
        CqlDate f_ = context.Operators.First<CqlDate>(e_);
        return f_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IPSD, IPSD_Compute);

    private const long _cacheIndex_IPSD = 2995733269230836253L;

    private CqlDate IPSD_Compute(CqlContext context)
    {
        CqlDate a_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = -1279258466511628036L;

    private IEnumerable<Encounter> Qualifying_Encounter_Compute(CqlContext context)
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

        bool? m_(Encounter ValidEncounters) {
            CqlDate o_ = this.IPSD(context);
            CqlQuantity p_ = context.Operators.Quantity(6m, "months");
            CqlDate q_ = context.Operators.Subtract(o_, p_);
            CqlInterval<CqlDate> r_ = context.Operators.Interval(q_, o_, true, true);
            Period s_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlInterval<CqlDate> u_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, t_);
            bool? v_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, u_, "day");
            return v_;
        }

        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis, Inpatient_Stay_with_Qualifying_Diagnosis_Compute);

    private const long _cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis = 7411720648034793077L;

    private IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

        bool? d_(Encounter InpatientStay) {
            CqlValueSet f_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders(context);
            bool? g_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, InpatientStay, f_);
            return g_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase, Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase_Compute);

    private const long _cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase = -8156220072775179379L;

    private IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);

        bool? b_(Encounter InpatientStay) {
            Period d_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlInterval<CqlDate> f_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, e_);
            CqlDate g_ = context.Operators.Start(f_);
            CqlDate h_ = this.IPSD(context);
            CqlQuantity i_ = context.Operators.Quantity(30m, "days");
            CqlDate j_ = context.Operators.Add(h_, i_);
            CqlInterval<CqlDate> k_ = context.Operators.Interval(h_, j_, false, true);
            bool? l_ = context.Operators.In<CqlDate>(g_, k_, "day");
            bool? m_ = context.Operators.Not((bool?)(h_ is null));
            bool? n_ = context.Operators.And(l_, m_);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_1, Initial_Population_1_Compute);

    private const long _cacheIndex_Initial_Population_1 = -1620489078424121883L;

    private bool? Initial_Population_1_Compute(CqlContext context)
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
        CqlDateTime j_ = context.Operators.End(e_);
        CqlDate k_ = context.Operators.DateFrom(j_);
        int? l_ = context.Operators.CalculateAgeAt(d_, k_, "year");
        bool? m_ = context.Operators.LessOrEqual(l_, 12);
        bool? n_ = context.Operators.And(i_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounter(context);
        bool? p_ = context.Operators.Exists<Encounter>(o_);
        bool? q_ = context.Operators.And(n_, p_);
        CqlDate r_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? s_ = context.Operators.Not((bool?)(r_ is null));
        bool? t_ = context.Operators.And(q_, s_);
        IEnumerable<Encounter> u_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(context);
        bool? v_ = context.Operators.Exists<Encounter>(u_);
        bool? w_ = context.Operators.Not(v_);
        bool? x_ = context.Operators.And(t_, w_);
        return x_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_1, Denominator_1_Compute);

    private const long _cacheIndex_Denominator_1 = -8386680003894831035L;

    private bool? Denominator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_1(context);
        return a_;
    }


    [CqlExpressionDefinition("Narcolepsy Exclusion")]
    public IEnumerable<Condition> Narcolepsy_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Narcolepsy_Exclusion, Narcolepsy_Exclusion_Compute);

    private const long _cacheIndex_Narcolepsy_Exclusion = -3383504585349343618L;

    private IEnumerable<Condition> Narcolepsy_Exclusion_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Narcolepsy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition NarcolepsyDx) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NarcolepsyDx);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            bool? l_ = context.Operators.SameOrBefore(i_, k_, (string)default);
            return l_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4235625962082214445L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> b_ = this.Narcolepsy_Exclusion(context);
        bool? c_ = context.Operators.Exists<Condition>(b_);
        bool? d_ = context.Operators.Or(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Qualifying Numerator Encounter")]
    public IEnumerable<Encounter> Qualifying_Numerator_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Numerator_Encounter, Qualifying_Numerator_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Numerator_Encounter = 9160626202490665926L;

    private IEnumerable<Encounter> Qualifying_Numerator_Encounter_Compute(CqlContext context)
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

        bool? n_(Encounter PsychPharmManagement) {
            List<Encounter.LocationComponent> al_ = PsychPharmManagement?.Location;

            bool? am_(Encounter.LocationComponent Location) {
                ResourceReference ap_ = Location?.Location;
                Location aq_ = CQMCommon_4_1_000.Instance.GetLocation(context, ap_);
                List<CodeableConcept> ar_ = aq_?.Type;

                CqlConcept as_(CodeableConcept @this) {
                    CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return aw_;
                }

                IEnumerable<CqlConcept> at_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ar_, as_);
                CqlValueSet au_ = this.Ambulatory(context);
                bool? av_ = context.Operators.ConceptsInValueSet(at_, au_);
                return av_;
            }

            IEnumerable<Encounter.LocationComponent> an_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)al_, am_);
            bool? ao_ = context.Operators.Exists<Encounter.LocationComponent>(an_);
            return ao_;
        }

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
    public IEnumerable<Encounter> Encounter_During_Initiation_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_During_Initiation_Phase, Encounter_During_Initiation_Phase_Compute);

    private const long _cacheIndex_Encounter_During_Initiation_Phase = 5455347647867241726L;

    private IEnumerable<Encounter> Encounter_During_Initiation_Phase_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> b_ = Status_1_15_000.Instance.isEncounterPerformed(context, a_);

        bool? c_(Encounter ValidNumeratorEncounter) {
            Period e_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlInterval<CqlDate> g_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, f_);
            CqlDate h_ = context.Operators.Start(g_);
            CqlDate i_ = this.IPSD(context);
            CqlQuantity j_ = context.Operators.Quantity(30m, "days");
            CqlDate k_ = context.Operators.Add(i_, j_);
            CqlInterval<CqlDate> l_ = context.Operators.Interval(i_, k_, false, true);
            bool? m_ = context.Operators.In<CqlDate>(h_, l_, "day");
            bool? n_ = context.Operators.Not((bool?)(i_ is null));
            bool? o_ = context.Operators.And(m_, n_);
            return o_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -1892291096978746434L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_During_Initiation_Phase(context);
        bool? b_ = context.Operators.Exists<Encounter>(a_);
        return b_;
    }


    [CqlExpressionDefinition("ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
    public IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase, ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase = -1527460206037085161L;

    private IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> er_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? es_(Medication M) {
                object ev_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ew_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ex_ = context.Operators.Split((string)ew_, "/");
                string ey_ = context.Operators.Last<string>(ex_);
                bool? ez_ = context.Operators.Equal(ev_, ey_);
                CodeableConcept fa_ = M?.Code;
                CqlConcept fb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fa_);
                CqlValueSet fc_ = this.Atomoxetine(context);
                bool? fd_ = context.Operators.ConceptInValueSet(fb_, fc_);
                bool? fe_ = context.Operators.And(ez_, fd_);
                return fe_;
            }

            IEnumerable<Medication> et_ = context.Operators.Where<Medication>(er_, es_);
            bool? eu_ = context.Operators.Exists<Medication>(et_);
            return eu_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? h_(MedicationRequest AtomoxetineMed) {
            CqlInterval<CqlDate> ff_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate fg_ = context.Operators.Start(ff_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fh_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ff_, fg_);
            return fh_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(g_, h_);

        object j_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate fi_ = @this?.periodStart;
            return fi_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);

        bool? l_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fj_ = @this?.period;
            bool? fk_ = context.Operators.Not((bool?)(fj_ is null));
            return fk_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> m_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(k_, l_);

        CqlInterval<CqlDate> n_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fl_ = @this?.period;
            return fl_;
        }

        IEnumerable<CqlInterval<CqlDate>> o_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(m_, n_);
        IEnumerable<CqlInterval<CqlDate>> p_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, o_);

        bool? q_(MedicationRequest MR) {
            IEnumerable<Medication> fm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fn_(Medication M) {
                object fq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fr_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fs_ = context.Operators.Split((string)fr_, "/");
                string ft_ = context.Operators.Last<string>(fs_);
                bool? fu_ = context.Operators.Equal(fq_, ft_);
                CodeableConcept fv_ = M?.Code;
                CqlConcept fw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fv_);
                CqlValueSet fx_ = this.Clonidine(context);
                bool? fy_ = context.Operators.ConceptInValueSet(fw_, fx_);
                bool? fz_ = context.Operators.And(fu_, fy_);
                return fz_;
            }

            IEnumerable<Medication> fo_ = context.Operators.Where<Medication>(fm_, fn_);
            bool? fp_ = context.Operators.Exists<Medication>(fo_);
            return fp_;
        }

        IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(a_, q_);
        CqlValueSet s_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> t_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> u_ = context.Operators.Union<MedicationRequest>(r_, t_);
        IEnumerable<MedicationRequest> v_ = Status_1_15_000.Instance.isMedicationOrder(context, u_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? w_(MedicationRequest ClonidineMed) {
            CqlInterval<CqlDate> ga_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate gb_ = context.Operators.Start(ga_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gc_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ga_, gb_);
            return gc_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> x_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(v_, w_);

        object y_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate gd_ = @this?.periodStart;
            return gd_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> z_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(x_, y_, System.ComponentModel.ListSortDirection.Ascending);

        bool? aa_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ge_ = @this?.period;
            bool? gf_ = context.Operators.Not((bool?)(ge_ is null));
            return gf_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ab_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(z_, aa_);

        CqlInterval<CqlDate> ac_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gg_ = @this?.period;
            return gg_;
        }

        IEnumerable<CqlInterval<CqlDate>> ad_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ab_, ac_);
        IEnumerable<CqlInterval<CqlDate>> ae_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ad_);
        IEnumerable<CqlInterval<CqlDate>> af_ = context.Operators.Union<CqlInterval<CqlDate>>(p_, ae_);

        bool? ag_(MedicationRequest MR) {
            IEnumerable<Medication> gh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gi_(Medication M) {
                object gl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gn_ = context.Operators.Split((string)gm_, "/");
                string go_ = context.Operators.Last<string>(gn_);
                bool? gp_ = context.Operators.Equal(gl_, go_);
                CodeableConcept gq_ = M?.Code;
                CqlConcept gr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gq_);
                CqlValueSet gs_ = this.Dexmethylphenidate(context);
                bool? gt_ = context.Operators.ConceptInValueSet(gr_, gs_);
                bool? gu_ = context.Operators.And(gp_, gt_);
                return gu_;
            }

            IEnumerable<Medication> gj_ = context.Operators.Where<Medication>(gh_, gi_);
            bool? gk_ = context.Operators.Exists<Medication>(gj_);
            return gk_;
        }

        IEnumerable<MedicationRequest> ah_ = context.Operators.Where<MedicationRequest>(a_, ag_);
        CqlValueSet ai_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> aj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ah_, aj_);
        IEnumerable<MedicationRequest> al_ = Status_1_15_000.Instance.isMedicationOrder(context, ak_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? am_(MedicationRequest DexmethylphenidateMed) {
            CqlInterval<CqlDate> gv_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate gw_ = context.Operators.Start(gv_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gx_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gv_, gw_);
            return gx_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> an_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(al_, am_);

        object ao_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate gy_ = @this?.periodStart;
            return gy_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ap_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(an_, ao_, System.ComponentModel.ListSortDirection.Ascending);

        bool? aq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gz_ = @this?.period;
            bool? ha_ = context.Operators.Not((bool?)(gz_ is null));
            return ha_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ar_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ap_, aq_);

        CqlInterval<CqlDate> as_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hb_ = @this?.period;
            return hb_;
        }

        IEnumerable<CqlInterval<CqlDate>> at_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ar_, as_);
        IEnumerable<CqlInterval<CqlDate>> au_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, at_);

        bool? av_(MedicationRequest MR) {
            IEnumerable<Medication> hc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hd_(Medication M) {
                object hg_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hh_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hi_ = context.Operators.Split((string)hh_, "/");
                string hj_ = context.Operators.Last<string>(hi_);
                bool? hk_ = context.Operators.Equal(hg_, hj_);
                CodeableConcept hl_ = M?.Code;
                CqlConcept hm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hl_);
                CqlValueSet hn_ = this.Dextroamphetamine(context);
                bool? ho_ = context.Operators.ConceptInValueSet(hm_, hn_);
                bool? hp_ = context.Operators.And(hk_, ho_);
                return hp_;
            }

            IEnumerable<Medication> he_ = context.Operators.Where<Medication>(hc_, hd_);
            bool? hf_ = context.Operators.Exists<Medication>(he_);
            return hf_;
        }

        IEnumerable<MedicationRequest> aw_ = context.Operators.Where<MedicationRequest>(a_, av_);
        CqlValueSet ax_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(aw_, ay_);
        IEnumerable<MedicationRequest> ba_ = Status_1_15_000.Instance.isMedicationOrder(context, az_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? bb_(MedicationRequest DextroamphetamineMed) {
            CqlInterval<CqlDate> hq_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate hr_ = context.Operators.Start(hq_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hs_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, hq_, hr_);
            return hs_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bc_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ba_, bb_);

        object bd_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate ht_ = @this?.periodStart;
            return ht_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> be_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bc_, bd_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bf_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hu_ = @this?.period;
            bool? hv_ = context.Operators.Not((bool?)(hu_ is null));
            return hv_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bg_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(be_, bf_);

        CqlInterval<CqlDate> bh_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hw_ = @this?.period;
            return hw_;
        }

        IEnumerable<CqlInterval<CqlDate>> bi_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bg_, bh_);
        IEnumerable<CqlInterval<CqlDate>> bj_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, bi_);
        IEnumerable<CqlInterval<CqlDate>> bk_ = context.Operators.Union<CqlInterval<CqlDate>>(au_, bj_);
        IEnumerable<CqlInterval<CqlDate>> bl_ = context.Operators.Union<CqlInterval<CqlDate>>(af_, bk_);

        bool? bm_(MedicationRequest MR) {
            IEnumerable<Medication> hx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hy_(Medication M) {
                object ib_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ic_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> id_ = context.Operators.Split((string)ic_, "/");
                string ie_ = context.Operators.Last<string>(id_);
                bool? if_ = context.Operators.Equal(ib_, ie_);
                CodeableConcept ig_ = M?.Code;
                CqlConcept ih_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ig_);
                CqlValueSet ii_ = this.Lisdexamfetamine(context);
                bool? ij_ = context.Operators.ConceptInValueSet(ih_, ii_);
                bool? ik_ = context.Operators.And(if_, ij_);
                return ik_;
            }

            IEnumerable<Medication> hz_ = context.Operators.Where<Medication>(hx_, hy_);
            bool? ia_ = context.Operators.Exists<Medication>(hz_);
            return ia_;
        }

        IEnumerable<MedicationRequest> bn_ = context.Operators.Where<MedicationRequest>(a_, bm_);
        CqlValueSet bo_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> bp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bq_ = context.Operators.Union<MedicationRequest>(bn_, bp_);
        IEnumerable<MedicationRequest> br_ = Status_1_15_000.Instance.isMedicationOrder(context, bq_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? bs_(MedicationRequest LisdexamfetamineMed) {
            CqlInterval<CqlDate> il_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate im_ = context.Operators.Start(il_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? in_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, il_, im_);
            return in_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bt_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(br_, bs_);

        object bu_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate io_ = @this?.periodStart;
            return io_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bt_, bu_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bw_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ip_ = @this?.period;
            bool? iq_ = context.Operators.Not((bool?)(ip_ is null));
            return iq_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bx_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bv_, bw_);

        CqlInterval<CqlDate> by_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ir_ = @this?.period;
            return ir_;
        }

        IEnumerable<CqlInterval<CqlDate>> bz_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bx_, by_);
        IEnumerable<CqlInterval<CqlDate>> ca_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, bz_);

        bool? cb_(MedicationRequest MR) {
            IEnumerable<Medication> is_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? it_(Medication M) {
                object iw_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ix_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> iy_ = context.Operators.Split((string)ix_, "/");
                string iz_ = context.Operators.Last<string>(iy_);
                bool? ja_ = context.Operators.Equal(iw_, iz_);
                CodeableConcept jb_ = M?.Code;
                CqlConcept jc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jb_);
                CqlValueSet jd_ = this.Methylphenidate(context);
                bool? je_ = context.Operators.ConceptInValueSet(jc_, jd_);
                bool? jf_ = context.Operators.And(ja_, je_);
                return jf_;
            }

            IEnumerable<Medication> iu_ = context.Operators.Where<Medication>(is_, it_);
            bool? iv_ = context.Operators.Exists<Medication>(iu_);
            return iv_;
        }

        IEnumerable<MedicationRequest> cc_ = context.Operators.Where<MedicationRequest>(a_, cb_);
        CqlValueSet cd_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> ce_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cf_ = context.Operators.Union<MedicationRequest>(cc_, ce_);
        IEnumerable<MedicationRequest> cg_ = Status_1_15_000.Instance.isMedicationOrder(context, cf_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ch_(MedicationRequest MethylphenidateMed) {
            CqlInterval<CqlDate> jg_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate jh_ = context.Operators.Start(jg_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ji_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jg_, jh_);
            return ji_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ci_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cg_, ch_);

        object cj_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate jj_ = @this?.periodStart;
            return jj_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ck_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cl_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jk_ = @this?.period;
            bool? jl_ = context.Operators.Not((bool?)(jk_ is null));
            return jl_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cm_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ck_, cl_);

        CqlInterval<CqlDate> cn_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jm_ = @this?.period;
            return jm_;
        }

        IEnumerable<CqlInterval<CqlDate>> co_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cm_, cn_);
        IEnumerable<CqlInterval<CqlDate>> cp_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, co_);
        IEnumerable<CqlInterval<CqlDate>> cq_ = context.Operators.Union<CqlInterval<CqlDate>>(ca_, cp_);
        IEnumerable<CqlInterval<CqlDate>> cr_ = context.Operators.Union<CqlInterval<CqlDate>>(bl_, cq_);

        bool? cs_(MedicationRequest MR) {
            IEnumerable<Medication> jn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jo_(Medication M) {
                object jr_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object js_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jt_ = context.Operators.Split((string)js_, "/");
                string ju_ = context.Operators.Last<string>(jt_);
                bool? jv_ = context.Operators.Equal(jr_, ju_);
                CodeableConcept jw_ = M?.Code;
                CqlConcept jx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jw_);
                CqlValueSet jy_ = this.Guanfacine_Medications(context);
                bool? jz_ = context.Operators.ConceptInValueSet(jx_, jy_);
                bool? ka_ = context.Operators.And(jv_, jz_);
                return ka_;
            }

            IEnumerable<Medication> jp_ = context.Operators.Where<Medication>(jn_, jo_);
            bool? jq_ = context.Operators.Exists<Medication>(jp_);
            return jq_;
        }

        IEnumerable<MedicationRequest> ct_ = context.Operators.Where<MedicationRequest>(a_, cs_);
        CqlValueSet cu_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> cv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cw_ = context.Operators.Union<MedicationRequest>(ct_, cv_);
        IEnumerable<MedicationRequest> cx_ = Status_1_15_000.Instance.isMedicationOrder(context, cw_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cy_(MedicationRequest GuanfacineMed) {
            CqlInterval<CqlDate> kb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate kc_ = context.Operators.Start(kb_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kd_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kb_, kc_);
            return kd_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cz_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cx_, cy_);

        object da_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate ke_ = @this?.periodStart;
            return ke_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> db_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cz_, da_, System.ComponentModel.ListSortDirection.Ascending);

        bool? dc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> kf_ = @this?.period;
            bool? kg_ = context.Operators.Not((bool?)(kf_ is null));
            return kg_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dd_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(db_, dc_);

        CqlInterval<CqlDate> de_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> kh_ = @this?.period;
            return kh_;
        }

        IEnumerable<CqlInterval<CqlDate>> df_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dd_, de_);
        IEnumerable<CqlInterval<CqlDate>> dg_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, df_);

        bool? dh_(MedicationRequest MR) {
            IEnumerable<Medication> ki_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kj_(Medication M) {
                object km_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ko_ = context.Operators.Split((string)kn_, "/");
                string kp_ = context.Operators.Last<string>(ko_);
                bool? kq_ = context.Operators.Equal(km_, kp_);
                CodeableConcept kr_ = M?.Code;
                CqlConcept ks_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kr_);
                CqlCode kt_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept ku_ = context.Operators.ConvertCodeToConcept(kt_);
                bool? kv_ = context.Operators.Equivalent(ks_, ku_);
                bool? kw_ = context.Operators.And(kq_, kv_);
                return kw_;
            }

            IEnumerable<Medication> kk_ = context.Operators.Where<Medication>(ki_, kj_);
            bool? kl_ = context.Operators.Exists<Medication>(kk_);
            return kl_;
        }

        IEnumerable<MedicationRequest> di_ = context.Operators.Where<MedicationRequest>(a_, dh_);
        CqlCode dj_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> dk_ = context.Operators.ToList<CqlCode>(dj_);
        IEnumerable<MedicationRequest> dl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, dk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dm_ = context.Operators.Union<MedicationRequest>(di_, dl_);
        IEnumerable<MedicationRequest> dn_ = Status_1_15_000.Instance.isMedicationOrder(context, dm_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? do_(MedicationRequest MethamphetamineMed) {
            CqlInterval<CqlDate> kx_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate ky_ = context.Operators.Start(kx_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kz_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kx_, ky_);
            return kz_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dp_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dn_, do_);

        object dq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate la_ = @this?.periodStart;
            return la_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dr_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dp_, dq_, System.ComponentModel.ListSortDirection.Ascending);

        bool? ds_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> lb_ = @this?.period;
            bool? lc_ = context.Operators.Not((bool?)(lb_ is null));
            return lc_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dt_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dr_, ds_);

        CqlInterval<CqlDate> du_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ld_ = @this?.period;
            return ld_;
        }

        IEnumerable<CqlInterval<CqlDate>> dv_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dt_, du_);
        IEnumerable<CqlInterval<CqlDate>> dw_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, dv_);
        IEnumerable<CqlInterval<CqlDate>> dx_ = context.Operators.Union<CqlInterval<CqlDate>>(dg_, dw_);
        IEnumerable<CqlInterval<CqlDate>> dy_ = context.Operators.Union<CqlInterval<CqlDate>>(cr_, dx_);

        bool? dz_(MedicationRequest MR) {
            IEnumerable<Medication> le_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lf_(Medication M) {
                object li_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> lk_ = context.Operators.Split((string)lj_, "/");
                string ll_ = context.Operators.Last<string>(lk_);
                bool? lm_ = context.Operators.Equal(li_, ll_);
                CodeableConcept ln_ = M?.Code;
                CqlConcept lo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ln_);
                CqlValueSet lp_ = this.Viloxazine(context);
                bool? lq_ = context.Operators.ConceptInValueSet(lo_, lp_);
                bool? lr_ = context.Operators.And(lm_, lq_);
                return lr_;
            }

            IEnumerable<Medication> lg_ = context.Operators.Where<Medication>(le_, lf_);
            bool? lh_ = context.Operators.Exists<Medication>(lg_);
            return lh_;
        }

        IEnumerable<MedicationRequest> ea_ = context.Operators.Where<MedicationRequest>(a_, dz_);
        CqlValueSet eb_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> ec_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, eb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ed_ = context.Operators.Union<MedicationRequest>(ea_, ec_);
        IEnumerable<MedicationRequest> ee_ = Status_1_15_000.Instance.isMedicationOrder(context, ed_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ef_(MedicationRequest ViloxazineMed) {
            CqlInterval<CqlDate> ls_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ViloxazineMed);
            CqlDate lt_ = context.Operators.Start(ls_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lu_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ls_, lt_);
            return lu_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> eg_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ee_, ef_);

        object eh_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate lv_ = @this?.periodStart;
            return lv_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ei_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(eg_, eh_, System.ComponentModel.ListSortDirection.Ascending);

        bool? ej_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> lw_ = @this?.period;
            bool? lx_ = context.Operators.Not((bool?)(lw_ is null));
            return lx_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ek_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ei_, ej_);

        CqlInterval<CqlDate> el_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ly_ = @this?.period;
            return ly_;
        }

        IEnumerable<CqlInterval<CqlDate>> em_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ek_, el_);
        IEnumerable<CqlInterval<CqlDate>> en_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, em_);
        IEnumerable<CqlInterval<CqlDate>> eo_ = context.Operators.Union<CqlInterval<CqlDate>>(dy_, en_);

        CqlInterval<CqlDate> ep_(CqlInterval<CqlDate> ADHDMedication) {
            CqlDate lz_ = this.IPSD(context);
            CqlQuantity ma_ = context.Operators.Quantity(300m, "days");
            CqlDate mb_ = context.Operators.Add(lz_, ma_);
            CqlInterval<CqlDate> mc_ = context.Operators.Interval(lz_, mb_, true, true);
            CqlInterval<CqlDate> md_ = context.Operators.Intersect<CqlDate>(ADHDMedication, mc_);
            return md_;
        }

        IEnumerable<CqlInterval<CqlDate>> eq_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(eo_, ep_);
        return eq_;
    }


    [CqlExpressionDefinition("ADHD Cumulative Medication Duration")]
    public int? ADHD_Cumulative_Medication_Duration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ADHD_Cumulative_Medication_Duration, ADHD_Cumulative_Medication_Duration_Compute);

    private const long _cacheIndex_ADHD_Cumulative_Medication_Duration = -3886580344192465847L;

    private int? ADHD_Cumulative_Medication_Duration_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
        int? b_ = CumulativeMedicationDuration_6_0_000.Instance.cumulativeDuration(context, a_);
        return b_;
    }


    [CqlExpressionDefinition("Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days")]
    public bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days, Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days_Compute);

    private const long _cacheIndex_Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days = -1384948008237186285L;

    private bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days_Compute(CqlContext context)
    {
        int? a_ = this.ADHD_Cumulative_Medication_Duration(context);
        bool? b_ = context.Operators.GreaterOrEqual(a_, 210);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase, Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase = -2133610025250707462L;

    private IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);

        bool? b_(Encounter InpatientStay) {
            Period d_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlInterval<CqlDate> f_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, e_);
            CqlDate g_ = context.Operators.Start(f_);
            CqlDate h_ = this.IPSD(context);
            CqlQuantity i_ = context.Operators.Quantity(300m, "days");
            CqlDate j_ = context.Operators.Add(h_, i_);
            CqlInterval<CqlDate> k_ = context.Operators.Interval(h_, j_, false, true);
            bool? l_ = context.Operators.In<CqlDate>(g_, k_, "day");
            bool? m_ = context.Operators.Not((bool?)(h_ is null));
            bool? n_ = context.Operators.And(l_, m_);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_2, Initial_Population_2_Compute);

    private const long _cacheIndex_Initial_Population_2 = -2621416679819002185L;

    private bool? Initial_Population_2_Compute(CqlContext context)
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
        CqlDateTime j_ = context.Operators.End(e_);
        CqlDate k_ = context.Operators.DateFrom(j_);
        int? l_ = context.Operators.CalculateAgeAt(d_, k_, "year");
        bool? m_ = context.Operators.LessOrEqual(l_, 12);
        bool? n_ = context.Operators.And(i_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounter(context);
        bool? p_ = context.Operators.Exists<Encounter>(o_);
        bool? q_ = context.Operators.And(n_, p_);
        CqlDate r_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? s_ = context.Operators.Not((bool?)(r_ is null));
        bool? t_ = context.Operators.And(q_, s_);
        bool? u_ = this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(context);
        bool? v_ = context.Operators.And(t_, u_);
        IEnumerable<Encounter> w_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(context);
        bool? x_ = context.Operators.Exists<Encounter>(w_);
        bool? y_ = context.Operators.Not(x_);
        bool? z_ = context.Operators.And(v_, y_);
        return z_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_2, Denominator_2_Compute);

    private const long _cacheIndex_Denominator_2 = -9201339036072555475L;

    private bool? Denominator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_2(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase, Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase = 1910591399646290016L;

    private IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> b_ = Status_1_15_000.Instance.isEncounterPerformed(context, a_);

        bool? c_(Encounter ValidNumeratorEncounter) {
            Period h_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlInterval<CqlDate> j_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, i_);
            CqlDate k_ = context.Operators.Start(j_);
            CqlDate l_ = this.IPSD(context);
            CqlQuantity m_ = context.Operators.Quantity(31m, "days");
            CqlDate n_ = context.Operators.Add(l_, m_);
            CqlQuantity o_ = context.Operators.Quantity(300m, "days");
            CqlDate p_ = context.Operators.Add(l_, o_);
            CqlInterval<CqlDate> q_ = context.Operators.Interval(n_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDate>(k_, q_, "day");
            return r_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        CqlDate e_(Encounter ValidNumeratorEncounter) {
            Period s_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            return v_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.Select<Encounter, CqlDate>(d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
    public bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase, Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase = 9168811075567996819L;

    private bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        int? b_ = context.Operators.Count<CqlDate>(a_);
        bool? c_ = context.Operators.GreaterOrEqual(b_, 2);
        return c_;
    }


    [CqlExpressionDefinition("Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase, Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase = 4453205296495751162L;

    private IEnumerable<CqlDate> Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

        bool? d_(Encounter VirtualEnc) {
            Period i_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlInterval<CqlDate> k_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, j_);
            CqlDate l_ = context.Operators.Start(k_);
            CqlDate m_ = this.IPSD(context);
            CqlQuantity n_ = context.Operators.Quantity(31m, "days");
            CqlDate o_ = context.Operators.Add(m_, n_);
            CqlQuantity p_ = context.Operators.Quantity(300m, "days");
            CqlDate q_ = context.Operators.Add(m_, p_);
            CqlInterval<CqlDate> r_ = context.Operators.Interval(o_, q_, true, true);
            bool? s_ = context.Operators.In<CqlDate>(l_, r_, "day");
            return s_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        CqlDate f_(Encounter VirtualEnc) {
            Period t_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlDate w_ = context.Operators.DateFrom(v_);
            return w_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.Select<Encounter, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -2855501864183294304L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_During_Initiation_Phase(context);
        bool? b_ = context.Operators.Exists<Encounter>(a_);
        bool? c_ = this.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> d_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);

        bool? e_(CqlDate Encounter1) {
            IEnumerable<CqlDate> j_ = this.Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);

            bool? k_(CqlDate Encounter2) {
                bool? n_ = context.Operators.Not((bool?)(Encounter1 is null));
                bool? o_ = context.Operators.Not((bool?)(Encounter2 is null));
                bool? p_ = context.Operators.And(n_, o_);
                bool? q_ = context.Operators.Equivalent(Encounter1, Encounter2);
                bool? r_ = context.Operators.Not(q_);
                bool? s_ = context.Operators.And(p_, r_);
                return s_;
            }

            IEnumerable<CqlDate> l_ = context.Operators.Where<CqlDate>(j_, k_);
            bool? m_ = context.Operators.Exists<CqlDate>(l_);
            return m_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.Where<CqlDate>(d_, e_);
        bool? g_ = context.Operators.Exists<CqlDate>(f_);
        bool? h_ = context.Operators.Or(c_, g_);
        bool? i_ = context.Operators.And(b_, h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 7798486612078586507L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 7363118988704722449L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 2276067258728685427L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5817697175571891270L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS136FHIRChildADHDMedFollowUp_1_0_000() {}

    public static CMS136FHIRChildADHDMedFollowUp_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS136FHIRChildADHDMedFollowUp";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance, Hospice_6_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW = new(
       [typeof(CqlDate)],
       ["startDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD = new(
       [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
       ["period", "periodStart"]);

    #endregion CqlTupleMetadata Properties

}
