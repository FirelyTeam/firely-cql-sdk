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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
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
                Id bo_ = M?.IdElement;
                string bp_ = bo_?.Value;
                DataType bq_ = MR?.Medication;
                FhirString bs_ = bq_ is ResourceReference br_ ? br_.ReferenceElement : null;
                string bt_ = bs_?.Value;
                IEnumerable<string> bu_ = context.Operators.Split(bt_, "/");
                string bv_ = context.Operators.Last<string>(bu_);
                bool? bw_ = context.Operators.Equal(bp_, bv_);
                CodeableConcept bx_ = M?.Code;
                CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                CqlValueSet bz_ = this.Atomoxetine(context);
                bool? ca_ = context.Operators.ConceptInValueSet(by_, bz_);
                bool? cb_ = context.Operators.And(bw_, ca_);
                return cb_;
            }

            bool? bn_ = context.Operators.WhereAny<Medication>(bl_, bm_);
            return bn_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> cc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cd_(Medication M) {
                Id cf_ = M?.IdElement;
                string cg_ = cf_?.Value;
                DataType ch_ = MR?.Medication;
                FhirString cj_ = ch_ is ResourceReference ci_ ? ci_.ReferenceElement : null;
                string ck_ = cj_?.Value;
                IEnumerable<string> cl_ = context.Operators.Split(ck_, "/");
                string cm_ = context.Operators.Last<string>(cl_);
                bool? cn_ = context.Operators.Equal(cg_, cm_);
                CodeableConcept co_ = M?.Code;
                CqlConcept cp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, co_);
                CqlValueSet cq_ = this.Clonidine(context);
                bool? cr_ = context.Operators.ConceptInValueSet(cp_, cq_);
                bool? cs_ = context.Operators.And(cn_, cr_);
                return cs_;
            }

            bool? ce_ = context.Operators.WhereAny<Medication>(cc_, cd_);
            return ce_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> ct_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cu_(Medication M) {
                Id cw_ = M?.IdElement;
                string cx_ = cw_?.Value;
                DataType cy_ = MR?.Medication;
                FhirString da_ = cy_ is ResourceReference cz_ ? cz_.ReferenceElement : null;
                string db_ = da_?.Value;
                IEnumerable<string> dc_ = context.Operators.Split(db_, "/");
                string dd_ = context.Operators.Last<string>(dc_);
                bool? de_ = context.Operators.Equal(cx_, dd_);
                CodeableConcept df_ = M?.Code;
                CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
                CqlValueSet dh_ = this.Dexmethylphenidate(context);
                bool? di_ = context.Operators.ConceptInValueSet(dg_, dh_);
                bool? dj_ = context.Operators.And(de_, di_);
                return dj_;
            }

            bool? cv_ = context.Operators.WhereAny<Medication>(ct_, cu_);
            return cv_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(a_, m_);
        CqlValueSet o_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest MR) {
            IEnumerable<Medication> dk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dl_(Medication M) {
                Id dn_ = M?.IdElement;
                string do_ = dn_?.Value;
                DataType dp_ = MR?.Medication;
                FhirString dr_ = dp_ is ResourceReference dq_ ? dq_.ReferenceElement : null;
                string ds_ = dr_?.Value;
                IEnumerable<string> dt_ = context.Operators.Split(ds_, "/");
                string du_ = context.Operators.Last<string>(dt_);
                bool? dv_ = context.Operators.Equal(do_, du_);
                CodeableConcept dw_ = M?.Code;
                CqlConcept dx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dw_);
                CqlValueSet dy_ = this.Dextroamphetamine(context);
                bool? dz_ = context.Operators.ConceptInValueSet(dx_, dy_);
                bool? ea_ = context.Operators.And(dv_, dz_);
                return ea_;
            }

            bool? dm_ = context.Operators.WhereAny<Medication>(dk_, dl_);
            return dm_;
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(a_, s_);
        CqlValueSet u_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> w_ = context.Operators.Union<MedicationRequest>(t_, v_);
        IEnumerable<MedicationRequest> x_ = context.Operators.Union<MedicationRequest>(r_, w_);

        bool? y_(MedicationRequest MR) {
            IEnumerable<Medication> eb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ec_(Medication M) {
                Id ee_ = M?.IdElement;
                string ef_ = ee_?.Value;
                DataType eg_ = MR?.Medication;
                FhirString ei_ = eg_ is ResourceReference eh_ ? eh_.ReferenceElement : null;
                string ej_ = ei_?.Value;
                IEnumerable<string> ek_ = context.Operators.Split(ej_, "/");
                string el_ = context.Operators.Last<string>(ek_);
                bool? em_ = context.Operators.Equal(ef_, el_);
                CodeableConcept en_ = M?.Code;
                CqlConcept eo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, en_);
                CqlValueSet ep_ = this.Lisdexamfetamine(context);
                bool? eq_ = context.Operators.ConceptInValueSet(eo_, ep_);
                bool? er_ = context.Operators.And(em_, eq_);
                return er_;
            }

            bool? ed_ = context.Operators.WhereAny<Medication>(eb_, ec_);
            return ed_;
        }

        IEnumerable<MedicationRequest> z_ = context.Operators.Where<MedicationRequest>(a_, y_);
        CqlValueSet aa_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(z_, ab_);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(x_, ac_);

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> es_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? et_(Medication M) {
                Id ev_ = M?.IdElement;
                string ew_ = ev_?.Value;
                DataType ex_ = MR?.Medication;
                FhirString ez_ = ex_ is ResourceReference ey_ ? ey_.ReferenceElement : null;
                string fa_ = ez_?.Value;
                IEnumerable<string> fb_ = context.Operators.Split(fa_, "/");
                string fc_ = context.Operators.Last<string>(fb_);
                bool? fd_ = context.Operators.Equal(ew_, fc_);
                CodeableConcept fe_ = M?.Code;
                CqlConcept ff_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fe_);
                CqlCode fg_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept fh_ = context.Operators.ConvertCodeToConcept(fg_);
                bool? fi_ = context.Operators.Equivalent(ff_, fh_);
                bool? fj_ = context.Operators.And(fd_, fi_);
                return fj_;
            }

            bool? eu_ = context.Operators.WhereAny<Medication>(es_, et_);
            return eu_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(a_, ae_);
        CqlCode ag_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(af_, ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ad_, aj_);

        bool? al_(MedicationRequest MR) {
            IEnumerable<Medication> fk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fl_(Medication M) {
                Id fn_ = M?.IdElement;
                string fo_ = fn_?.Value;
                DataType fp_ = MR?.Medication;
                FhirString fr_ = fp_ is ResourceReference fq_ ? fq_.ReferenceElement : null;
                string fs_ = fr_?.Value;
                IEnumerable<string> ft_ = context.Operators.Split(fs_, "/");
                string fu_ = context.Operators.Last<string>(ft_);
                bool? fv_ = context.Operators.Equal(fo_, fu_);
                CodeableConcept fw_ = M?.Code;
                CqlConcept fx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fw_);
                CqlValueSet fy_ = this.Methylphenidate(context);
                bool? fz_ = context.Operators.ConceptInValueSet(fx_, fy_);
                bool? ga_ = context.Operators.And(fv_, fz_);
                return ga_;
            }

            bool? fm_ = context.Operators.WhereAny<Medication>(fk_, fl_);
            return fm_;
        }

        IEnumerable<MedicationRequest> am_ = context.Operators.Where<MedicationRequest>(a_, al_);
        CqlValueSet an_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Union<MedicationRequest>(ak_, ap_);

        bool? ar_(MedicationRequest MR) {
            IEnumerable<Medication> gb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gc_(Medication M) {
                Id ge_ = M?.IdElement;
                string gf_ = ge_?.Value;
                DataType gg_ = MR?.Medication;
                FhirString gi_ = gg_ is ResourceReference gh_ ? gh_.ReferenceElement : null;
                string gj_ = gi_?.Value;
                IEnumerable<string> gk_ = context.Operators.Split(gj_, "/");
                string gl_ = context.Operators.Last<string>(gk_);
                bool? gm_ = context.Operators.Equal(gf_, gl_);
                CodeableConcept gn_ = M?.Code;
                CqlConcept go_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gn_);
                CqlValueSet gp_ = this.Guanfacine_Medications(context);
                bool? gq_ = context.Operators.ConceptInValueSet(go_, gp_);
                bool? gr_ = context.Operators.And(gm_, gq_);
                return gr_;
            }

            bool? gd_ = context.Operators.WhereAny<Medication>(gb_, gc_);
            return gd_;
        }

        IEnumerable<MedicationRequest> as_ = context.Operators.Where<MedicationRequest>(a_, ar_);
        CqlValueSet at_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(aq_, av_);

        bool? ax_(MedicationRequest MR) {
            IEnumerable<Medication> gs_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gt_(Medication M) {
                Id gv_ = M?.IdElement;
                string gw_ = gv_?.Value;
                DataType gx_ = MR?.Medication;
                FhirString gz_ = gx_ is ResourceReference gy_ ? gy_.ReferenceElement : null;
                string ha_ = gz_?.Value;
                IEnumerable<string> hb_ = context.Operators.Split(ha_, "/");
                string hc_ = context.Operators.Last<string>(hb_);
                bool? hd_ = context.Operators.Equal(gw_, hc_);
                CodeableConcept he_ = M?.Code;
                CqlConcept hf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, he_);
                CqlValueSet hg_ = this.Viloxazine(context);
                bool? hh_ = context.Operators.ConceptInValueSet(hf_, hg_);
                bool? hi_ = context.Operators.And(hd_, hh_);
                return hi_;
            }

            bool? gu_ = context.Operators.WhereAny<Medication>(gs_, gt_);
            return gu_;
        }

        IEnumerable<MedicationRequest> ay_ = context.Operators.Where<MedicationRequest>(a_, ax_);
        CqlValueSet az_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, az_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(ay_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(aw_, bb_);
        IEnumerable<MedicationRequest> bd_ = Status_1_15_000.Instance.isMedicationOrder(context, bc_);

        bool? be_(MedicationRequest ADHDMedications) {
            CqlInterval<CqlDate> hj_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate hk_ = context.Operators.Start(hj_);
            CqlDateTime hl_ = context.Operators.ConvertDateToDateTime(hk_);
            CqlInterval<CqlDateTime> hm_ = this.Intake_Period(context);
            bool? hn_ = context.Operators.In<CqlDateTime>(hl_, hm_, (string)default);
            return hn_;
        }

        IEnumerable<MedicationRequest> bf_ = context.Operators.Where<MedicationRequest>(bd_, be_);

        bool? bg_(MedicationRequest ADHDMedicationOrder) {
            IEnumerable<MedicationRequest> ho_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? hp_(MedicationRequest MR) {
                IEnumerable<Medication> jv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? jw_(Medication M) {
                    Id jy_ = M?.IdElement;
                    string jz_ = jy_?.Value;
                    DataType ka_ = MR?.Medication;
                    FhirString kc_ = ka_ is ResourceReference kb_ ? kb_.ReferenceElement : null;
                    string kd_ = kc_?.Value;
                    IEnumerable<string> ke_ = context.Operators.Split(kd_, "/");
                    string kf_ = context.Operators.Last<string>(ke_);
                    bool? kg_ = context.Operators.Equal(jz_, kf_);
                    CodeableConcept kh_ = M?.Code;
                    CqlConcept ki_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kh_);
                    CqlValueSet kj_ = this.Atomoxetine(context);
                    bool? kk_ = context.Operators.ConceptInValueSet(ki_, kj_);
                    bool? kl_ = context.Operators.And(kg_, kk_);
                    return kl_;
                }

                bool? jx_ = context.Operators.WhereAny<Medication>(jv_, jw_);
                return jx_;
            }

            IEnumerable<MedicationRequest> hq_ = context.Operators.Where<MedicationRequest>(ho_, hp_);
            CqlValueSet hr_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> hs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ht_ = context.Operators.Union<MedicationRequest>(hq_, hs_);

            bool? hu_(MedicationRequest MR) {
                IEnumerable<Medication> km_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? kn_(Medication M) {
                    Id kp_ = M?.IdElement;
                    string kq_ = kp_?.Value;
                    DataType kr_ = MR?.Medication;
                    FhirString kt_ = kr_ is ResourceReference ks_ ? ks_.ReferenceElement : null;
                    string ku_ = kt_?.Value;
                    IEnumerable<string> kv_ = context.Operators.Split(ku_, "/");
                    string kw_ = context.Operators.Last<string>(kv_);
                    bool? kx_ = context.Operators.Equal(kq_, kw_);
                    CodeableConcept ky_ = M?.Code;
                    CqlConcept kz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ky_);
                    CqlValueSet la_ = this.Clonidine(context);
                    bool? lb_ = context.Operators.ConceptInValueSet(kz_, la_);
                    bool? lc_ = context.Operators.And(kx_, lb_);
                    return lc_;
                }

                bool? ko_ = context.Operators.WhereAny<Medication>(km_, kn_);
                return ko_;
            }

            IEnumerable<MedicationRequest> hv_ = context.Operators.Where<MedicationRequest>(ho_, hu_);
            CqlValueSet hw_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> hx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hy_ = context.Operators.Union<MedicationRequest>(hv_, hx_);
            IEnumerable<MedicationRequest> hz_ = context.Operators.Union<MedicationRequest>(ht_, hy_);

            bool? ia_(MedicationRequest MR) {
                IEnumerable<Medication> ld_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? le_(Medication M) {
                    Id lg_ = M?.IdElement;
                    string lh_ = lg_?.Value;
                    DataType li_ = MR?.Medication;
                    FhirString lk_ = li_ is ResourceReference lj_ ? lj_.ReferenceElement : null;
                    string ll_ = lk_?.Value;
                    IEnumerable<string> lm_ = context.Operators.Split(ll_, "/");
                    string ln_ = context.Operators.Last<string>(lm_);
                    bool? lo_ = context.Operators.Equal(lh_, ln_);
                    CodeableConcept lp_ = M?.Code;
                    CqlConcept lq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lp_);
                    CqlValueSet lr_ = this.Dexmethylphenidate(context);
                    bool? ls_ = context.Operators.ConceptInValueSet(lq_, lr_);
                    bool? lt_ = context.Operators.And(lo_, ls_);
                    return lt_;
                }

                bool? lf_ = context.Operators.WhereAny<Medication>(ld_, le_);
                return lf_;
            }

            IEnumerable<MedicationRequest> ib_ = context.Operators.Where<MedicationRequest>(ho_, ia_);
            CqlValueSet ic_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> id_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ic_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ie_ = context.Operators.Union<MedicationRequest>(ib_, id_);
            IEnumerable<MedicationRequest> if_ = context.Operators.Union<MedicationRequest>(hz_, ie_);

            bool? ig_(MedicationRequest MR) {
                IEnumerable<Medication> lu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? lv_(Medication M) {
                    Id lx_ = M?.IdElement;
                    string ly_ = lx_?.Value;
                    DataType lz_ = MR?.Medication;
                    FhirString mb_ = lz_ is ResourceReference ma_ ? ma_.ReferenceElement : null;
                    string mc_ = mb_?.Value;
                    IEnumerable<string> md_ = context.Operators.Split(mc_, "/");
                    string me_ = context.Operators.Last<string>(md_);
                    bool? mf_ = context.Operators.Equal(ly_, me_);
                    CodeableConcept mg_ = M?.Code;
                    CqlConcept mh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mg_);
                    CqlValueSet mi_ = this.Dextroamphetamine(context);
                    bool? mj_ = context.Operators.ConceptInValueSet(mh_, mi_);
                    bool? mk_ = context.Operators.And(mf_, mj_);
                    return mk_;
                }

                bool? lw_ = context.Operators.WhereAny<Medication>(lu_, lv_);
                return lw_;
            }

            IEnumerable<MedicationRequest> ih_ = context.Operators.Where<MedicationRequest>(ho_, ig_);
            CqlValueSet ii_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> ij_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ii_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ik_ = context.Operators.Union<MedicationRequest>(ih_, ij_);
            IEnumerable<MedicationRequest> il_ = context.Operators.Union<MedicationRequest>(if_, ik_);

            bool? im_(MedicationRequest MR) {
                IEnumerable<Medication> ml_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? mm_(Medication M) {
                    Id mo_ = M?.IdElement;
                    string mp_ = mo_?.Value;
                    DataType mq_ = MR?.Medication;
                    FhirString ms_ = mq_ is ResourceReference mr_ ? mr_.ReferenceElement : null;
                    string mt_ = ms_?.Value;
                    IEnumerable<string> mu_ = context.Operators.Split(mt_, "/");
                    string mv_ = context.Operators.Last<string>(mu_);
                    bool? mw_ = context.Operators.Equal(mp_, mv_);
                    CodeableConcept mx_ = M?.Code;
                    CqlConcept my_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mx_);
                    CqlValueSet mz_ = this.Lisdexamfetamine(context);
                    bool? na_ = context.Operators.ConceptInValueSet(my_, mz_);
                    bool? nb_ = context.Operators.And(mw_, na_);
                    return nb_;
                }

                bool? mn_ = context.Operators.WhereAny<Medication>(ml_, mm_);
                return mn_;
            }

            IEnumerable<MedicationRequest> in_ = context.Operators.Where<MedicationRequest>(ho_, im_);
            CqlValueSet io_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> ip_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, io_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> iq_ = context.Operators.Union<MedicationRequest>(in_, ip_);
            IEnumerable<MedicationRequest> ir_ = context.Operators.Union<MedicationRequest>(il_, iq_);

            bool? is_(MedicationRequest MR) {
                IEnumerable<Medication> nc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? nd_(Medication M) {
                    Id nf_ = M?.IdElement;
                    string ng_ = nf_?.Value;
                    DataType nh_ = MR?.Medication;
                    FhirString nj_ = nh_ is ResourceReference ni_ ? ni_.ReferenceElement : null;
                    string nk_ = nj_?.Value;
                    IEnumerable<string> nl_ = context.Operators.Split(nk_, "/");
                    string nm_ = context.Operators.Last<string>(nl_);
                    bool? nn_ = context.Operators.Equal(ng_, nm_);
                    CodeableConcept no_ = M?.Code;
                    CqlConcept np_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, no_);
                    CqlCode nq_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                    CqlConcept nr_ = context.Operators.ConvertCodeToConcept(nq_);
                    bool? ns_ = context.Operators.Equivalent(np_, nr_);
                    bool? nt_ = context.Operators.And(nn_, ns_);
                    return nt_;
                }

                bool? ne_ = context.Operators.WhereAny<Medication>(nc_, nd_);
                return ne_;
            }

            IEnumerable<MedicationRequest> it_ = context.Operators.Where<MedicationRequest>(ho_, is_);
            CqlCode iu_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> iv_ = context.Operators.ToList<CqlCode>(iu_);
            IEnumerable<MedicationRequest> iw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, iv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ix_ = context.Operators.Union<MedicationRequest>(it_, iw_);
            IEnumerable<MedicationRequest> iy_ = context.Operators.Union<MedicationRequest>(ir_, ix_);

            bool? iz_(MedicationRequest MR) {
                IEnumerable<Medication> nu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? nv_(Medication M) {
                    Id nx_ = M?.IdElement;
                    string ny_ = nx_?.Value;
                    DataType nz_ = MR?.Medication;
                    FhirString ob_ = nz_ is ResourceReference oa_ ? oa_.ReferenceElement : null;
                    string oc_ = ob_?.Value;
                    IEnumerable<string> od_ = context.Operators.Split(oc_, "/");
                    string oe_ = context.Operators.Last<string>(od_);
                    bool? of_ = context.Operators.Equal(ny_, oe_);
                    CodeableConcept og_ = M?.Code;
                    CqlConcept oh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, og_);
                    CqlValueSet oi_ = this.Methylphenidate(context);
                    bool? oj_ = context.Operators.ConceptInValueSet(oh_, oi_);
                    bool? ok_ = context.Operators.And(of_, oj_);
                    return ok_;
                }

                bool? nw_ = context.Operators.WhereAny<Medication>(nu_, nv_);
                return nw_;
            }

            IEnumerable<MedicationRequest> ja_ = context.Operators.Where<MedicationRequest>(ho_, iz_);
            CqlValueSet jb_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> jc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jd_ = context.Operators.Union<MedicationRequest>(ja_, jc_);
            IEnumerable<MedicationRequest> je_ = context.Operators.Union<MedicationRequest>(iy_, jd_);

            bool? jf_(MedicationRequest MR) {
                IEnumerable<Medication> ol_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? om_(Medication M) {
                    Id oo_ = M?.IdElement;
                    string op_ = oo_?.Value;
                    DataType oq_ = MR?.Medication;
                    FhirString os_ = oq_ is ResourceReference or_ ? or_.ReferenceElement : null;
                    string ot_ = os_?.Value;
                    IEnumerable<string> ou_ = context.Operators.Split(ot_, "/");
                    string ov_ = context.Operators.Last<string>(ou_);
                    bool? ow_ = context.Operators.Equal(op_, ov_);
                    CodeableConcept ox_ = M?.Code;
                    CqlConcept oy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ox_);
                    CqlValueSet oz_ = this.Guanfacine_Medications(context);
                    bool? pa_ = context.Operators.ConceptInValueSet(oy_, oz_);
                    bool? pb_ = context.Operators.And(ow_, pa_);
                    return pb_;
                }

                bool? on_ = context.Operators.WhereAny<Medication>(ol_, om_);
                return on_;
            }

            IEnumerable<MedicationRequest> jg_ = context.Operators.Where<MedicationRequest>(ho_, jf_);
            CqlValueSet jh_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> ji_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jj_ = context.Operators.Union<MedicationRequest>(jg_, ji_);
            IEnumerable<MedicationRequest> jk_ = context.Operators.Union<MedicationRequest>(je_, jj_);

            bool? jl_(MedicationRequest MR) {
                IEnumerable<Medication> pc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? pd_(Medication M) {
                    Id pf_ = M?.IdElement;
                    string pg_ = pf_?.Value;
                    DataType ph_ = MR?.Medication;
                    FhirString pj_ = ph_ is ResourceReference pi_ ? pi_.ReferenceElement : null;
                    string pk_ = pj_?.Value;
                    IEnumerable<string> pl_ = context.Operators.Split(pk_, "/");
                    string pm_ = context.Operators.Last<string>(pl_);
                    bool? pn_ = context.Operators.Equal(pg_, pm_);
                    CodeableConcept po_ = M?.Code;
                    CqlConcept pp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, po_);
                    CqlValueSet pq_ = this.Viloxazine(context);
                    bool? pr_ = context.Operators.ConceptInValueSet(pp_, pq_);
                    bool? ps_ = context.Operators.And(pn_, pr_);
                    return ps_;
                }

                bool? pe_ = context.Operators.WhereAny<Medication>(pc_, pd_);
                return pe_;
            }

            IEnumerable<MedicationRequest> jm_ = context.Operators.Where<MedicationRequest>(ho_, jl_);
            CqlValueSet jn_ = this.Viloxazine(context);
            IEnumerable<MedicationRequest> jo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jp_ = context.Operators.Union<MedicationRequest>(jm_, jo_);
            IEnumerable<MedicationRequest> jq_ = context.Operators.Union<MedicationRequest>(jk_, jp_);
            IEnumerable<MedicationRequest> jr_ = Status_1_15_000.Instance.isMedicationActive(context, jq_);

            bool? js_(MedicationRequest ActiveADHDMedication) {
                CqlInterval<CqlDate> pt_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> pu_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate pv_ = context.Operators.Start(pu_);
                CqlDateTime pw_ = context.Operators.ConvertDateToDateTime(pv_);
                CqlDate px_ = context.Operators.DateFrom(pw_);
                CqlQuantity py_ = context.Operators.Quantity(120m, "days");
                CqlDate pz_ = context.Operators.Subtract(px_, py_);
                CqlInterval<CqlDate> qa_ = context.Operators.Interval(pz_, px_, true, false);
                bool? qb_ = context.Operators.Overlaps(pt_, qa_, (string)default);
                return qb_;
            }

            bool? jt_ = context.Operators.WhereAny<MedicationRequest>(jr_, js_);
            bool? ju_ = context.Operators.Not(jt_);
            return ju_;
        }


        (CqlTupleMetadata, CqlDate startDate)? bh_(MedicationRequest QualifyingMed) {
            CqlInterval<CqlDate> qc_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate qd_ = context.Operators.Start(qc_);
            (CqlTupleMetadata, CqlDate startDate)? qe_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, qd_);
            return qe_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> bi_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(bf_, bg_, bh_);

        object bj_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate qf_ = @this?.startDate;
            return qf_;
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
                Id el_ = M?.IdElement;
                string em_ = el_?.Value;
                DataType en_ = MR?.Medication;
                FhirString ep_ = en_ is ResourceReference eo_ ? eo_.ReferenceElement : null;
                string eq_ = ep_?.Value;
                IEnumerable<string> er_ = context.Operators.Split(eq_, "/");
                string es_ = context.Operators.Last<string>(er_);
                bool? et_ = context.Operators.Equal(em_, es_);
                CodeableConcept eu_ = M?.Code;
                CqlConcept ev_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eu_);
                CqlValueSet ew_ = this.Atomoxetine(context);
                bool? ex_ = context.Operators.ConceptInValueSet(ev_, ew_);
                bool? ey_ = context.Operators.And(et_, ex_);
                return ey_;
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
            CqlInterval<CqlDate> ez_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate fa_ = context.Operators.Start(ez_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fb_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ez_, fa_);
            return fb_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(g_, h_);

        object j_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate fc_ = @this?.periodStart;
            return fc_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);

        bool? l_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fd_ = @this?.period;
            bool? fe_ = context.Operators.Not((bool?)(fd_ is null));
            return fe_;
        }


        CqlInterval<CqlDate> m_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ff_ = @this?.period;
            return ff_;
        }

        IEnumerable<CqlInterval<CqlDate>> n_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(k_, l_, m_);
        IEnumerable<CqlInterval<CqlDate>> o_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, n_);

        bool? p_(MedicationRequest MR) {
            IEnumerable<Medication> fg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fh_(Medication M) {
                Id fj_ = M?.IdElement;
                string fk_ = fj_?.Value;
                DataType fl_ = MR?.Medication;
                FhirString fn_ = fl_ is ResourceReference fm_ ? fm_.ReferenceElement : null;
                string fo_ = fn_?.Value;
                IEnumerable<string> fp_ = context.Operators.Split(fo_, "/");
                string fq_ = context.Operators.Last<string>(fp_);
                bool? fr_ = context.Operators.Equal(fk_, fq_);
                CodeableConcept fs_ = M?.Code;
                CqlConcept ft_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fs_);
                CqlValueSet fu_ = this.Clonidine(context);
                bool? fv_ = context.Operators.ConceptInValueSet(ft_, fu_);
                bool? fw_ = context.Operators.And(fr_, fv_);
                return fw_;
            }

            bool? fi_ = context.Operators.WhereAny<Medication>(fg_, fh_);
            return fi_;
        }

        IEnumerable<MedicationRequest> q_ = context.Operators.Where<MedicationRequest>(a_, p_);
        CqlValueSet r_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> s_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(q_, s_);
        IEnumerable<MedicationRequest> u_ = Status_1_15_000.Instance.isMedicationOrder(context, t_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? v_(MedicationRequest ClonidineMed) {
            CqlInterval<CqlDate> fx_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate fy_ = context.Operators.Start(fx_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fz_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fx_, fy_);
            return fz_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> w_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(u_, v_);

        object x_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate ga_ = @this?.periodStart;
            return ga_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> y_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);

        bool? z_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gb_ = @this?.period;
            bool? gc_ = context.Operators.Not((bool?)(gb_ is null));
            return gc_;
        }


        CqlInterval<CqlDate> aa_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gd_ = @this?.period;
            return gd_;
        }

        IEnumerable<CqlInterval<CqlDate>> ab_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(y_, z_, aa_);
        IEnumerable<CqlInterval<CqlDate>> ac_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ab_);
        IEnumerable<CqlInterval<CqlDate>> ad_ = context.Operators.Union<CqlInterval<CqlDate>>(o_, ac_);

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> ge_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gf_(Medication M) {
                Id gh_ = M?.IdElement;
                string gi_ = gh_?.Value;
                DataType gj_ = MR?.Medication;
                FhirString gl_ = gj_ is ResourceReference gk_ ? gk_.ReferenceElement : null;
                string gm_ = gl_?.Value;
                IEnumerable<string> gn_ = context.Operators.Split(gm_, "/");
                string go_ = context.Operators.Last<string>(gn_);
                bool? gp_ = context.Operators.Equal(gi_, go_);
                CodeableConcept gq_ = M?.Code;
                CqlConcept gr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gq_);
                CqlValueSet gs_ = this.Dexmethylphenidate(context);
                bool? gt_ = context.Operators.ConceptInValueSet(gr_, gs_);
                bool? gu_ = context.Operators.And(gp_, gt_);
                return gu_;
            }

            bool? gg_ = context.Operators.WhereAny<Medication>(ge_, gf_);
            return gg_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(a_, ae_);
        CqlValueSet ag_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ai_ = context.Operators.Union<MedicationRequest>(af_, ah_);
        IEnumerable<MedicationRequest> aj_ = Status_1_15_000.Instance.isMedicationOrder(context, ai_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ak_(MedicationRequest DexmethylphenidateMed) {
            CqlInterval<CqlDate> gv_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate gw_ = context.Operators.Start(gv_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gx_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gv_, gw_);
            return gx_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> al_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(aj_, ak_);

        object am_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate gy_ = @this?.periodStart;
            return gy_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> an_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);

        bool? ao_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gz_ = @this?.period;
            bool? ha_ = context.Operators.Not((bool?)(gz_ is null));
            return ha_;
        }


        CqlInterval<CqlDate> ap_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hb_ = @this?.period;
            return hb_;
        }

        IEnumerable<CqlInterval<CqlDate>> aq_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(an_, ao_, ap_);
        IEnumerable<CqlInterval<CqlDate>> ar_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, aq_);

        bool? as_(MedicationRequest MR) {
            IEnumerable<Medication> hc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hd_(Medication M) {
                Id hf_ = M?.IdElement;
                string hg_ = hf_?.Value;
                DataType hh_ = MR?.Medication;
                FhirString hj_ = hh_ is ResourceReference hi_ ? hi_.ReferenceElement : null;
                string hk_ = hj_?.Value;
                IEnumerable<string> hl_ = context.Operators.Split(hk_, "/");
                string hm_ = context.Operators.Last<string>(hl_);
                bool? hn_ = context.Operators.Equal(hg_, hm_);
                CodeableConcept ho_ = M?.Code;
                CqlConcept hp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ho_);
                CqlValueSet hq_ = this.Dextroamphetamine(context);
                bool? hr_ = context.Operators.ConceptInValueSet(hp_, hq_);
                bool? hs_ = context.Operators.And(hn_, hr_);
                return hs_;
            }

            bool? he_ = context.Operators.WhereAny<Medication>(hc_, hd_);
            return he_;
        }

        IEnumerable<MedicationRequest> at_ = context.Operators.Where<MedicationRequest>(a_, as_);
        CqlValueSet au_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> av_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, au_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(at_, av_);
        IEnumerable<MedicationRequest> ax_ = Status_1_15_000.Instance.isMedicationOrder(context, aw_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ay_(MedicationRequest DextroamphetamineMed) {
            CqlInterval<CqlDate> ht_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate hu_ = context.Operators.Start(ht_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hv_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ht_, hu_);
            return hv_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> az_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ax_, ay_);

        object ba_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate hw_ = @this?.periodStart;
            return hw_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bb_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hx_ = @this?.period;
            bool? hy_ = context.Operators.Not((bool?)(hx_ is null));
            return hy_;
        }


        CqlInterval<CqlDate> bd_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hz_ = @this?.period;
            return hz_;
        }

        IEnumerable<CqlInterval<CqlDate>> be_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bb_, bc_, bd_);
        IEnumerable<CqlInterval<CqlDate>> bf_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, be_);
        IEnumerable<CqlInterval<CqlDate>> bg_ = context.Operators.Union<CqlInterval<CqlDate>>(ar_, bf_);
        IEnumerable<CqlInterval<CqlDate>> bh_ = context.Operators.Union<CqlInterval<CqlDate>>(ad_, bg_);

        bool? bi_(MedicationRequest MR) {
            IEnumerable<Medication> ia_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ib_(Medication M) {
                Id id_ = M?.IdElement;
                string ie_ = id_?.Value;
                DataType if_ = MR?.Medication;
                FhirString ih_ = if_ is ResourceReference ig_ ? ig_.ReferenceElement : null;
                string ii_ = ih_?.Value;
                IEnumerable<string> ij_ = context.Operators.Split(ii_, "/");
                string ik_ = context.Operators.Last<string>(ij_);
                bool? il_ = context.Operators.Equal(ie_, ik_);
                CodeableConcept im_ = M?.Code;
                CqlConcept in_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, im_);
                CqlValueSet io_ = this.Lisdexamfetamine(context);
                bool? ip_ = context.Operators.ConceptInValueSet(in_, io_);
                bool? iq_ = context.Operators.And(il_, ip_);
                return iq_;
            }

            bool? ic_ = context.Operators.WhereAny<Medication>(ia_, ib_);
            return ic_;
        }

        IEnumerable<MedicationRequest> bj_ = context.Operators.Where<MedicationRequest>(a_, bi_);
        CqlValueSet bk_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> bl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bm_ = context.Operators.Union<MedicationRequest>(bj_, bl_);
        IEnumerable<MedicationRequest> bn_ = Status_1_15_000.Instance.isMedicationOrder(context, bm_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? bo_(MedicationRequest LisdexamfetamineMed) {
            CqlInterval<CqlDate> ir_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate is_ = context.Operators.Start(ir_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? it_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ir_, is_);
            return it_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bp_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bn_, bo_);

        object bq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate iu_ = @this?.periodStart;
            return iu_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> br_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bs_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> iv_ = @this?.period;
            bool? iw_ = context.Operators.Not((bool?)(iv_ is null));
            return iw_;
        }


        CqlInterval<CqlDate> bt_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ix_ = @this?.period;
            return ix_;
        }

        IEnumerable<CqlInterval<CqlDate>> bu_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(br_, bs_, bt_);
        IEnumerable<CqlInterval<CqlDate>> bv_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, bu_);

        bool? bw_(MedicationRequest MR) {
            IEnumerable<Medication> iy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? iz_(Medication M) {
                Id jb_ = M?.IdElement;
                string jc_ = jb_?.Value;
                DataType jd_ = MR?.Medication;
                FhirString jf_ = jd_ is ResourceReference je_ ? je_.ReferenceElement : null;
                string jg_ = jf_?.Value;
                IEnumerable<string> jh_ = context.Operators.Split(jg_, "/");
                string ji_ = context.Operators.Last<string>(jh_);
                bool? jj_ = context.Operators.Equal(jc_, ji_);
                CodeableConcept jk_ = M?.Code;
                CqlConcept jl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jk_);
                CqlValueSet jm_ = this.Methylphenidate(context);
                bool? jn_ = context.Operators.ConceptInValueSet(jl_, jm_);
                bool? jo_ = context.Operators.And(jj_, jn_);
                return jo_;
            }

            bool? ja_ = context.Operators.WhereAny<Medication>(iy_, iz_);
            return ja_;
        }

        IEnumerable<MedicationRequest> bx_ = context.Operators.Where<MedicationRequest>(a_, bw_);
        CqlValueSet by_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> bz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, by_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bx_, bz_);
        IEnumerable<MedicationRequest> cb_ = Status_1_15_000.Instance.isMedicationOrder(context, ca_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cc_(MedicationRequest MethylphenidateMed) {
            CqlInterval<CqlDate> jp_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate jq_ = context.Operators.Start(jp_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jr_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jp_, jq_);
            return jr_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cd_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cb_, cc_);

        object ce_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate js_ = @this?.periodStart;
            return js_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jt_ = @this?.period;
            bool? ju_ = context.Operators.Not((bool?)(jt_ is null));
            return ju_;
        }


        CqlInterval<CqlDate> ch_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jv_ = @this?.period;
            return jv_;
        }

        IEnumerable<CqlInterval<CqlDate>> ci_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cf_, cg_, ch_);
        IEnumerable<CqlInterval<CqlDate>> cj_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ci_);
        IEnumerable<CqlInterval<CqlDate>> ck_ = context.Operators.Union<CqlInterval<CqlDate>>(bv_, cj_);
        IEnumerable<CqlInterval<CqlDate>> cl_ = context.Operators.Union<CqlInterval<CqlDate>>(bh_, ck_);

        bool? cm_(MedicationRequest MR) {
            IEnumerable<Medication> jw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jx_(Medication M) {
                Id jz_ = M?.IdElement;
                string ka_ = jz_?.Value;
                DataType kb_ = MR?.Medication;
                FhirString kd_ = kb_ is ResourceReference kc_ ? kc_.ReferenceElement : null;
                string ke_ = kd_?.Value;
                IEnumerable<string> kf_ = context.Operators.Split(ke_, "/");
                string kg_ = context.Operators.Last<string>(kf_);
                bool? kh_ = context.Operators.Equal(ka_, kg_);
                CodeableConcept ki_ = M?.Code;
                CqlConcept kj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ki_);
                CqlValueSet kk_ = this.Guanfacine_Medications(context);
                bool? kl_ = context.Operators.ConceptInValueSet(kj_, kk_);
                bool? km_ = context.Operators.And(kh_, kl_);
                return km_;
            }

            bool? jy_ = context.Operators.WhereAny<Medication>(jw_, jx_);
            return jy_;
        }

        IEnumerable<MedicationRequest> cn_ = context.Operators.Where<MedicationRequest>(a_, cm_);
        CqlValueSet co_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> cp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cq_ = context.Operators.Union<MedicationRequest>(cn_, cp_);
        IEnumerable<MedicationRequest> cr_ = Status_1_15_000.Instance.isMedicationOrder(context, cq_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cs_(MedicationRequest GuanfacineMed) {
            CqlInterval<CqlDate> kn_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate ko_ = context.Operators.Start(kn_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kp_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kn_, ko_);
            return kp_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ct_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cr_, cs_);

        object cu_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate kq_ = @this?.periodStart;
            return kq_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cw_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> kr_ = @this?.period;
            bool? ks_ = context.Operators.Not((bool?)(kr_ is null));
            return ks_;
        }


        CqlInterval<CqlDate> cx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> kt_ = @this?.period;
            return kt_;
        }

        IEnumerable<CqlInterval<CqlDate>> cy_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cv_, cw_, cx_);
        IEnumerable<CqlInterval<CqlDate>> cz_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, cy_);

        bool? da_(MedicationRequest MR) {
            IEnumerable<Medication> ku_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kv_(Medication M) {
                Id kx_ = M?.IdElement;
                string ky_ = kx_?.Value;
                DataType kz_ = MR?.Medication;
                FhirString lb_ = kz_ is ResourceReference la_ ? la_.ReferenceElement : null;
                string lc_ = lb_?.Value;
                IEnumerable<string> ld_ = context.Operators.Split(lc_, "/");
                string le_ = context.Operators.Last<string>(ld_);
                bool? lf_ = context.Operators.Equal(ky_, le_);
                CodeableConcept lg_ = M?.Code;
                CqlConcept lh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lg_);
                CqlCode li_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept lj_ = context.Operators.ConvertCodeToConcept(li_);
                bool? lk_ = context.Operators.Equivalent(lh_, lj_);
                bool? ll_ = context.Operators.And(lf_, lk_);
                return ll_;
            }

            bool? kw_ = context.Operators.WhereAny<Medication>(ku_, kv_);
            return kw_;
        }

        IEnumerable<MedicationRequest> db_ = context.Operators.Where<MedicationRequest>(a_, da_);
        CqlCode dc_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> dd_ = context.Operators.ToList<CqlCode>(dc_);
        IEnumerable<MedicationRequest> de_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, dd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(db_, de_);
        IEnumerable<MedicationRequest> dg_ = Status_1_15_000.Instance.isMedicationOrder(context, df_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dh_(MedicationRequest MethamphetamineMed) {
            CqlInterval<CqlDate> lm_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate ln_ = context.Operators.Start(lm_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lo_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, lm_, ln_);
            return lo_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> di_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dg_, dh_);

        object dj_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate lp_ = @this?.periodStart;
            return lp_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(di_, dj_, System.ComponentModel.ListSortDirection.Ascending);

        bool? dl_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> lq_ = @this?.period;
            bool? lr_ = context.Operators.Not((bool?)(lq_ is null));
            return lr_;
        }


        CqlInterval<CqlDate> dm_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ls_ = @this?.period;
            return ls_;
        }

        IEnumerable<CqlInterval<CqlDate>> dn_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dk_, dl_, dm_);
        IEnumerable<CqlInterval<CqlDate>> do_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, dn_);
        IEnumerable<CqlInterval<CqlDate>> dp_ = context.Operators.Union<CqlInterval<CqlDate>>(cz_, do_);
        IEnumerable<CqlInterval<CqlDate>> dq_ = context.Operators.Union<CqlInterval<CqlDate>>(cl_, dp_);

        bool? dr_(MedicationRequest MR) {
            IEnumerable<Medication> lt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lu_(Medication M) {
                Id lw_ = M?.IdElement;
                string lx_ = lw_?.Value;
                DataType ly_ = MR?.Medication;
                FhirString ma_ = ly_ is ResourceReference lz_ ? lz_.ReferenceElement : null;
                string mb_ = ma_?.Value;
                IEnumerable<string> mc_ = context.Operators.Split(mb_, "/");
                string md_ = context.Operators.Last<string>(mc_);
                bool? me_ = context.Operators.Equal(lx_, md_);
                CodeableConcept mf_ = M?.Code;
                CqlConcept mg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mf_);
                CqlValueSet mh_ = this.Viloxazine(context);
                bool? mi_ = context.Operators.ConceptInValueSet(mg_, mh_);
                bool? mj_ = context.Operators.And(me_, mi_);
                return mj_;
            }

            bool? lv_ = context.Operators.WhereAny<Medication>(lt_, lu_);
            return lv_;
        }

        IEnumerable<MedicationRequest> ds_ = context.Operators.Where<MedicationRequest>(a_, dr_);
        CqlValueSet dt_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> du_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dv_ = context.Operators.Union<MedicationRequest>(ds_, du_);
        IEnumerable<MedicationRequest> dw_ = Status_1_15_000.Instance.isMedicationOrder(context, dv_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dx_(MedicationRequest ViloxazineMed) {
            CqlInterval<CqlDate> mk_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ViloxazineMed);
            CqlDate ml_ = context.Operators.Start(mk_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? mm_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, mk_, ml_);
            return mm_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dy_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dw_, dx_);

        object dz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate mn_ = @this?.periodStart;
            return mn_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ea_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dy_, dz_, System.ComponentModel.ListSortDirection.Ascending);

        bool? eb_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> mo_ = @this?.period;
            bool? mp_ = context.Operators.Not((bool?)(mo_ is null));
            return mp_;
        }


        CqlInterval<CqlDate> ec_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> mq_ = @this?.period;
            return mq_;
        }

        IEnumerable<CqlInterval<CqlDate>> ed_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ea_, eb_, ec_);
        IEnumerable<CqlInterval<CqlDate>> ee_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ed_);
        IEnumerable<CqlInterval<CqlDate>> ef_ = context.Operators.Union<CqlInterval<CqlDate>>(dq_, ee_);

        CqlInterval<CqlDate> eg_(CqlInterval<CqlDate> ADHDMedication) {
            CqlDate mr_ = this.IPSD(context);
            CqlQuantity ms_ = context.Operators.Quantity(300m, "days");
            CqlDate mt_ = context.Operators.Add(mr_, ms_);
            CqlInterval<CqlDate> mu_ = context.Operators.Interval(mr_, mt_, true, true);
            CqlInterval<CqlDate> mv_ = context.Operators.Intersect<CqlDate>(ADHDMedication, mu_);
            return mv_;
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
