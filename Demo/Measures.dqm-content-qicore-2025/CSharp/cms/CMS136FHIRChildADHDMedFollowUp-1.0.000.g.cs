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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.3.0")]
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
            IEnumerable<Medication> bl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bm_(Medication M) {
                string bo_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType bp_ = MR?.Medication;
                object bq_ = context.Operators.LateBoundProperty<object>(bp_, "reference");
                object br_ = context.Operators.LateBoundProperty<object>(bq_, "value");
                IEnumerable<string> bs_ = context.Operators.Split((string)br_, "/");
                string bt_ = context.Operators.Last<string>(bs_);
                bool? bu_ = context.Operators.Equal(bo_, bt_);
                CodeableConcept bv_ = M?.Code;
                CqlConcept bw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bv_);
                CqlValueSet bx_ = this.Atomoxetine(context);
                bool? by_ = context.Operators.ConceptInValueSet(bw_, bx_);
                bool? bz_ = context.Operators.And(bu_, by_);
                return bz_;
            }

            bool? bn_ = context.Operators.WhereAny<Medication>(bl_, bm_);
            return bn_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ca_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cb_(Medication M) {
                string cd_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType ce_ = MR?.Medication;
                object cf_ = context.Operators.LateBoundProperty<object>(ce_, "reference");
                object cg_ = context.Operators.LateBoundProperty<object>(cf_, "value");
                IEnumerable<string> ch_ = context.Operators.Split((string)cg_, "/");
                string ci_ = context.Operators.Last<string>(ch_);
                bool? cj_ = context.Operators.Equal(cd_, ci_);
                CodeableConcept ck_ = M?.Code;
                CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ck_);
                CqlValueSet cm_ = this.Clonidine(context);
                bool? cn_ = context.Operators.ConceptInValueSet(cl_, cm_);
                bool? co_ = context.Operators.And(cj_, cn_);
                return co_;
            }

            bool? cc_ = context.Operators.WhereAny<Medication>(ca_, cb_);
            return cc_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> cp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cq_(Medication M) {
                string cs_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType ct_ = MR?.Medication;
                object cu_ = context.Operators.LateBoundProperty<object>(ct_, "reference");
                object cv_ = context.Operators.LateBoundProperty<object>(cu_, "value");
                IEnumerable<string> cw_ = context.Operators.Split((string)cv_, "/");
                string cx_ = context.Operators.Last<string>(cw_);
                bool? cy_ = context.Operators.Equal(cs_, cx_);
                CodeableConcept cz_ = M?.Code;
                CqlConcept da_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cz_);
                CqlValueSet db_ = this.Dexmethylphenidate(context);
                bool? dc_ = context.Operators.ConceptInValueSet(da_, db_);
                bool? dd_ = context.Operators.And(cy_, dc_);
                return dd_;
            }

            bool? cr_ = context.Operators.WhereAny<Medication>(cp_, cq_);
            return cr_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(a_, m_);
        CqlValueSet o_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest MR) {
            IEnumerable<Medication> de_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? df_(Medication M) {
                string dh_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType di_ = MR?.Medication;
                object dj_ = context.Operators.LateBoundProperty<object>(di_, "reference");
                object dk_ = context.Operators.LateBoundProperty<object>(dj_, "value");
                IEnumerable<string> dl_ = context.Operators.Split((string)dk_, "/");
                string dm_ = context.Operators.Last<string>(dl_);
                bool? dn_ = context.Operators.Equal(dh_, dm_);
                CodeableConcept do_ = M?.Code;
                CqlConcept dp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, do_);
                CqlValueSet dq_ = this.Dextroamphetamine(context);
                bool? dr_ = context.Operators.ConceptInValueSet(dp_, dq_);
                bool? ds_ = context.Operators.And(dn_, dr_);
                return ds_;
            }

            bool? dg_ = context.Operators.WhereAny<Medication>(de_, df_);
            return dg_;
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(a_, s_);
        CqlValueSet u_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> w_ = context.Operators.Union<MedicationRequest>(t_, v_);
        IEnumerable<MedicationRequest> x_ = context.Operators.Union<MedicationRequest>(r_, w_);

        bool? y_(MedicationRequest MR) {
            IEnumerable<Medication> dt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? du_(Medication M) {
                string dw_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType dx_ = MR?.Medication;
                object dy_ = context.Operators.LateBoundProperty<object>(dx_, "reference");
                object dz_ = context.Operators.LateBoundProperty<object>(dy_, "value");
                IEnumerable<string> ea_ = context.Operators.Split((string)dz_, "/");
                string eb_ = context.Operators.Last<string>(ea_);
                bool? ec_ = context.Operators.Equal(dw_, eb_);
                CodeableConcept ed_ = M?.Code;
                CqlConcept ee_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ed_);
                CqlValueSet ef_ = this.Lisdexamfetamine(context);
                bool? eg_ = context.Operators.ConceptInValueSet(ee_, ef_);
                bool? eh_ = context.Operators.And(ec_, eg_);
                return eh_;
            }

            bool? dv_ = context.Operators.WhereAny<Medication>(dt_, du_);
            return dv_;
        }

        IEnumerable<MedicationRequest> z_ = context.Operators.Where<MedicationRequest>(a_, y_);
        CqlValueSet aa_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(z_, ab_);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(x_, ac_);

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> ei_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ej_(Medication M) {
                string el_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType em_ = MR?.Medication;
                object en_ = context.Operators.LateBoundProperty<object>(em_, "reference");
                object eo_ = context.Operators.LateBoundProperty<object>(en_, "value");
                IEnumerable<string> ep_ = context.Operators.Split((string)eo_, "/");
                string eq_ = context.Operators.Last<string>(ep_);
                bool? er_ = context.Operators.Equal(el_, eq_);
                CodeableConcept es_ = M?.Code;
                CqlConcept et_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, es_);
                CqlCode eu_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept ev_ = context.Operators.ConvertCodeToConcept(eu_);
                bool? ew_ = context.Operators.Equivalent(et_, ev_);
                bool? ex_ = context.Operators.And(er_, ew_);
                return ex_;
            }

            bool? ek_ = context.Operators.WhereAny<Medication>(ei_, ej_);
            return ek_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(a_, ae_);
        CqlCode ag_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(af_, ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ad_, aj_);

        bool? al_(MedicationRequest MR) {
            IEnumerable<Medication> ey_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ez_(Medication M) {
                string fb_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType fc_ = MR?.Medication;
                object fd_ = context.Operators.LateBoundProperty<object>(fc_, "reference");
                object fe_ = context.Operators.LateBoundProperty<object>(fd_, "value");
                IEnumerable<string> ff_ = context.Operators.Split((string)fe_, "/");
                string fg_ = context.Operators.Last<string>(ff_);
                bool? fh_ = context.Operators.Equal(fb_, fg_);
                CodeableConcept fi_ = M?.Code;
                CqlConcept fj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fi_);
                CqlValueSet fk_ = this.Methylphenidate(context);
                bool? fl_ = context.Operators.ConceptInValueSet(fj_, fk_);
                bool? fm_ = context.Operators.And(fh_, fl_);
                return fm_;
            }

            bool? fa_ = context.Operators.WhereAny<Medication>(ey_, ez_);
            return fa_;
        }

        IEnumerable<MedicationRequest> am_ = context.Operators.Where<MedicationRequest>(a_, al_);
        CqlValueSet an_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Union<MedicationRequest>(ak_, ap_);

        bool? ar_(MedicationRequest MR) {
            IEnumerable<Medication> fn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fo_(Medication M) {
                string fq_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType fr_ = MR?.Medication;
                object fs_ = context.Operators.LateBoundProperty<object>(fr_, "reference");
                object ft_ = context.Operators.LateBoundProperty<object>(fs_, "value");
                IEnumerable<string> fu_ = context.Operators.Split((string)ft_, "/");
                string fv_ = context.Operators.Last<string>(fu_);
                bool? fw_ = context.Operators.Equal(fq_, fv_);
                CodeableConcept fx_ = M?.Code;
                CqlConcept fy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fx_);
                CqlValueSet fz_ = this.Guanfacine_Medications(context);
                bool? ga_ = context.Operators.ConceptInValueSet(fy_, fz_);
                bool? gb_ = context.Operators.And(fw_, ga_);
                return gb_;
            }

            bool? fp_ = context.Operators.WhereAny<Medication>(fn_, fo_);
            return fp_;
        }

        IEnumerable<MedicationRequest> as_ = context.Operators.Where<MedicationRequest>(a_, ar_);
        CqlValueSet at_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(aq_, av_);

        bool? ax_(MedicationRequest MR) {
            IEnumerable<Medication> gc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gd_(Medication M) {
                string gf_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType gg_ = MR?.Medication;
                object gh_ = context.Operators.LateBoundProperty<object>(gg_, "reference");
                object gi_ = context.Operators.LateBoundProperty<object>(gh_, "value");
                IEnumerable<string> gj_ = context.Operators.Split((string)gi_, "/");
                string gk_ = context.Operators.Last<string>(gj_);
                bool? gl_ = context.Operators.Equal(gf_, gk_);
                CodeableConcept gm_ = M?.Code;
                CqlConcept gn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gm_);
                CqlValueSet go_ = this.Viloxazine(context);
                bool? gp_ = context.Operators.ConceptInValueSet(gn_, go_);
                bool? gq_ = context.Operators.And(gl_, gp_);
                return gq_;
            }

            bool? ge_ = context.Operators.WhereAny<Medication>(gc_, gd_);
            return ge_;
        }

        IEnumerable<MedicationRequest> ay_ = context.Operators.Where<MedicationRequest>(a_, ax_);
        CqlValueSet az_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, az_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(ay_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(aw_, bb_);
        IEnumerable<MedicationRequest> bd_ = Status_1_15_000.Instance.isMedicationOrder(context, bc_);

        bool? be_(MedicationRequest ADHDMedications) {
            CqlInterval<CqlDate> gr_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate gs_ = context.Operators.Start(gr_);
            CqlDateTime gt_ = context.Operators.ConvertDateToDateTime(gs_);
            CqlInterval<CqlDateTime> gu_ = this.Intake_Period(context);
            bool? gv_ = context.Operators.In<CqlDateTime>(gt_, gu_, (string)default);
            return gv_;
        }

        IEnumerable<MedicationRequest> bf_ = context.Operators.Where<MedicationRequest>(bd_, be_);

        bool? bg_(MedicationRequest ADHDMedicationOrder) {
            IEnumerable<MedicationRequest> gw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? gx_(MedicationRequest MR) {
                IEnumerable<Medication> jd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? je_(Medication M) {
                    string jg_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType jh_ = MR?.Medication;
                    object ji_ = context.Operators.LateBoundProperty<object>(jh_, "reference");
                    object jj_ = context.Operators.LateBoundProperty<object>(ji_, "value");
                    IEnumerable<string> jk_ = context.Operators.Split((string)jj_, "/");
                    string jl_ = context.Operators.Last<string>(jk_);
                    bool? jm_ = context.Operators.Equal(jg_, jl_);
                    CodeableConcept jn_ = M?.Code;
                    CqlConcept jo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jn_);
                    CqlValueSet jp_ = this.Atomoxetine(context);
                    bool? jq_ = context.Operators.ConceptInValueSet(jo_, jp_);
                    bool? jr_ = context.Operators.And(jm_, jq_);
                    return jr_;
                }

                bool? jf_ = context.Operators.WhereAny<Medication>(jd_, je_);
                return jf_;
            }

            IEnumerable<MedicationRequest> gy_ = context.Operators.Where<MedicationRequest>(gw_, gx_);
            CqlValueSet gz_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> ha_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hb_ = context.Operators.Union<MedicationRequest>(gy_, ha_);

            bool? hc_(MedicationRequest MR) {
                IEnumerable<Medication> js_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? jt_(Medication M) {
                    string jv_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType jw_ = MR?.Medication;
                    object jx_ = context.Operators.LateBoundProperty<object>(jw_, "reference");
                    object jy_ = context.Operators.LateBoundProperty<object>(jx_, "value");
                    IEnumerable<string> jz_ = context.Operators.Split((string)jy_, "/");
                    string ka_ = context.Operators.Last<string>(jz_);
                    bool? kb_ = context.Operators.Equal(jv_, ka_);
                    CodeableConcept kc_ = M?.Code;
                    CqlConcept kd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kc_);
                    CqlValueSet ke_ = this.Clonidine(context);
                    bool? kf_ = context.Operators.ConceptInValueSet(kd_, ke_);
                    bool? kg_ = context.Operators.And(kb_, kf_);
                    return kg_;
                }

                bool? ju_ = context.Operators.WhereAny<Medication>(js_, jt_);
                return ju_;
            }

            IEnumerable<MedicationRequest> hd_ = context.Operators.Where<MedicationRequest>(gw_, hc_);
            CqlValueSet he_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> hf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, he_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hg_ = context.Operators.Union<MedicationRequest>(hd_, hf_);
            IEnumerable<MedicationRequest> hh_ = context.Operators.Union<MedicationRequest>(hb_, hg_);

            bool? hi_(MedicationRequest MR) {
                IEnumerable<Medication> kh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ki_(Medication M) {
                    string kk_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType kl_ = MR?.Medication;
                    object km_ = context.Operators.LateBoundProperty<object>(kl_, "reference");
                    object kn_ = context.Operators.LateBoundProperty<object>(km_, "value");
                    IEnumerable<string> ko_ = context.Operators.Split((string)kn_, "/");
                    string kp_ = context.Operators.Last<string>(ko_);
                    bool? kq_ = context.Operators.Equal(kk_, kp_);
                    CodeableConcept kr_ = M?.Code;
                    CqlConcept ks_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kr_);
                    CqlValueSet kt_ = this.Dexmethylphenidate(context);
                    bool? ku_ = context.Operators.ConceptInValueSet(ks_, kt_);
                    bool? kv_ = context.Operators.And(kq_, ku_);
                    return kv_;
                }

                bool? kj_ = context.Operators.WhereAny<Medication>(kh_, ki_);
                return kj_;
            }

            IEnumerable<MedicationRequest> hj_ = context.Operators.Where<MedicationRequest>(gw_, hi_);
            CqlValueSet hk_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> hl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hm_ = context.Operators.Union<MedicationRequest>(hj_, hl_);
            IEnumerable<MedicationRequest> hn_ = context.Operators.Union<MedicationRequest>(hh_, hm_);

            bool? ho_(MedicationRequest MR) {
                IEnumerable<Medication> kw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? kx_(Medication M) {
                    string kz_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType la_ = MR?.Medication;
                    object lb_ = context.Operators.LateBoundProperty<object>(la_, "reference");
                    object lc_ = context.Operators.LateBoundProperty<object>(lb_, "value");
                    IEnumerable<string> ld_ = context.Operators.Split((string)lc_, "/");
                    string le_ = context.Operators.Last<string>(ld_);
                    bool? lf_ = context.Operators.Equal(kz_, le_);
                    CodeableConcept lg_ = M?.Code;
                    CqlConcept lh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lg_);
                    CqlValueSet li_ = this.Dextroamphetamine(context);
                    bool? lj_ = context.Operators.ConceptInValueSet(lh_, li_);
                    bool? lk_ = context.Operators.And(lf_, lj_);
                    return lk_;
                }

                bool? ky_ = context.Operators.WhereAny<Medication>(kw_, kx_);
                return ky_;
            }

            IEnumerable<MedicationRequest> hp_ = context.Operators.Where<MedicationRequest>(gw_, ho_);
            CqlValueSet hq_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> hr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hs_ = context.Operators.Union<MedicationRequest>(hp_, hr_);
            IEnumerable<MedicationRequest> ht_ = context.Operators.Union<MedicationRequest>(hn_, hs_);

            bool? hu_(MedicationRequest MR) {
                IEnumerable<Medication> ll_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? lm_(Medication M) {
                    string lo_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType lp_ = MR?.Medication;
                    object lq_ = context.Operators.LateBoundProperty<object>(lp_, "reference");
                    object lr_ = context.Operators.LateBoundProperty<object>(lq_, "value");
                    IEnumerable<string> ls_ = context.Operators.Split((string)lr_, "/");
                    string lt_ = context.Operators.Last<string>(ls_);
                    bool? lu_ = context.Operators.Equal(lo_, lt_);
                    CodeableConcept lv_ = M?.Code;
                    CqlConcept lw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lv_);
                    CqlValueSet lx_ = this.Lisdexamfetamine(context);
                    bool? ly_ = context.Operators.ConceptInValueSet(lw_, lx_);
                    bool? lz_ = context.Operators.And(lu_, ly_);
                    return lz_;
                }

                bool? ln_ = context.Operators.WhereAny<Medication>(ll_, lm_);
                return ln_;
            }

            IEnumerable<MedicationRequest> hv_ = context.Operators.Where<MedicationRequest>(gw_, hu_);
            CqlValueSet hw_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> hx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hy_ = context.Operators.Union<MedicationRequest>(hv_, hx_);
            IEnumerable<MedicationRequest> hz_ = context.Operators.Union<MedicationRequest>(ht_, hy_);

            bool? ia_(MedicationRequest MR) {
                IEnumerable<Medication> ma_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? mb_(Medication M) {
                    string md_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType me_ = MR?.Medication;
                    object mf_ = context.Operators.LateBoundProperty<object>(me_, "reference");
                    object mg_ = context.Operators.LateBoundProperty<object>(mf_, "value");
                    IEnumerable<string> mh_ = context.Operators.Split((string)mg_, "/");
                    string mi_ = context.Operators.Last<string>(mh_);
                    bool? mj_ = context.Operators.Equal(md_, mi_);
                    CodeableConcept mk_ = M?.Code;
                    CqlConcept ml_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mk_);
                    CqlCode mm_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                    CqlConcept mn_ = context.Operators.ConvertCodeToConcept(mm_);
                    bool? mo_ = context.Operators.Equivalent(ml_, mn_);
                    bool? mp_ = context.Operators.And(mj_, mo_);
                    return mp_;
                }

                bool? mc_ = context.Operators.WhereAny<Medication>(ma_, mb_);
                return mc_;
            }

            IEnumerable<MedicationRequest> ib_ = context.Operators.Where<MedicationRequest>(gw_, ia_);
            CqlCode ic_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> id_ = context.Operators.ToList<CqlCode>(ic_);
            IEnumerable<MedicationRequest> ie_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, id_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> if_ = context.Operators.Union<MedicationRequest>(ib_, ie_);
            IEnumerable<MedicationRequest> ig_ = context.Operators.Union<MedicationRequest>(hz_, if_);

            bool? ih_(MedicationRequest MR) {
                IEnumerable<Medication> mq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? mr_(Medication M) {
                    string mt_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType mu_ = MR?.Medication;
                    object mv_ = context.Operators.LateBoundProperty<object>(mu_, "reference");
                    object mw_ = context.Operators.LateBoundProperty<object>(mv_, "value");
                    IEnumerable<string> mx_ = context.Operators.Split((string)mw_, "/");
                    string my_ = context.Operators.Last<string>(mx_);
                    bool? mz_ = context.Operators.Equal(mt_, my_);
                    CodeableConcept na_ = M?.Code;
                    CqlConcept nb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, na_);
                    CqlValueSet nc_ = this.Methylphenidate(context);
                    bool? nd_ = context.Operators.ConceptInValueSet(nb_, nc_);
                    bool? ne_ = context.Operators.And(mz_, nd_);
                    return ne_;
                }

                bool? ms_ = context.Operators.WhereAny<Medication>(mq_, mr_);
                return ms_;
            }

            IEnumerable<MedicationRequest> ii_ = context.Operators.Where<MedicationRequest>(gw_, ih_);
            CqlValueSet ij_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> ik_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ij_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> il_ = context.Operators.Union<MedicationRequest>(ii_, ik_);
            IEnumerable<MedicationRequest> im_ = context.Operators.Union<MedicationRequest>(ig_, il_);

            bool? in_(MedicationRequest MR) {
                IEnumerable<Medication> nf_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ng_(Medication M) {
                    string ni_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType nj_ = MR?.Medication;
                    object nk_ = context.Operators.LateBoundProperty<object>(nj_, "reference");
                    object nl_ = context.Operators.LateBoundProperty<object>(nk_, "value");
                    IEnumerable<string> nm_ = context.Operators.Split((string)nl_, "/");
                    string nn_ = context.Operators.Last<string>(nm_);
                    bool? no_ = context.Operators.Equal(ni_, nn_);
                    CodeableConcept np_ = M?.Code;
                    CqlConcept nq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, np_);
                    CqlValueSet nr_ = this.Guanfacine_Medications(context);
                    bool? ns_ = context.Operators.ConceptInValueSet(nq_, nr_);
                    bool? nt_ = context.Operators.And(no_, ns_);
                    return nt_;
                }

                bool? nh_ = context.Operators.WhereAny<Medication>(nf_, ng_);
                return nh_;
            }

            IEnumerable<MedicationRequest> io_ = context.Operators.Where<MedicationRequest>(gw_, in_);
            CqlValueSet ip_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> iq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ip_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ir_ = context.Operators.Union<MedicationRequest>(io_, iq_);
            IEnumerable<MedicationRequest> is_ = context.Operators.Union<MedicationRequest>(im_, ir_);

            bool? it_(MedicationRequest MR) {
                IEnumerable<Medication> nu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? nv_(Medication M) {
                    string nx_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType ny_ = MR?.Medication;
                    object nz_ = context.Operators.LateBoundProperty<object>(ny_, "reference");
                    object oa_ = context.Operators.LateBoundProperty<object>(nz_, "value");
                    IEnumerable<string> ob_ = context.Operators.Split((string)oa_, "/");
                    string oc_ = context.Operators.Last<string>(ob_);
                    bool? od_ = context.Operators.Equal(nx_, oc_);
                    CodeableConcept oe_ = M?.Code;
                    CqlConcept of_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, oe_);
                    CqlValueSet og_ = this.Viloxazine(context);
                    bool? oh_ = context.Operators.ConceptInValueSet(of_, og_);
                    bool? oi_ = context.Operators.And(od_, oh_);
                    return oi_;
                }

                bool? nw_ = context.Operators.WhereAny<Medication>(nu_, nv_);
                return nw_;
            }

            IEnumerable<MedicationRequest> iu_ = context.Operators.Where<MedicationRequest>(gw_, it_);
            CqlValueSet iv_ = this.Viloxazine(context);
            IEnumerable<MedicationRequest> iw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, iv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ix_ = context.Operators.Union<MedicationRequest>(iu_, iw_);
            IEnumerable<MedicationRequest> iy_ = context.Operators.Union<MedicationRequest>(is_, ix_);
            IEnumerable<MedicationRequest> iz_ = Status_1_15_000.Instance.isMedicationActive(context, iy_);

            bool? ja_(MedicationRequest ActiveADHDMedication) {
                CqlInterval<CqlDate> oj_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> ok_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate ol_ = context.Operators.Start(ok_);
                CqlDateTime om_ = context.Operators.ConvertDateToDateTime(ol_);
                CqlDate on_ = context.Operators.DateFrom(om_);
                CqlQuantity oo_ = context.Operators.Quantity(120m, "days");
                CqlDate op_ = context.Operators.Subtract(on_, oo_);
                CqlInterval<CqlDate> oq_ = context.Operators.Interval(op_, on_, true, false);
                bool? or_ = context.Operators.Overlaps(oj_, oq_, (string)default);
                return or_;
            }

            bool? jb_ = context.Operators.WhereAny<MedicationRequest>(iz_, ja_);
            bool? jc_ = context.Operators.Not(jb_);
            return jc_;
        }


        (CqlTupleMetadata, CqlDate startDate)? bh_(MedicationRequest QualifyingMed) {
            CqlInterval<CqlDate> os_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate ot_ = context.Operators.Start(os_);
            (CqlTupleMetadata, CqlDate startDate)? ou_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, ot_);
            return ou_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> bi_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(bf_, bg_, bh_);

        object bj_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate ov_ = @this?.startDate;
            return ov_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> bk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(bi_, bj_, System.ComponentModel.ListSortDirection.Ascending);
        return bk_;
    }


    [CqlExpressionDefinition("First ADHD Medication Prescribed During Intake Period")]
    public CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_ADHD_Medication_Prescribed_During_Intake_Period, First_ADHD_Medication_Prescribed_During_Intake_Period_Compute);

    private const long _cacheIndex_First_ADHD_Medication_Prescribed_During_Intake_Period = -4639298654653847318L;

    private CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> a_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(context);

        bool? b_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate f_ = @this?.startDate;
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            return g_;
        }


        CqlDate c_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate h_ = @this?.startDate;
            return h_;
        }

        IEnumerable<CqlDate> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlDate startDate)?, CqlDate>(a_, b_, c_);
        CqlDate e_ = context.Operators.First<CqlDate>(d_);
        return e_;
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
                ResourceReference ao_ = Location?.Location;
                Location ap_ = CQMCommon_4_1_000.Instance.GetLocation(context, ao_);
                List<CodeableConcept> aq_ = ap_?.Type;

                CqlConcept ar_(CodeableConcept @this) {
                    CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return av_;
                }

                IEnumerable<CqlConcept> as_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aq_, ar_);
                CqlValueSet at_ = this.Ambulatory(context);
                bool? au_ = context.Operators.ConceptsInValueSet(as_, at_);
                return au_;
            }

            bool? an_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)al_, am_);
            return an_;
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
            IEnumerable<Medication> ei_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ej_(Medication M) {
                string el_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType em_ = MR?.Medication;
                object en_ = context.Operators.LateBoundProperty<object>(em_, "reference");
                object eo_ = context.Operators.LateBoundProperty<object>(en_, "value");
                IEnumerable<string> ep_ = context.Operators.Split((string)eo_, "/");
                string eq_ = context.Operators.Last<string>(ep_);
                bool? er_ = context.Operators.Equal(el_, eq_);
                CodeableConcept es_ = M?.Code;
                CqlConcept et_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, es_);
                CqlValueSet eu_ = this.Atomoxetine(context);
                bool? ev_ = context.Operators.ConceptInValueSet(et_, eu_);
                bool? ew_ = context.Operators.And(er_, ev_);
                return ew_;
            }

            bool? ek_ = context.Operators.WhereAny<Medication>(ei_, ej_);
            return ek_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? h_(MedicationRequest AtomoxetineMed) {
            CqlInterval<CqlDate> ex_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate ey_ = context.Operators.Start(ex_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ez_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ex_, ey_);
            return ez_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(g_, h_);

        object j_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate fa_ = @this?.periodStart;
            return fa_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);

        bool? l_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fb_ = @this?.period;
            bool? fc_ = context.Operators.Not((bool?)(fb_ is null));
            return fc_;
        }


        CqlInterval<CqlDate> m_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fd_ = @this?.period;
            return fd_;
        }

        IEnumerable<CqlInterval<CqlDate>> n_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(k_, l_, m_);
        IEnumerable<CqlInterval<CqlDate>> o_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, n_);

        bool? p_(MedicationRequest MR) {
            IEnumerable<Medication> fe_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ff_(Medication M) {
                string fh_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType fi_ = MR?.Medication;
                object fj_ = context.Operators.LateBoundProperty<object>(fi_, "reference");
                object fk_ = context.Operators.LateBoundProperty<object>(fj_, "value");
                IEnumerable<string> fl_ = context.Operators.Split((string)fk_, "/");
                string fm_ = context.Operators.Last<string>(fl_);
                bool? fn_ = context.Operators.Equal(fh_, fm_);
                CodeableConcept fo_ = M?.Code;
                CqlConcept fp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fo_);
                CqlValueSet fq_ = this.Clonidine(context);
                bool? fr_ = context.Operators.ConceptInValueSet(fp_, fq_);
                bool? fs_ = context.Operators.And(fn_, fr_);
                return fs_;
            }

            bool? fg_ = context.Operators.WhereAny<Medication>(fe_, ff_);
            return fg_;
        }

        IEnumerable<MedicationRequest> q_ = context.Operators.Where<MedicationRequest>(a_, p_);
        CqlValueSet r_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> s_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(q_, s_);
        IEnumerable<MedicationRequest> u_ = Status_1_15_000.Instance.isMedicationOrder(context, t_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? v_(MedicationRequest ClonidineMed) {
            CqlInterval<CqlDate> ft_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate fu_ = context.Operators.Start(ft_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fv_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ft_, fu_);
            return fv_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> w_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(u_, v_);

        object x_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate fw_ = @this?.periodStart;
            return fw_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> y_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);

        bool? z_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fx_ = @this?.period;
            bool? fy_ = context.Operators.Not((bool?)(fx_ is null));
            return fy_;
        }


        CqlInterval<CqlDate> aa_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fz_ = @this?.period;
            return fz_;
        }

        IEnumerable<CqlInterval<CqlDate>> ab_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(y_, z_, aa_);
        IEnumerable<CqlInterval<CqlDate>> ac_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ab_);
        IEnumerable<CqlInterval<CqlDate>> ad_ = context.Operators.Union<CqlInterval<CqlDate>>(o_, ac_);

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> ga_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gb_(Medication M) {
                string gd_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType ge_ = MR?.Medication;
                object gf_ = context.Operators.LateBoundProperty<object>(ge_, "reference");
                object gg_ = context.Operators.LateBoundProperty<object>(gf_, "value");
                IEnumerable<string> gh_ = context.Operators.Split((string)gg_, "/");
                string gi_ = context.Operators.Last<string>(gh_);
                bool? gj_ = context.Operators.Equal(gd_, gi_);
                CodeableConcept gk_ = M?.Code;
                CqlConcept gl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gk_);
                CqlValueSet gm_ = this.Dexmethylphenidate(context);
                bool? gn_ = context.Operators.ConceptInValueSet(gl_, gm_);
                bool? go_ = context.Operators.And(gj_, gn_);
                return go_;
            }

            bool? gc_ = context.Operators.WhereAny<Medication>(ga_, gb_);
            return gc_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(a_, ae_);
        CqlValueSet ag_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ai_ = context.Operators.Union<MedicationRequest>(af_, ah_);
        IEnumerable<MedicationRequest> aj_ = Status_1_15_000.Instance.isMedicationOrder(context, ai_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ak_(MedicationRequest DexmethylphenidateMed) {
            CqlInterval<CqlDate> gp_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate gq_ = context.Operators.Start(gp_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gr_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gp_, gq_);
            return gr_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> al_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(aj_, ak_);

        object am_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate gs_ = @this?.periodStart;
            return gs_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> an_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);

        bool? ao_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gt_ = @this?.period;
            bool? gu_ = context.Operators.Not((bool?)(gt_ is null));
            return gu_;
        }


        CqlInterval<CqlDate> ap_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gv_ = @this?.period;
            return gv_;
        }

        IEnumerable<CqlInterval<CqlDate>> aq_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(an_, ao_, ap_);
        IEnumerable<CqlInterval<CqlDate>> ar_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, aq_);

        bool? as_(MedicationRequest MR) {
            IEnumerable<Medication> gw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gx_(Medication M) {
                string gz_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType ha_ = MR?.Medication;
                object hb_ = context.Operators.LateBoundProperty<object>(ha_, "reference");
                object hc_ = context.Operators.LateBoundProperty<object>(hb_, "value");
                IEnumerable<string> hd_ = context.Operators.Split((string)hc_, "/");
                string he_ = context.Operators.Last<string>(hd_);
                bool? hf_ = context.Operators.Equal(gz_, he_);
                CodeableConcept hg_ = M?.Code;
                CqlConcept hh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hg_);
                CqlValueSet hi_ = this.Dextroamphetamine(context);
                bool? hj_ = context.Operators.ConceptInValueSet(hh_, hi_);
                bool? hk_ = context.Operators.And(hf_, hj_);
                return hk_;
            }

            bool? gy_ = context.Operators.WhereAny<Medication>(gw_, gx_);
            return gy_;
        }

        IEnumerable<MedicationRequest> at_ = context.Operators.Where<MedicationRequest>(a_, as_);
        CqlValueSet au_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> av_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, au_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(at_, av_);
        IEnumerable<MedicationRequest> ax_ = Status_1_15_000.Instance.isMedicationOrder(context, aw_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ay_(MedicationRequest DextroamphetamineMed) {
            CqlInterval<CqlDate> hl_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate hm_ = context.Operators.Start(hl_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hn_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, hl_, hm_);
            return hn_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> az_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ax_, ay_);

        object ba_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate ho_ = @this?.periodStart;
            return ho_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bb_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hp_ = @this?.period;
            bool? hq_ = context.Operators.Not((bool?)(hp_ is null));
            return hq_;
        }


        CqlInterval<CqlDate> bd_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hr_ = @this?.period;
            return hr_;
        }

        IEnumerable<CqlInterval<CqlDate>> be_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bb_, bc_, bd_);
        IEnumerable<CqlInterval<CqlDate>> bf_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, be_);
        IEnumerable<CqlInterval<CqlDate>> bg_ = context.Operators.Union<CqlInterval<CqlDate>>(ar_, bf_);
        IEnumerable<CqlInterval<CqlDate>> bh_ = context.Operators.Union<CqlInterval<CqlDate>>(ad_, bg_);

        bool? bi_(MedicationRequest MR) {
            IEnumerable<Medication> hs_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ht_(Medication M) {
                string hv_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType hw_ = MR?.Medication;
                object hx_ = context.Operators.LateBoundProperty<object>(hw_, "reference");
                object hy_ = context.Operators.LateBoundProperty<object>(hx_, "value");
                IEnumerable<string> hz_ = context.Operators.Split((string)hy_, "/");
                string ia_ = context.Operators.Last<string>(hz_);
                bool? ib_ = context.Operators.Equal(hv_, ia_);
                CodeableConcept ic_ = M?.Code;
                CqlConcept id_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ic_);
                CqlValueSet ie_ = this.Lisdexamfetamine(context);
                bool? if_ = context.Operators.ConceptInValueSet(id_, ie_);
                bool? ig_ = context.Operators.And(ib_, if_);
                return ig_;
            }

            bool? hu_ = context.Operators.WhereAny<Medication>(hs_, ht_);
            return hu_;
        }

        IEnumerable<MedicationRequest> bj_ = context.Operators.Where<MedicationRequest>(a_, bi_);
        CqlValueSet bk_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> bl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bm_ = context.Operators.Union<MedicationRequest>(bj_, bl_);
        IEnumerable<MedicationRequest> bn_ = Status_1_15_000.Instance.isMedicationOrder(context, bm_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? bo_(MedicationRequest LisdexamfetamineMed) {
            CqlInterval<CqlDate> ih_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate ii_ = context.Operators.Start(ih_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ij_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ih_, ii_);
            return ij_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bp_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bn_, bo_);

        object bq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate ik_ = @this?.periodStart;
            return ik_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> br_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bs_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> il_ = @this?.period;
            bool? im_ = context.Operators.Not((bool?)(il_ is null));
            return im_;
        }


        CqlInterval<CqlDate> bt_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> in_ = @this?.period;
            return in_;
        }

        IEnumerable<CqlInterval<CqlDate>> bu_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(br_, bs_, bt_);
        IEnumerable<CqlInterval<CqlDate>> bv_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, bu_);

        bool? bw_(MedicationRequest MR) {
            IEnumerable<Medication> io_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ip_(Medication M) {
                string ir_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType is_ = MR?.Medication;
                object it_ = context.Operators.LateBoundProperty<object>(is_, "reference");
                object iu_ = context.Operators.LateBoundProperty<object>(it_, "value");
                IEnumerable<string> iv_ = context.Operators.Split((string)iu_, "/");
                string iw_ = context.Operators.Last<string>(iv_);
                bool? ix_ = context.Operators.Equal(ir_, iw_);
                CodeableConcept iy_ = M?.Code;
                CqlConcept iz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, iy_);
                CqlValueSet ja_ = this.Methylphenidate(context);
                bool? jb_ = context.Operators.ConceptInValueSet(iz_, ja_);
                bool? jc_ = context.Operators.And(ix_, jb_);
                return jc_;
            }

            bool? iq_ = context.Operators.WhereAny<Medication>(io_, ip_);
            return iq_;
        }

        IEnumerable<MedicationRequest> bx_ = context.Operators.Where<MedicationRequest>(a_, bw_);
        CqlValueSet by_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> bz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, by_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bx_, bz_);
        IEnumerable<MedicationRequest> cb_ = Status_1_15_000.Instance.isMedicationOrder(context, ca_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cc_(MedicationRequest MethylphenidateMed) {
            CqlInterval<CqlDate> jd_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate je_ = context.Operators.Start(jd_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jf_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jd_, je_);
            return jf_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cd_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cb_, cc_);

        object ce_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate jg_ = @this?.periodStart;
            return jg_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jh_ = @this?.period;
            bool? ji_ = context.Operators.Not((bool?)(jh_ is null));
            return ji_;
        }


        CqlInterval<CqlDate> ch_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jj_ = @this?.period;
            return jj_;
        }

        IEnumerable<CqlInterval<CqlDate>> ci_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cf_, cg_, ch_);
        IEnumerable<CqlInterval<CqlDate>> cj_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ci_);
        IEnumerable<CqlInterval<CqlDate>> ck_ = context.Operators.Union<CqlInterval<CqlDate>>(bv_, cj_);
        IEnumerable<CqlInterval<CqlDate>> cl_ = context.Operators.Union<CqlInterval<CqlDate>>(bh_, ck_);

        bool? cm_(MedicationRequest MR) {
            IEnumerable<Medication> jk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jl_(Medication M) {
                string jn_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType jo_ = MR?.Medication;
                object jp_ = context.Operators.LateBoundProperty<object>(jo_, "reference");
                object jq_ = context.Operators.LateBoundProperty<object>(jp_, "value");
                IEnumerable<string> jr_ = context.Operators.Split((string)jq_, "/");
                string js_ = context.Operators.Last<string>(jr_);
                bool? jt_ = context.Operators.Equal(jn_, js_);
                CodeableConcept ju_ = M?.Code;
                CqlConcept jv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ju_);
                CqlValueSet jw_ = this.Guanfacine_Medications(context);
                bool? jx_ = context.Operators.ConceptInValueSet(jv_, jw_);
                bool? jy_ = context.Operators.And(jt_, jx_);
                return jy_;
            }

            bool? jm_ = context.Operators.WhereAny<Medication>(jk_, jl_);
            return jm_;
        }

        IEnumerable<MedicationRequest> cn_ = context.Operators.Where<MedicationRequest>(a_, cm_);
        CqlValueSet co_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> cp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cq_ = context.Operators.Union<MedicationRequest>(cn_, cp_);
        IEnumerable<MedicationRequest> cr_ = Status_1_15_000.Instance.isMedicationOrder(context, cq_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cs_(MedicationRequest GuanfacineMed) {
            CqlInterval<CqlDate> jz_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate ka_ = context.Operators.Start(jz_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kb_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jz_, ka_);
            return kb_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ct_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cr_, cs_);

        object cu_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate kc_ = @this?.periodStart;
            return kc_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cw_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> kd_ = @this?.period;
            bool? ke_ = context.Operators.Not((bool?)(kd_ is null));
            return ke_;
        }


        CqlInterval<CqlDate> cx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> kf_ = @this?.period;
            return kf_;
        }

        IEnumerable<CqlInterval<CqlDate>> cy_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cv_, cw_, cx_);
        IEnumerable<CqlInterval<CqlDate>> cz_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, cy_);

        bool? da_(MedicationRequest MR) {
            IEnumerable<Medication> kg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kh_(Medication M) {
                string kj_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType kk_ = MR?.Medication;
                object kl_ = context.Operators.LateBoundProperty<object>(kk_, "reference");
                object km_ = context.Operators.LateBoundProperty<object>(kl_, "value");
                IEnumerable<string> kn_ = context.Operators.Split((string)km_, "/");
                string ko_ = context.Operators.Last<string>(kn_);
                bool? kp_ = context.Operators.Equal(kj_, ko_);
                CodeableConcept kq_ = M?.Code;
                CqlConcept kr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kq_);
                CqlCode ks_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept kt_ = context.Operators.ConvertCodeToConcept(ks_);
                bool? ku_ = context.Operators.Equivalent(kr_, kt_);
                bool? kv_ = context.Operators.And(kp_, ku_);
                return kv_;
            }

            bool? ki_ = context.Operators.WhereAny<Medication>(kg_, kh_);
            return ki_;
        }

        IEnumerable<MedicationRequest> db_ = context.Operators.Where<MedicationRequest>(a_, da_);
        CqlCode dc_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> dd_ = context.Operators.ToList<CqlCode>(dc_);
        IEnumerable<MedicationRequest> de_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, dd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(db_, de_);
        IEnumerable<MedicationRequest> dg_ = Status_1_15_000.Instance.isMedicationOrder(context, df_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dh_(MedicationRequest MethamphetamineMed) {
            CqlInterval<CqlDate> kw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate kx_ = context.Operators.Start(kw_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ky_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kw_, kx_);
            return ky_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> di_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dg_, dh_);

        object dj_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate kz_ = @this?.periodStart;
            return kz_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(di_, dj_, System.ComponentModel.ListSortDirection.Ascending);

        bool? dl_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> la_ = @this?.period;
            bool? lb_ = context.Operators.Not((bool?)(la_ is null));
            return lb_;
        }


        CqlInterval<CqlDate> dm_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> lc_ = @this?.period;
            return lc_;
        }

        IEnumerable<CqlInterval<CqlDate>> dn_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dk_, dl_, dm_);
        IEnumerable<CqlInterval<CqlDate>> do_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, dn_);
        IEnumerable<CqlInterval<CqlDate>> dp_ = context.Operators.Union<CqlInterval<CqlDate>>(cz_, do_);
        IEnumerable<CqlInterval<CqlDate>> dq_ = context.Operators.Union<CqlInterval<CqlDate>>(cl_, dp_);

        bool? dr_(MedicationRequest MR) {
            IEnumerable<Medication> ld_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? le_(Medication M) {
                string lg_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType lh_ = MR?.Medication;
                object li_ = context.Operators.LateBoundProperty<object>(lh_, "reference");
                object lj_ = context.Operators.LateBoundProperty<object>(li_, "value");
                IEnumerable<string> lk_ = context.Operators.Split((string)lj_, "/");
                string ll_ = context.Operators.Last<string>(lk_);
                bool? lm_ = context.Operators.Equal(lg_, ll_);
                CodeableConcept ln_ = M?.Code;
                CqlConcept lo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ln_);
                CqlValueSet lp_ = this.Viloxazine(context);
                bool? lq_ = context.Operators.ConceptInValueSet(lo_, lp_);
                bool? lr_ = context.Operators.And(lm_, lq_);
                return lr_;
            }

            bool? lf_ = context.Operators.WhereAny<Medication>(ld_, le_);
            return lf_;
        }

        IEnumerable<MedicationRequest> ds_ = context.Operators.Where<MedicationRequest>(a_, dr_);
        CqlValueSet dt_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> du_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dv_ = context.Operators.Union<MedicationRequest>(ds_, du_);
        IEnumerable<MedicationRequest> dw_ = Status_1_15_000.Instance.isMedicationOrder(context, dv_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dx_(MedicationRequest ViloxazineMed) {
            CqlInterval<CqlDate> ls_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ViloxazineMed);
            CqlDate lt_ = context.Operators.Start(ls_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lu_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ls_, lt_);
            return lu_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dy_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dw_, dx_);

        object dz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate lv_ = @this?.periodStart;
            return lv_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ea_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dy_, dz_, System.ComponentModel.ListSortDirection.Ascending);

        bool? eb_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> lw_ = @this?.period;
            bool? lx_ = context.Operators.Not((bool?)(lw_ is null));
            return lx_;
        }


        CqlInterval<CqlDate> ec_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ly_ = @this?.period;
            return ly_;
        }

        IEnumerable<CqlInterval<CqlDate>> ed_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ea_, eb_, ec_);
        IEnumerable<CqlInterval<CqlDate>> ee_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ed_);
        IEnumerable<CqlInterval<CqlDate>> ef_ = context.Operators.Union<CqlInterval<CqlDate>>(dq_, ee_);

        CqlInterval<CqlDate> eg_(CqlInterval<CqlDate> ADHDMedication) {
            CqlDate lz_ = this.IPSD(context);
            CqlQuantity ma_ = context.Operators.Quantity(300m, "days");
            CqlDate mb_ = context.Operators.Add(lz_, ma_);
            CqlInterval<CqlDate> mc_ = context.Operators.Interval(lz_, mb_, true, true);
            CqlInterval<CqlDate> md_ = context.Operators.Intersect<CqlDate>(ADHDMedication, mc_);
            return md_;
        }

        IEnumerable<CqlInterval<CqlDate>> eh_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(ef_, eg_);
        return eh_;
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
            Period g_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            CqlInterval<CqlDate> i_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, h_);
            CqlDate j_ = context.Operators.Start(i_);
            CqlDate k_ = this.IPSD(context);
            CqlQuantity l_ = context.Operators.Quantity(31m, "days");
            CqlDate m_ = context.Operators.Add(k_, l_);
            CqlQuantity n_ = context.Operators.Quantity(300m, "days");
            CqlDate o_ = context.Operators.Add(k_, n_);
            CqlInterval<CqlDate> p_ = context.Operators.Interval(m_, o_, true, true);
            bool? q_ = context.Operators.In<CqlDate>(j_, p_, "day");
            return q_;
        }


        CqlDate d_(Encounter ValidNumeratorEncounter) {
            Period r_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            return u_;
        }

        IEnumerable<CqlDate> e_ = context.Operators.WhereSelect<Encounter, CqlDate>(b_, c_, d_);
        IEnumerable<CqlDate> f_ = context.Operators.Distinct<CqlDate>(e_);
        return f_;
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
            Period h_ = VirtualEnc?.Period;
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


        CqlDate e_(Encounter VirtualEnc) {
            Period s_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            return v_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Encounter, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        return g_;
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
            IEnumerable<CqlDate> i_ = this.Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);

            bool? j_(CqlDate Encounter2) {
                bool? l_ = context.Operators.Not((bool?)(Encounter1 is null));
                bool? m_ = context.Operators.Not((bool?)(Encounter2 is null));
                bool? n_ = context.Operators.And(l_, m_);
                bool? o_ = context.Operators.Equivalent(Encounter1, Encounter2);
                bool? p_ = context.Operators.Not(o_);
                bool? q_ = context.Operators.And(n_, p_);
                return q_;
            }

            bool? k_ = context.Operators.WhereAny<CqlDate>(i_, j_);
            return k_;
        }

        bool? f_ = context.Operators.WhereAny<CqlDate>(d_, e_);
        bool? g_ = context.Operators.Or(c_, f_);
        bool? h_ = context.Operators.And(b_, g_);
        return h_;
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
