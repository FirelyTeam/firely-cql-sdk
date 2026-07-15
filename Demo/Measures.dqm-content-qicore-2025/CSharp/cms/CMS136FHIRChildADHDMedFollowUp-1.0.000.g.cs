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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
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
        CqlValueSet a_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> bu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bv_(Medication M) {
                object by_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ca_ = context.Operators.Split((string)bz_, "/");
                string cb_ = context.Operators.Last<string>(ca_);
                bool? cc_ = context.Operators.Equal(by_, cb_);
                CodeableConcept cd_ = M?.Code;
                CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                CqlValueSet cf_ = this.Atomoxetine(context);
                bool? cg_ = context.Operators.ConceptInValueSet(ce_, cf_);
                bool? ch_ = context.Operators.And(cc_, cg_);
                return ch_;
            }

            IEnumerable<Medication> bw_ = context.Operators.Where<Medication>(bu_, bv_);
            bool? bx_ = context.Operators.Exists<Medication>(bw_);
            return bx_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? j_(MedicationRequest MR) {
            IEnumerable<Medication> ci_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cj_(Medication M) {
                object cm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> co_ = context.Operators.Split((string)cn_, "/");
                string cp_ = context.Operators.Last<string>(co_);
                bool? cq_ = context.Operators.Equal(cm_, cp_);
                CodeableConcept cr_ = M?.Code;
                CqlConcept cs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cr_);
                CqlValueSet ct_ = this.Clonidine(context);
                bool? cu_ = context.Operators.ConceptInValueSet(cs_, ct_);
                bool? cv_ = context.Operators.And(cq_, cu_);
                return cv_;
            }

            IEnumerable<Medication> ck_ = context.Operators.Where<Medication>(ci_, cj_);
            bool? cl_ = context.Operators.Exists<Medication>(ck_);
            return cl_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        CqlValueSet n_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? q_(MedicationRequest MR) {
            IEnumerable<Medication> cw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cx_(Medication M) {
                object da_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object db_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dc_ = context.Operators.Split((string)db_, "/");
                string dd_ = context.Operators.Last<string>(dc_);
                bool? de_ = context.Operators.Equal(da_, dd_);
                CodeableConcept df_ = M?.Code;
                CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
                CqlValueSet dh_ = this.Dexmethylphenidate(context);
                bool? di_ = context.Operators.ConceptInValueSet(dg_, dh_);
                bool? dj_ = context.Operators.And(de_, di_);
                return dj_;
            }

            IEnumerable<Medication> cy_ = context.Operators.Where<Medication>(cw_, cx_);
            bool? cz_ = context.Operators.Exists<Medication>(cy_);
            return cz_;
        }

        IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(c_, q_);
        IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(o_, r_);
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(m_, s_);
        CqlValueSet u_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? x_(MedicationRequest MR) {
            IEnumerable<Medication> dk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dl_(Medication M) {
                object do_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dq_ = context.Operators.Split((string)dp_, "/");
                string dr_ = context.Operators.Last<string>(dq_);
                bool? ds_ = context.Operators.Equal(do_, dr_);
                CodeableConcept dt_ = M?.Code;
                CqlConcept du_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dt_);
                CqlValueSet dv_ = this.Dextroamphetamine(context);
                bool? dw_ = context.Operators.ConceptInValueSet(du_, dv_);
                bool? dx_ = context.Operators.And(ds_, dw_);
                return dx_;
            }

            IEnumerable<Medication> dm_ = context.Operators.Where<Medication>(dk_, dl_);
            bool? dn_ = context.Operators.Exists<Medication>(dm_);
            return dn_;
        }

        IEnumerable<MedicationRequest> y_ = context.Operators.Where<MedicationRequest>(c_, x_);
        IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(v_, y_);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(t_, z_);
        CqlValueSet ab_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> ac_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> dy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dz_(Medication M) {
                object ec_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ed_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ee_ = context.Operators.Split((string)ed_, "/");
                string ef_ = context.Operators.Last<string>(ee_);
                bool? eg_ = context.Operators.Equal(ec_, ef_);
                CodeableConcept eh_ = M?.Code;
                CqlConcept ei_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eh_);
                CqlValueSet ej_ = this.Lisdexamfetamine(context);
                bool? ek_ = context.Operators.ConceptInValueSet(ei_, ej_);
                bool? el_ = context.Operators.And(eg_, ek_);
                return el_;
            }

            IEnumerable<Medication> ea_ = context.Operators.Where<Medication>(dy_, dz_);
            bool? eb_ = context.Operators.Exists<Medication>(ea_);
            return eb_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(c_, ae_);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ac_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(aa_, ag_);
        CqlCode ai_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> aj_ = context.Operators.ToList<CqlCode>(ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, aj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? am_(MedicationRequest MR) {
            IEnumerable<Medication> em_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? en_(Medication M) {
                object eq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object er_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> es_ = context.Operators.Split((string)er_, "/");
                string et_ = context.Operators.Last<string>(es_);
                bool? eu_ = context.Operators.Equal(eq_, et_);
                CodeableConcept ev_ = M?.Code;
                CqlConcept ew_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ev_);
                CqlCode ex_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept ey_ = context.Operators.ConvertCodeToConcept(ex_);
                bool? ez_ = context.Operators.Equivalent(ew_, ey_);
                bool? fa_ = context.Operators.And(eu_, ez_);
                return fa_;
            }

            IEnumerable<Medication> eo_ = context.Operators.Where<Medication>(em_, en_);
            bool? ep_ = context.Operators.Exists<Medication>(eo_);
            return ep_;
        }

        IEnumerable<MedicationRequest> an_ = context.Operators.Where<MedicationRequest>(c_, am_);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Union<MedicationRequest>(ak_, an_);
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(ah_, ao_);
        CqlValueSet aq_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> ar_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? at_(MedicationRequest MR) {
            IEnumerable<Medication> fb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fc_(Medication M) {
                object ff_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fh_ = context.Operators.Split((string)fg_, "/");
                string fi_ = context.Operators.Last<string>(fh_);
                bool? fj_ = context.Operators.Equal(ff_, fi_);
                CodeableConcept fk_ = M?.Code;
                CqlConcept fl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fk_);
                CqlValueSet fm_ = this.Methylphenidate(context);
                bool? fn_ = context.Operators.ConceptInValueSet(fl_, fm_);
                bool? fo_ = context.Operators.And(fj_, fn_);
                return fo_;
            }

            IEnumerable<Medication> fd_ = context.Operators.Where<Medication>(fb_, fc_);
            bool? fe_ = context.Operators.Exists<Medication>(fd_);
            return fe_;
        }

        IEnumerable<MedicationRequest> au_ = context.Operators.Where<MedicationRequest>(c_, at_);
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(ar_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(ap_, av_);
        CqlValueSet ax_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ba_(MedicationRequest MR) {
            IEnumerable<Medication> fp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fq_(Medication M) {
                object ft_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fv_ = context.Operators.Split((string)fu_, "/");
                string fw_ = context.Operators.Last<string>(fv_);
                bool? fx_ = context.Operators.Equal(ft_, fw_);
                CodeableConcept fy_ = M?.Code;
                CqlConcept fz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fy_);
                CqlValueSet ga_ = this.Guanfacine_Medications(context);
                bool? gb_ = context.Operators.ConceptInValueSet(fz_, ga_);
                bool? gc_ = context.Operators.And(fx_, gb_);
                return gc_;
            }

            IEnumerable<Medication> fr_ = context.Operators.Where<Medication>(fp_, fq_);
            bool? fs_ = context.Operators.Exists<Medication>(fr_);
            return fs_;
        }

        IEnumerable<MedicationRequest> bb_ = context.Operators.Where<MedicationRequest>(c_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ay_, bb_);
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(aw_, bc_);
        CqlValueSet be_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> bf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bh_(MedicationRequest MR) {
            IEnumerable<Medication> gd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ge_(Medication M) {
                object gh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gj_ = context.Operators.Split((string)gi_, "/");
                string gk_ = context.Operators.Last<string>(gj_);
                bool? gl_ = context.Operators.Equal(gh_, gk_);
                CodeableConcept gm_ = M?.Code;
                CqlConcept gn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gm_);
                CqlValueSet go_ = this.Viloxazine(context);
                bool? gp_ = context.Operators.ConceptInValueSet(gn_, go_);
                bool? gq_ = context.Operators.And(gl_, gp_);
                return gq_;
            }

            IEnumerable<Medication> gf_ = context.Operators.Where<Medication>(gd_, ge_);
            bool? gg_ = context.Operators.Exists<Medication>(gf_);
            return gg_;
        }

        IEnumerable<MedicationRequest> bi_ = context.Operators.Where<MedicationRequest>(c_, bh_);
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bf_, bi_);
        IEnumerable<MedicationRequest> bk_ = context.Operators.Union<MedicationRequest>(bd_, bj_);
        IEnumerable<MedicationRequest> bl_ = Status_1_15_000.Instance.isMedicationOrder(context, bk_);

        bool? bm_(MedicationRequest ADHDMedications) {
            CqlInterval<CqlDate> gr_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate gs_ = context.Operators.Start(gr_);
            CqlDateTime gt_ = context.Operators.ConvertDateToDateTime(gs_);
            CqlInterval<CqlDateTime> gu_ = this.Intake_Period(context);
            bool? gv_ = context.Operators.In<CqlDateTime>(gt_, gu_, (string)default);
            return gv_;
        }

        IEnumerable<MedicationRequest> bn_ = context.Operators.Where<MedicationRequest>(bl_, bm_);

        bool? bo_(MedicationRequest ADHDMedicationOrder) {
            CqlValueSet gw_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> gx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? gz_(MedicationRequest MR) {
                IEnumerable<Medication> jm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? jn_(Medication M) {
                    object jq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object jr_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> js_ = context.Operators.Split((string)jr_, "/");
                    string jt_ = context.Operators.Last<string>(js_);
                    bool? ju_ = context.Operators.Equal(jq_, jt_);
                    CodeableConcept jv_ = M?.Code;
                    CqlConcept jw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jv_);
                    CqlValueSet jx_ = this.Atomoxetine(context);
                    bool? jy_ = context.Operators.ConceptInValueSet(jw_, jx_);
                    bool? jz_ = context.Operators.And(ju_, jy_);
                    return jz_;
                }

                IEnumerable<Medication> jo_ = context.Operators.Where<Medication>(jm_, jn_);
                bool? jp_ = context.Operators.Exists<Medication>(jo_);
                return jp_;
            }

            IEnumerable<MedicationRequest> ha_ = context.Operators.Where<MedicationRequest>(gy_, gz_);
            IEnumerable<MedicationRequest> hb_ = context.Operators.Union<MedicationRequest>(gx_, ha_);
            CqlValueSet hc_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> hd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? hf_(MedicationRequest MR) {
                IEnumerable<Medication> ka_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? kb_(Medication M) {
                    object ke_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object kf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> kg_ = context.Operators.Split((string)kf_, "/");
                    string kh_ = context.Operators.Last<string>(kg_);
                    bool? ki_ = context.Operators.Equal(ke_, kh_);
                    CodeableConcept kj_ = M?.Code;
                    CqlConcept kk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kj_);
                    CqlValueSet kl_ = this.Clonidine(context);
                    bool? km_ = context.Operators.ConceptInValueSet(kk_, kl_);
                    bool? kn_ = context.Operators.And(ki_, km_);
                    return kn_;
                }

                IEnumerable<Medication> kc_ = context.Operators.Where<Medication>(ka_, kb_);
                bool? kd_ = context.Operators.Exists<Medication>(kc_);
                return kd_;
            }

            IEnumerable<MedicationRequest> hg_ = context.Operators.Where<MedicationRequest>(gy_, hf_);
            IEnumerable<MedicationRequest> hh_ = context.Operators.Union<MedicationRequest>(hd_, hg_);
            IEnumerable<MedicationRequest> hi_ = context.Operators.Union<MedicationRequest>(hb_, hh_);
            CqlValueSet hj_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> hk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? hm_(MedicationRequest MR) {
                IEnumerable<Medication> ko_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? kp_(Medication M) {
                    object ks_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object kt_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> ku_ = context.Operators.Split((string)kt_, "/");
                    string kv_ = context.Operators.Last<string>(ku_);
                    bool? kw_ = context.Operators.Equal(ks_, kv_);
                    CodeableConcept kx_ = M?.Code;
                    CqlConcept ky_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kx_);
                    CqlValueSet kz_ = this.Dexmethylphenidate(context);
                    bool? la_ = context.Operators.ConceptInValueSet(ky_, kz_);
                    bool? lb_ = context.Operators.And(kw_, la_);
                    return lb_;
                }

                IEnumerable<Medication> kq_ = context.Operators.Where<Medication>(ko_, kp_);
                bool? kr_ = context.Operators.Exists<Medication>(kq_);
                return kr_;
            }

            IEnumerable<MedicationRequest> hn_ = context.Operators.Where<MedicationRequest>(gy_, hm_);
            IEnumerable<MedicationRequest> ho_ = context.Operators.Union<MedicationRequest>(hk_, hn_);
            IEnumerable<MedicationRequest> hp_ = context.Operators.Union<MedicationRequest>(hi_, ho_);
            CqlValueSet hq_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> hr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? ht_(MedicationRequest MR) {
                IEnumerable<Medication> lc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ld_(Medication M) {
                    object lg_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object lh_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> li_ = context.Operators.Split((string)lh_, "/");
                    string lj_ = context.Operators.Last<string>(li_);
                    bool? lk_ = context.Operators.Equal(lg_, lj_);
                    CodeableConcept ll_ = M?.Code;
                    CqlConcept lm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ll_);
                    CqlValueSet ln_ = this.Dextroamphetamine(context);
                    bool? lo_ = context.Operators.ConceptInValueSet(lm_, ln_);
                    bool? lp_ = context.Operators.And(lk_, lo_);
                    return lp_;
                }

                IEnumerable<Medication> le_ = context.Operators.Where<Medication>(lc_, ld_);
                bool? lf_ = context.Operators.Exists<Medication>(le_);
                return lf_;
            }

            IEnumerable<MedicationRequest> hu_ = context.Operators.Where<MedicationRequest>(gy_, ht_);
            IEnumerable<MedicationRequest> hv_ = context.Operators.Union<MedicationRequest>(hr_, hu_);
            IEnumerable<MedicationRequest> hw_ = context.Operators.Union<MedicationRequest>(hp_, hv_);
            CqlValueSet hx_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> hy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? ia_(MedicationRequest MR) {
                IEnumerable<Medication> lq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? lr_(Medication M) {
                    object lu_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object lv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> lw_ = context.Operators.Split((string)lv_, "/");
                    string lx_ = context.Operators.Last<string>(lw_);
                    bool? ly_ = context.Operators.Equal(lu_, lx_);
                    CodeableConcept lz_ = M?.Code;
                    CqlConcept ma_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lz_);
                    CqlValueSet mb_ = this.Lisdexamfetamine(context);
                    bool? mc_ = context.Operators.ConceptInValueSet(ma_, mb_);
                    bool? md_ = context.Operators.And(ly_, mc_);
                    return md_;
                }

                IEnumerable<Medication> ls_ = context.Operators.Where<Medication>(lq_, lr_);
                bool? lt_ = context.Operators.Exists<Medication>(ls_);
                return lt_;
            }

            IEnumerable<MedicationRequest> ib_ = context.Operators.Where<MedicationRequest>(gy_, ia_);
            IEnumerable<MedicationRequest> ic_ = context.Operators.Union<MedicationRequest>(hy_, ib_);
            IEnumerable<MedicationRequest> id_ = context.Operators.Union<MedicationRequest>(hw_, ic_);
            CqlCode ie_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> if_ = context.Operators.ToList<CqlCode>(ie_);
            IEnumerable<MedicationRequest> ig_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, if_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? ii_(MedicationRequest MR) {
                IEnumerable<Medication> me_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? mf_(Medication M) {
                    object mi_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object mj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> mk_ = context.Operators.Split((string)mj_, "/");
                    string ml_ = context.Operators.Last<string>(mk_);
                    bool? mm_ = context.Operators.Equal(mi_, ml_);
                    CodeableConcept mn_ = M?.Code;
                    CqlConcept mo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mn_);
                    CqlCode mp_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                    CqlConcept mq_ = context.Operators.ConvertCodeToConcept(mp_);
                    bool? mr_ = context.Operators.Equivalent(mo_, mq_);
                    bool? ms_ = context.Operators.And(mm_, mr_);
                    return ms_;
                }

                IEnumerable<Medication> mg_ = context.Operators.Where<Medication>(me_, mf_);
                bool? mh_ = context.Operators.Exists<Medication>(mg_);
                return mh_;
            }

            IEnumerable<MedicationRequest> ij_ = context.Operators.Where<MedicationRequest>(gy_, ii_);
            IEnumerable<MedicationRequest> ik_ = context.Operators.Union<MedicationRequest>(ig_, ij_);
            IEnumerable<MedicationRequest> il_ = context.Operators.Union<MedicationRequest>(id_, ik_);
            CqlValueSet im_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> in_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, im_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? ip_(MedicationRequest MR) {
                IEnumerable<Medication> mt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? mu_(Medication M) {
                    object mx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object my_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> mz_ = context.Operators.Split((string)my_, "/");
                    string na_ = context.Operators.Last<string>(mz_);
                    bool? nb_ = context.Operators.Equal(mx_, na_);
                    CodeableConcept nc_ = M?.Code;
                    CqlConcept nd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nc_);
                    CqlValueSet ne_ = this.Methylphenidate(context);
                    bool? nf_ = context.Operators.ConceptInValueSet(nd_, ne_);
                    bool? ng_ = context.Operators.And(nb_, nf_);
                    return ng_;
                }

                IEnumerable<Medication> mv_ = context.Operators.Where<Medication>(mt_, mu_);
                bool? mw_ = context.Operators.Exists<Medication>(mv_);
                return mw_;
            }

            IEnumerable<MedicationRequest> iq_ = context.Operators.Where<MedicationRequest>(gy_, ip_);
            IEnumerable<MedicationRequest> ir_ = context.Operators.Union<MedicationRequest>(in_, iq_);
            IEnumerable<MedicationRequest> is_ = context.Operators.Union<MedicationRequest>(il_, ir_);
            CqlValueSet it_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> iu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, it_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? iw_(MedicationRequest MR) {
                IEnumerable<Medication> nh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ni_(Medication M) {
                    object nl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object nm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> nn_ = context.Operators.Split((string)nm_, "/");
                    string no_ = context.Operators.Last<string>(nn_);
                    bool? np_ = context.Operators.Equal(nl_, no_);
                    CodeableConcept nq_ = M?.Code;
                    CqlConcept nr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nq_);
                    CqlValueSet ns_ = this.Guanfacine_Medications(context);
                    bool? nt_ = context.Operators.ConceptInValueSet(nr_, ns_);
                    bool? nu_ = context.Operators.And(np_, nt_);
                    return nu_;
                }

                IEnumerable<Medication> nj_ = context.Operators.Where<Medication>(nh_, ni_);
                bool? nk_ = context.Operators.Exists<Medication>(nj_);
                return nk_;
            }

            IEnumerable<MedicationRequest> ix_ = context.Operators.Where<MedicationRequest>(gy_, iw_);
            IEnumerable<MedicationRequest> iy_ = context.Operators.Union<MedicationRequest>(iu_, ix_);
            IEnumerable<MedicationRequest> iz_ = context.Operators.Union<MedicationRequest>(is_, iy_);
            CqlValueSet ja_ = this.Viloxazine(context);
            IEnumerable<MedicationRequest> jb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ja_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? jd_(MedicationRequest MR) {
                IEnumerable<Medication> nv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? nw_(Medication M) {
                    object nz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object oa_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> ob_ = context.Operators.Split((string)oa_, "/");
                    string oc_ = context.Operators.Last<string>(ob_);
                    bool? od_ = context.Operators.Equal(nz_, oc_);
                    CodeableConcept oe_ = M?.Code;
                    CqlConcept of_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, oe_);
                    CqlValueSet og_ = this.Viloxazine(context);
                    bool? oh_ = context.Operators.ConceptInValueSet(of_, og_);
                    bool? oi_ = context.Operators.And(od_, oh_);
                    return oi_;
                }

                IEnumerable<Medication> nx_ = context.Operators.Where<Medication>(nv_, nw_);
                bool? ny_ = context.Operators.Exists<Medication>(nx_);
                return ny_;
            }

            IEnumerable<MedicationRequest> je_ = context.Operators.Where<MedicationRequest>(gy_, jd_);
            IEnumerable<MedicationRequest> jf_ = context.Operators.Union<MedicationRequest>(jb_, je_);
            IEnumerable<MedicationRequest> jg_ = context.Operators.Union<MedicationRequest>(iz_, jf_);
            IEnumerable<MedicationRequest> jh_ = Status_1_15_000.Instance.isMedicationActive(context, jg_);

            bool? ji_(MedicationRequest ActiveADHDMedication) {
                CqlInterval<CqlDate> oj_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> ok_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate ol_ = context.Operators.Start(ok_);
                CqlDateTime om_ = context.Operators.ConvertDateToDateTime(ol_);
                CqlDate on_ = context.Operators.DateFrom(om_);
                CqlQuantity oo_ = context.Operators.Quantity(120m, "days");
                CqlDate op_ = context.Operators.Subtract(on_, oo_);
                CqlDate or_ = context.Operators.Start(ok_);
                CqlDateTime os_ = context.Operators.ConvertDateToDateTime(or_);
                CqlDate ot_ = context.Operators.DateFrom(os_);
                CqlInterval<CqlDate> ou_ = context.Operators.Interval(op_, ot_, true, false);
                bool? ov_ = context.Operators.Overlaps(oj_, ou_, (string)default);
                return ov_;
            }

            IEnumerable<MedicationRequest> jj_ = context.Operators.Where<MedicationRequest>(jh_, ji_);
            bool? jk_ = context.Operators.Exists<MedicationRequest>(jj_);
            bool? jl_ = context.Operators.Not(jk_);
            return jl_;
        }

        IEnumerable<MedicationRequest> bp_ = context.Operators.Where<MedicationRequest>(bn_, bo_);

        (CqlTupleMetadata, CqlDate startDate)? bq_(MedicationRequest QualifyingMed) {
            CqlInterval<CqlDate> ow_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate ox_ = context.Operators.Start(ow_);
            (CqlTupleMetadata, CqlDate startDate)? oy_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, ox_);
            return oy_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> br_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(bp_, bq_);

        object bs_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate oz_ = @this?.startDate;
            return oz_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> bt_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(br_, bs_, System.ComponentModel.ListSortDirection.Ascending);
        return bt_;
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
            CqlInterval<CqlDate> s_ = context.Operators.Interval(q_, o_, true, true);
            Period t_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlInterval<CqlDate> v_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, u_);
            bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(s_, v_, "day");
            return w_;
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
            CqlQuantity j_ = context.Operators.Quantity(30m, "days");
            CqlDate k_ = context.Operators.Add(h_, j_);
            CqlInterval<CqlDate> l_ = context.Operators.Interval(h_, k_, false, true);
            bool? m_ = context.Operators.In<CqlDate>(g_, l_, "day");
            bool? o_ = context.Operators.Not((bool?)(h_ is null));
            bool? p_ = context.Operators.And(m_, o_);
            return p_;
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
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(Condition NarcolepsyDx) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NarcolepsyDx);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, (string)default);
            return m_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
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
            CqlQuantity k_ = context.Operators.Quantity(30m, "days");
            CqlDate l_ = context.Operators.Add(i_, k_);
            CqlInterval<CqlDate> m_ = context.Operators.Interval(i_, l_, false, true);
            bool? n_ = context.Operators.In<CqlDate>(h_, m_, "day");
            bool? p_ = context.Operators.Not((bool?)(i_ is null));
            bool? q_ = context.Operators.And(n_, p_);
            return q_;
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
        CqlValueSet a_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> ez_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fa_(Medication M) {
                object fd_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fe_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ff_ = context.Operators.Split((string)fe_, "/");
                string fg_ = context.Operators.Last<string>(ff_);
                bool? fh_ = context.Operators.Equal(fd_, fg_);
                CodeableConcept fi_ = M?.Code;
                CqlConcept fj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fi_);
                CqlValueSet fk_ = this.Atomoxetine(context);
                bool? fl_ = context.Operators.ConceptInValueSet(fj_, fk_);
                bool? fm_ = context.Operators.And(fh_, fl_);
                return fm_;
            }

            IEnumerable<Medication> fb_ = context.Operators.Where<Medication>(ez_, fa_);
            bool? fc_ = context.Operators.Exists<Medication>(fb_);
            return fc_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? h_(MedicationRequest AtomoxetineMed) {
            CqlInterval<CqlDate> fn_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate fp_ = context.Operators.Start(fn_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fq_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fn_, fp_);
            return fq_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(g_, h_);

        object j_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate fr_ = @this?.periodStart;
            return fr_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);

        bool? l_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fs_ = @this?.period;
            bool? ft_ = context.Operators.Not((bool?)(fs_ is null));
            return ft_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> m_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(k_, l_);

        CqlInterval<CqlDate> n_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fu_ = @this?.period;
            return fu_;
        }

        IEnumerable<CqlInterval<CqlDate>> o_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(m_, n_);
        IEnumerable<CqlInterval<CqlDate>> p_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, o_);
        CqlValueSet q_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> r_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? t_(MedicationRequest MR) {
            IEnumerable<Medication> fv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fw_(Medication M) {
                object fz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ga_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gb_ = context.Operators.Split((string)ga_, "/");
                string gc_ = context.Operators.Last<string>(gb_);
                bool? gd_ = context.Operators.Equal(fz_, gc_);
                CodeableConcept ge_ = M?.Code;
                CqlConcept gf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ge_);
                CqlValueSet gg_ = this.Clonidine(context);
                bool? gh_ = context.Operators.ConceptInValueSet(gf_, gg_);
                bool? gi_ = context.Operators.And(gd_, gh_);
                return gi_;
            }

            IEnumerable<Medication> fx_ = context.Operators.Where<Medication>(fv_, fw_);
            bool? fy_ = context.Operators.Exists<Medication>(fx_);
            return fy_;
        }

        IEnumerable<MedicationRequest> u_ = context.Operators.Where<MedicationRequest>(c_, t_);
        IEnumerable<MedicationRequest> v_ = context.Operators.Union<MedicationRequest>(r_, u_);
        IEnumerable<MedicationRequest> w_ = Status_1_15_000.Instance.isMedicationOrder(context, v_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? x_(MedicationRequest ClonidineMed) {
            CqlInterval<CqlDate> gj_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate gl_ = context.Operators.Start(gj_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gm_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gj_, gl_);
            return gm_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> y_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(w_, x_);

        object z_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate gn_ = @this?.periodStart;
            return gn_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> aa_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(y_, z_, System.ComponentModel.ListSortDirection.Ascending);

        bool? ab_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> go_ = @this?.period;
            bool? gp_ = context.Operators.Not((bool?)(go_ is null));
            return gp_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ac_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(aa_, ab_);

        CqlInterval<CqlDate> ad_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gq_ = @this?.period;
            return gq_;
        }

        IEnumerable<CqlInterval<CqlDate>> ae_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ac_, ad_);
        IEnumerable<CqlInterval<CqlDate>> af_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ae_);
        IEnumerable<CqlInterval<CqlDate>> ag_ = context.Operators.Union<CqlInterval<CqlDate>>(p_, af_);
        CqlValueSet ah_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ak_(MedicationRequest MR) {
            IEnumerable<Medication> gr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gs_(Medication M) {
                object gv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gx_ = context.Operators.Split((string)gw_, "/");
                string gy_ = context.Operators.Last<string>(gx_);
                bool? gz_ = context.Operators.Equal(gv_, gy_);
                CodeableConcept ha_ = M?.Code;
                CqlConcept hb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ha_);
                CqlValueSet hc_ = this.Dexmethylphenidate(context);
                bool? hd_ = context.Operators.ConceptInValueSet(hb_, hc_);
                bool? he_ = context.Operators.And(gz_, hd_);
                return he_;
            }

            IEnumerable<Medication> gt_ = context.Operators.Where<Medication>(gr_, gs_);
            bool? gu_ = context.Operators.Exists<Medication>(gt_);
            return gu_;
        }

        IEnumerable<MedicationRequest> al_ = context.Operators.Where<MedicationRequest>(c_, ak_);
        IEnumerable<MedicationRequest> am_ = context.Operators.Union<MedicationRequest>(ai_, al_);
        IEnumerable<MedicationRequest> an_ = Status_1_15_000.Instance.isMedicationOrder(context, am_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ao_(MedicationRequest DexmethylphenidateMed) {
            CqlInterval<CqlDate> hf_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate hh_ = context.Operators.Start(hf_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hi_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, hf_, hh_);
            return hi_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ap_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(an_, ao_);

        object aq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate hj_ = @this?.periodStart;
            return hj_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ar_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);

        bool? as_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hk_ = @this?.period;
            bool? hl_ = context.Operators.Not((bool?)(hk_ is null));
            return hl_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> at_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ar_, as_);

        CqlInterval<CqlDate> au_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hm_ = @this?.period;
            return hm_;
        }

        IEnumerable<CqlInterval<CqlDate>> av_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(at_, au_);
        IEnumerable<CqlInterval<CqlDate>> aw_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, av_);
        CqlValueSet ax_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ba_(MedicationRequest MR) {
            IEnumerable<Medication> hn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ho_(Medication M) {
                object hr_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hs_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ht_ = context.Operators.Split((string)hs_, "/");
                string hu_ = context.Operators.Last<string>(ht_);
                bool? hv_ = context.Operators.Equal(hr_, hu_);
                CodeableConcept hw_ = M?.Code;
                CqlConcept hx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hw_);
                CqlValueSet hy_ = this.Dextroamphetamine(context);
                bool? hz_ = context.Operators.ConceptInValueSet(hx_, hy_);
                bool? ia_ = context.Operators.And(hv_, hz_);
                return ia_;
            }

            IEnumerable<Medication> hp_ = context.Operators.Where<Medication>(hn_, ho_);
            bool? hq_ = context.Operators.Exists<Medication>(hp_);
            return hq_;
        }

        IEnumerable<MedicationRequest> bb_ = context.Operators.Where<MedicationRequest>(c_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ay_, bb_);
        IEnumerable<MedicationRequest> bd_ = Status_1_15_000.Instance.isMedicationOrder(context, bc_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? be_(MedicationRequest DextroamphetamineMed) {
            CqlInterval<CqlDate> ib_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate id_ = context.Operators.Start(ib_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ie_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ib_, id_);
            return ie_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bf_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bd_, be_);

        object bg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate if_ = @this?.periodStart;
            return if_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bi_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ig_ = @this?.period;
            bool? ih_ = context.Operators.Not((bool?)(ig_ is null));
            return ih_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bj_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bh_, bi_);

        CqlInterval<CqlDate> bk_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ii_ = @this?.period;
            return ii_;
        }

        IEnumerable<CqlInterval<CqlDate>> bl_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bj_, bk_);
        IEnumerable<CqlInterval<CqlDate>> bm_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, bl_);
        IEnumerable<CqlInterval<CqlDate>> bn_ = context.Operators.Union<CqlInterval<CqlDate>>(aw_, bm_);
        IEnumerable<CqlInterval<CqlDate>> bo_ = context.Operators.Union<CqlInterval<CqlDate>>(ag_, bn_);
        CqlValueSet bp_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> bq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bs_(MedicationRequest MR) {
            IEnumerable<Medication> ij_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ik_(Medication M) {
                object in_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object io_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ip_ = context.Operators.Split((string)io_, "/");
                string iq_ = context.Operators.Last<string>(ip_);
                bool? ir_ = context.Operators.Equal(in_, iq_);
                CodeableConcept is_ = M?.Code;
                CqlConcept it_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, is_);
                CqlValueSet iu_ = this.Lisdexamfetamine(context);
                bool? iv_ = context.Operators.ConceptInValueSet(it_, iu_);
                bool? iw_ = context.Operators.And(ir_, iv_);
                return iw_;
            }

            IEnumerable<Medication> il_ = context.Operators.Where<Medication>(ij_, ik_);
            bool? im_ = context.Operators.Exists<Medication>(il_);
            return im_;
        }

        IEnumerable<MedicationRequest> bt_ = context.Operators.Where<MedicationRequest>(c_, bs_);
        IEnumerable<MedicationRequest> bu_ = context.Operators.Union<MedicationRequest>(bq_, bt_);
        IEnumerable<MedicationRequest> bv_ = Status_1_15_000.Instance.isMedicationOrder(context, bu_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? bw_(MedicationRequest LisdexamfetamineMed) {
            CqlInterval<CqlDate> ix_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate iz_ = context.Operators.Start(ix_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ja_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ix_, iz_);
            return ja_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bx_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bv_, bw_);

        object by_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate jb_ = @this?.periodStart;
            return jb_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bz_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bx_, by_, System.ComponentModel.ListSortDirection.Ascending);

        bool? ca_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jc_ = @this?.period;
            bool? jd_ = context.Operators.Not((bool?)(jc_ is null));
            return jd_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cb_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bz_, ca_);

        CqlInterval<CqlDate> cc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> je_ = @this?.period;
            return je_;
        }

        IEnumerable<CqlInterval<CqlDate>> cd_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cb_, cc_);
        IEnumerable<CqlInterval<CqlDate>> ce_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, cd_);
        CqlValueSet cf_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> cg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ci_(MedicationRequest MR) {
            IEnumerable<Medication> jf_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jg_(Medication M) {
                object jj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object jk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jl_ = context.Operators.Split((string)jk_, "/");
                string jm_ = context.Operators.Last<string>(jl_);
                bool? jn_ = context.Operators.Equal(jj_, jm_);
                CodeableConcept jo_ = M?.Code;
                CqlConcept jp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jo_);
                CqlValueSet jq_ = this.Methylphenidate(context);
                bool? jr_ = context.Operators.ConceptInValueSet(jp_, jq_);
                bool? js_ = context.Operators.And(jn_, jr_);
                return js_;
            }

            IEnumerable<Medication> jh_ = context.Operators.Where<Medication>(jf_, jg_);
            bool? ji_ = context.Operators.Exists<Medication>(jh_);
            return ji_;
        }

        IEnumerable<MedicationRequest> cj_ = context.Operators.Where<MedicationRequest>(c_, ci_);
        IEnumerable<MedicationRequest> ck_ = context.Operators.Union<MedicationRequest>(cg_, cj_);
        IEnumerable<MedicationRequest> cl_ = Status_1_15_000.Instance.isMedicationOrder(context, ck_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cm_(MedicationRequest MethylphenidateMed) {
            CqlInterval<CqlDate> jt_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate jv_ = context.Operators.Start(jt_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jw_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jt_, jv_);
            return jw_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cn_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cl_, cm_);

        object co_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate jx_ = @this?.periodStart;
            return jx_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cp_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cn_, co_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jy_ = @this?.period;
            bool? jz_ = context.Operators.Not((bool?)(jy_ is null));
            return jz_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cr_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cp_, cq_);

        CqlInterval<CqlDate> cs_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ka_ = @this?.period;
            return ka_;
        }

        IEnumerable<CqlInterval<CqlDate>> ct_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cr_, cs_);
        IEnumerable<CqlInterval<CqlDate>> cu_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ct_);
        IEnumerable<CqlInterval<CqlDate>> cv_ = context.Operators.Union<CqlInterval<CqlDate>>(ce_, cu_);
        IEnumerable<CqlInterval<CqlDate>> cw_ = context.Operators.Union<CqlInterval<CqlDate>>(bo_, cv_);
        CqlValueSet cx_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> cy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? da_(MedicationRequest MR) {
            IEnumerable<Medication> kb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kc_(Medication M) {
                object kf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kh_ = context.Operators.Split((string)kg_, "/");
                string ki_ = context.Operators.Last<string>(kh_);
                bool? kj_ = context.Operators.Equal(kf_, ki_);
                CodeableConcept kk_ = M?.Code;
                CqlConcept kl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kk_);
                CqlValueSet km_ = this.Guanfacine_Medications(context);
                bool? kn_ = context.Operators.ConceptInValueSet(kl_, km_);
                bool? ko_ = context.Operators.And(kj_, kn_);
                return ko_;
            }

            IEnumerable<Medication> kd_ = context.Operators.Where<Medication>(kb_, kc_);
            bool? ke_ = context.Operators.Exists<Medication>(kd_);
            return ke_;
        }

        IEnumerable<MedicationRequest> db_ = context.Operators.Where<MedicationRequest>(c_, da_);
        IEnumerable<MedicationRequest> dc_ = context.Operators.Union<MedicationRequest>(cy_, db_);
        IEnumerable<MedicationRequest> dd_ = Status_1_15_000.Instance.isMedicationOrder(context, dc_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? de_(MedicationRequest GuanfacineMed) {
            CqlInterval<CqlDate> kp_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate kr_ = context.Operators.Start(kp_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ks_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kp_, kr_);
            return ks_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> df_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dd_, de_);

        object dg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate kt_ = @this?.periodStart;
            return kt_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(df_, dg_, System.ComponentModel.ListSortDirection.Ascending);

        bool? di_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ku_ = @this?.period;
            bool? kv_ = context.Operators.Not((bool?)(ku_ is null));
            return kv_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dj_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dh_, di_);

        CqlInterval<CqlDate> dk_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> kw_ = @this?.period;
            return kw_;
        }

        IEnumerable<CqlInterval<CqlDate>> dl_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dj_, dk_);
        IEnumerable<CqlInterval<CqlDate>> dm_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, dl_);
        CqlCode dn_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> do_ = context.Operators.ToList<CqlCode>(dn_);
        IEnumerable<MedicationRequest> dp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, do_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? dr_(MedicationRequest MR) {
            IEnumerable<Medication> kx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ky_(Medication M) {
                object lb_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lc_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ld_ = context.Operators.Split((string)lc_, "/");
                string le_ = context.Operators.Last<string>(ld_);
                bool? lf_ = context.Operators.Equal(lb_, le_);
                CodeableConcept lg_ = M?.Code;
                CqlConcept lh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lg_);
                CqlCode li_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept lj_ = context.Operators.ConvertCodeToConcept(li_);
                bool? lk_ = context.Operators.Equivalent(lh_, lj_);
                bool? ll_ = context.Operators.And(lf_, lk_);
                return ll_;
            }

            IEnumerable<Medication> kz_ = context.Operators.Where<Medication>(kx_, ky_);
            bool? la_ = context.Operators.Exists<Medication>(kz_);
            return la_;
        }

        IEnumerable<MedicationRequest> ds_ = context.Operators.Where<MedicationRequest>(c_, dr_);
        IEnumerable<MedicationRequest> dt_ = context.Operators.Union<MedicationRequest>(dp_, ds_);
        IEnumerable<MedicationRequest> du_ = Status_1_15_000.Instance.isMedicationOrder(context, dt_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dv_(MedicationRequest MethamphetamineMed) {
            CqlInterval<CqlDate> lm_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate lo_ = context.Operators.Start(lm_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lp_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, lm_, lo_);
            return lp_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dw_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(du_, dv_);

        object dx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate lq_ = @this?.periodStart;
            return lq_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dy_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dw_, dx_, System.ComponentModel.ListSortDirection.Ascending);

        bool? dz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> lr_ = @this?.period;
            bool? ls_ = context.Operators.Not((bool?)(lr_ is null));
            return ls_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ea_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dy_, dz_);

        CqlInterval<CqlDate> eb_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> lt_ = @this?.period;
            return lt_;
        }

        IEnumerable<CqlInterval<CqlDate>> ec_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ea_, eb_);
        IEnumerable<CqlInterval<CqlDate>> ed_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ec_);
        IEnumerable<CqlInterval<CqlDate>> ee_ = context.Operators.Union<CqlInterval<CqlDate>>(dm_, ed_);
        IEnumerable<CqlInterval<CqlDate>> ef_ = context.Operators.Union<CqlInterval<CqlDate>>(cw_, ee_);
        CqlValueSet eg_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> eh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, eg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ej_(MedicationRequest MR) {
            IEnumerable<Medication> lu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lv_(Medication M) {
                object ly_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ma_ = context.Operators.Split((string)lz_, "/");
                string mb_ = context.Operators.Last<string>(ma_);
                bool? mc_ = context.Operators.Equal(ly_, mb_);
                CodeableConcept md_ = M?.Code;
                CqlConcept me_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, md_);
                CqlValueSet mf_ = this.Viloxazine(context);
                bool? mg_ = context.Operators.ConceptInValueSet(me_, mf_);
                bool? mh_ = context.Operators.And(mc_, mg_);
                return mh_;
            }

            IEnumerable<Medication> lw_ = context.Operators.Where<Medication>(lu_, lv_);
            bool? lx_ = context.Operators.Exists<Medication>(lw_);
            return lx_;
        }

        IEnumerable<MedicationRequest> ek_ = context.Operators.Where<MedicationRequest>(c_, ej_);
        IEnumerable<MedicationRequest> el_ = context.Operators.Union<MedicationRequest>(eh_, ek_);
        IEnumerable<MedicationRequest> em_ = Status_1_15_000.Instance.isMedicationOrder(context, el_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? en_(MedicationRequest ViloxazineMed) {
            CqlInterval<CqlDate> mi_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ViloxazineMed);
            CqlDate mk_ = context.Operators.Start(mi_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ml_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, mi_, mk_);
            return ml_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> eo_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(em_, en_);

        object ep_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate mm_ = @this?.periodStart;
            return mm_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> eq_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(eo_, ep_, System.ComponentModel.ListSortDirection.Ascending);

        bool? er_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> mn_ = @this?.period;
            bool? mo_ = context.Operators.Not((bool?)(mn_ is null));
            return mo_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> es_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(eq_, er_);

        CqlInterval<CqlDate> et_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> mp_ = @this?.period;
            return mp_;
        }

        IEnumerable<CqlInterval<CqlDate>> eu_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(es_, et_);
        IEnumerable<CqlInterval<CqlDate>> ev_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, eu_);
        IEnumerable<CqlInterval<CqlDate>> ew_ = context.Operators.Union<CqlInterval<CqlDate>>(ef_, ev_);

        CqlInterval<CqlDate> ex_(CqlInterval<CqlDate> ADHDMedication) {
            CqlDate mq_ = this.IPSD(context);
            CqlQuantity ms_ = context.Operators.Quantity(300m, "days");
            CqlDate mt_ = context.Operators.Add(mq_, ms_);
            CqlInterval<CqlDate> mu_ = context.Operators.Interval(mq_, mt_, true, true);
            CqlInterval<CqlDate> mv_ = context.Operators.Intersect<CqlDate>(ADHDMedication, mu_);
            return mv_;
        }

        IEnumerable<CqlInterval<CqlDate>> ey_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(ew_, ex_);
        return ey_;
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
            CqlQuantity j_ = context.Operators.Quantity(300m, "days");
            CqlDate k_ = context.Operators.Add(h_, j_);
            CqlInterval<CqlDate> l_ = context.Operators.Interval(h_, k_, false, true);
            bool? m_ = context.Operators.In<CqlDate>(g_, l_, "day");
            bool? o_ = context.Operators.Not((bool?)(h_ is null));
            bool? p_ = context.Operators.And(m_, o_);
            return p_;
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
            CqlQuantity p_ = context.Operators.Quantity(300m, "days");
            CqlDate q_ = context.Operators.Add(l_, p_);
            CqlInterval<CqlDate> r_ = context.Operators.Interval(n_, q_, true, true);
            bool? s_ = context.Operators.In<CqlDate>(k_, r_, "day");
            return s_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        CqlDate e_(Encounter ValidNumeratorEncounter) {
            Period t_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlDate w_ = context.Operators.DateFrom(v_);
            return w_;
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
            CqlQuantity q_ = context.Operators.Quantity(300m, "days");
            CqlDate r_ = context.Operators.Add(m_, q_);
            CqlInterval<CqlDate> s_ = context.Operators.Interval(o_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDate>(l_, s_, "day");
            return t_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        CqlDate f_(Encounter VirtualEnc) {
            Period u_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlDate x_ = context.Operators.DateFrom(w_);
            return x_;
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
