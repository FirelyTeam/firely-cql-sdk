#nullable enable

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 4855730798156578906L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS136FHIRChildADHDMedFollowUp-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (31)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4641227550436577792L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("March 1 of Year Prior to Measurement Period")]
    public CqlDateTime? March_1_of_Year_Prior_to_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_March_1_of_Year_Prior_to_Measurement_Period, March_1_of_Year_Prior_to_Measurement_Period_Compute);

    private const long _cacheIndex_March_1_of_Year_Prior_to_Measurement_Period = 3709971840043392196L;

    private CqlDateTime? March_1_of_Year_Prior_to_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime?>? a_ = this.Measurement_Period(context);
        CqlDateTime? b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime? f_ = context.Operators.DateTime(d_, 3, 1, 0, 0, 0, 0, e_);
        return f_;
    }


    [CqlExpressionDefinition("Last Calendar Day of February of Measurement Period")]
    public CqlDateTime? Last_Calendar_Day_of_February_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Last_Calendar_Day_of_February_of_Measurement_Period, Last_Calendar_Day_of_February_of_Measurement_Period_Compute);

    private const long _cacheIndex_Last_Calendar_Day_of_February_of_Measurement_Period = -4226591970914106183L;

    private CqlDateTime? Last_Calendar_Day_of_February_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime?>? a_ = this.Measurement_Period(context);
        CqlDateTime? b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime? e_ = context.Operators.DateTime(c_, 3, 1, 23, 59, 59, 0, d_);
        CqlQuantity? f_ = context.Operators.Quantity(1m, "day");
        CqlDateTime? g_ = context.Operators.Subtract(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime?>? Intake_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intake_Period, Intake_Period_Compute);

    private const long _cacheIndex_Intake_Period = -706599413819521966L;

    private CqlInterval<CqlDateTime?>? Intake_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = this.March_1_of_Year_Prior_to_Measurement_Period(context);
        CqlDateTime? b_ = this.Last_Calendar_Day_of_February_of_Measurement_Period(context);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, true);
        return c_;
    }


    [CqlExpressionDefinition("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
    public IEnumerable<(CqlTupleMetadata, CqlDate? startDate)?>? ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication, ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication_Compute);

    private const long _cacheIndex_ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication = 3223880368776900477L;

    private IEnumerable<(CqlTupleMetadata, CqlDate? startDate)?>? ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? bl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bm_(Medication? M) {
                object? bo_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? bp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? bq_ = context.Operators.Split(((string?)bp_)!, "/");
                string? br_ = context.Operators.Last<string?>(bq_!);
                bool? bs_ = context.Operators.Equal(bo_, br_);
                CodeableConcept? bt_ = M?.Code;
                CqlConcept? bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                CqlValueSet? bv_ = this.Atomoxetine(context);
                bool? bw_ = context.Operators.ConceptInValueSet(bu_, bv_);
                bool? bx_ = context.Operators.And(bs_, bw_);
                return bx_;
            }

            bool? bn_ = context.Operators.WhereAny<Medication?>(bl_, bm_);
            return bn_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);

        bool? g_(MedicationRequest? MR) {
            IEnumerable<Medication?>? by_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bz_(Medication? M) {
                object? cb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? cc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? cd_ = context.Operators.Split(((string?)cc_)!, "/");
                string? ce_ = context.Operators.Last<string?>(cd_!);
                bool? cf_ = context.Operators.Equal(cb_, ce_);
                CodeableConcept? cg_ = M?.Code;
                CqlConcept? ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
                CqlValueSet? ci_ = this.Clonidine(context);
                bool? cj_ = context.Operators.ConceptInValueSet(ch_, ci_);
                bool? ck_ = context.Operators.And(cf_, cj_);
                return ck_;
            }

            bool? ca_ = context.Operators.WhereAny<Medication?>(by_, bz_);
            return ca_;
        }

        IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(a_, g_);
        CqlValueSet? i_ = this.Clonidine(context);
        IEnumerable<MedicationRequest?>? j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? k_ = context.Operators.Union<MedicationRequest?>(h_, j_);
        IEnumerable<MedicationRequest?>? l_ = context.Operators.Union<MedicationRequest?>(f_, k_);

        bool? m_(MedicationRequest? MR) {
            IEnumerable<Medication?>? cl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cm_(Medication? M) {
                object? co_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? cp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? cq_ = context.Operators.Split(((string?)cp_)!, "/");
                string? cr_ = context.Operators.Last<string?>(cq_!);
                bool? cs_ = context.Operators.Equal(co_, cr_);
                CodeableConcept? ct_ = M?.Code;
                CqlConcept? cu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ct_);
                CqlValueSet? cv_ = this.Dexmethylphenidate(context);
                bool? cw_ = context.Operators.ConceptInValueSet(cu_, cv_);
                bool? cx_ = context.Operators.And(cs_, cw_);
                return cx_;
            }

            bool? cn_ = context.Operators.WhereAny<Medication?>(cl_, cm_);
            return cn_;
        }

        IEnumerable<MedicationRequest?>? n_ = context.Operators.Where<MedicationRequest?>(a_, m_);
        CqlValueSet? o_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest?>? p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? q_ = context.Operators.Union<MedicationRequest?>(n_, p_);
        IEnumerable<MedicationRequest?>? r_ = context.Operators.Union<MedicationRequest?>(l_, q_);

        bool? s_(MedicationRequest? MR) {
            IEnumerable<Medication?>? cy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cz_(Medication? M) {
                object? db_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? dc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? dd_ = context.Operators.Split(((string?)dc_)!, "/");
                string? de_ = context.Operators.Last<string?>(dd_!);
                bool? df_ = context.Operators.Equal(db_, de_);
                CodeableConcept? dg_ = M?.Code;
                CqlConcept? dh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dg_);
                CqlValueSet? di_ = this.Dextroamphetamine(context);
                bool? dj_ = context.Operators.ConceptInValueSet(dh_, di_);
                bool? dk_ = context.Operators.And(df_, dj_);
                return dk_;
            }

            bool? da_ = context.Operators.WhereAny<Medication?>(cy_, cz_);
            return da_;
        }

        IEnumerable<MedicationRequest?>? t_ = context.Operators.Where<MedicationRequest?>(a_, s_);
        CqlValueSet? u_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest?>? v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? w_ = context.Operators.Union<MedicationRequest?>(t_, v_);
        IEnumerable<MedicationRequest?>? x_ = context.Operators.Union<MedicationRequest?>(r_, w_);

        bool? y_(MedicationRequest? MR) {
            IEnumerable<Medication?>? dl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dm_(Medication? M) {
                object? do_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? dp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? dq_ = context.Operators.Split(((string?)dp_)!, "/");
                string? dr_ = context.Operators.Last<string?>(dq_!);
                bool? ds_ = context.Operators.Equal(do_, dr_);
                CodeableConcept? dt_ = M?.Code;
                CqlConcept? du_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dt_);
                CqlValueSet? dv_ = this.Lisdexamfetamine(context);
                bool? dw_ = context.Operators.ConceptInValueSet(du_, dv_);
                bool? dx_ = context.Operators.And(ds_, dw_);
                return dx_;
            }

            bool? dn_ = context.Operators.WhereAny<Medication?>(dl_, dm_);
            return dn_;
        }

        IEnumerable<MedicationRequest?>? z_ = context.Operators.Where<MedicationRequest?>(a_, y_);
        CqlValueSet? aa_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest?>? ab_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? ac_ = context.Operators.Union<MedicationRequest?>(z_, ab_);
        IEnumerable<MedicationRequest?>? ad_ = context.Operators.Union<MedicationRequest?>(x_, ac_);

        bool? ae_(MedicationRequest? MR) {
            IEnumerable<Medication?>? dy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dz_(Medication? M) {
                object? eb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ec_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ed_ = context.Operators.Split(((string?)ec_)!, "/");
                string? ee_ = context.Operators.Last<string?>(ed_!);
                bool? ef_ = context.Operators.Equal(eb_, ee_);
                CodeableConcept? eg_ = M?.Code;
                CqlConcept? eh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eg_);
                CqlCode? ei_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept? ej_ = context.Operators.ConvertCodeToConcept(ei_);
                bool? ek_ = context.Operators.Equivalent(eh_, ej_);
                bool? el_ = context.Operators.And(ef_, ek_);
                return el_;
            }

            bool? ea_ = context.Operators.WhereAny<Medication?>(dy_, dz_);
            return ea_;
        }

        IEnumerable<MedicationRequest?>? af_ = context.Operators.Where<MedicationRequest?>(a_, ae_);
        CqlCode? ag_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode?>? ah_ = context.Operators.ToList<CqlCode?>(ag_);
        IEnumerable<MedicationRequest?>? ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? aj_ = context.Operators.Union<MedicationRequest?>(af_, ai_);
        IEnumerable<MedicationRequest?>? ak_ = context.Operators.Union<MedicationRequest?>(ad_, aj_);

        bool? al_(MedicationRequest? MR) {
            IEnumerable<Medication?>? em_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? en_(Medication? M) {
                object? ep_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? eq_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? er_ = context.Operators.Split(((string?)eq_)!, "/");
                string? es_ = context.Operators.Last<string?>(er_!);
                bool? et_ = context.Operators.Equal(ep_, es_);
                CodeableConcept? eu_ = M?.Code;
                CqlConcept? ev_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eu_);
                CqlValueSet? ew_ = this.Methylphenidate(context);
                bool? ex_ = context.Operators.ConceptInValueSet(ev_, ew_);
                bool? ey_ = context.Operators.And(et_, ex_);
                return ey_;
            }

            bool? eo_ = context.Operators.WhereAny<Medication?>(em_, en_);
            return eo_;
        }

        IEnumerable<MedicationRequest?>? am_ = context.Operators.Where<MedicationRequest?>(a_, al_);
        CqlValueSet? an_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest?>? ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? ap_ = context.Operators.Union<MedicationRequest?>(am_, ao_);
        IEnumerable<MedicationRequest?>? aq_ = context.Operators.Union<MedicationRequest?>(ak_, ap_);

        bool? ar_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ez_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fa_(Medication? M) {
                object? fc_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? fd_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? fe_ = context.Operators.Split(((string?)fd_)!, "/");
                string? ff_ = context.Operators.Last<string?>(fe_!);
                bool? fg_ = context.Operators.Equal(fc_, ff_);
                CodeableConcept? fh_ = M?.Code;
                CqlConcept? fi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fh_);
                CqlValueSet? fj_ = this.Guanfacine_Medications(context);
                bool? fk_ = context.Operators.ConceptInValueSet(fi_, fj_);
                bool? fl_ = context.Operators.And(fg_, fk_);
                return fl_;
            }

            bool? fb_ = context.Operators.WhereAny<Medication?>(ez_, fa_);
            return fb_;
        }

        IEnumerable<MedicationRequest?>? as_ = context.Operators.Where<MedicationRequest?>(a_, ar_);
        CqlValueSet? at_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest?>? au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? av_ = context.Operators.Union<MedicationRequest?>(as_, au_);
        IEnumerable<MedicationRequest?>? aw_ = context.Operators.Union<MedicationRequest?>(aq_, av_);

        bool? ax_(MedicationRequest? MR) {
            IEnumerable<Medication?>? fm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fn_(Medication? M) {
                object? fp_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? fq_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? fr_ = context.Operators.Split(((string?)fq_)!, "/");
                string? fs_ = context.Operators.Last<string?>(fr_!);
                bool? ft_ = context.Operators.Equal(fp_, fs_);
                CodeableConcept? fu_ = M?.Code;
                CqlConcept? fv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fu_);
                CqlValueSet? fw_ = this.Viloxazine(context);
                bool? fx_ = context.Operators.ConceptInValueSet(fv_, fw_);
                bool? fy_ = context.Operators.And(ft_, fx_);
                return fy_;
            }

            bool? fo_ = context.Operators.WhereAny<Medication?>(fm_, fn_);
            return fo_;
        }

        IEnumerable<MedicationRequest?>? ay_ = context.Operators.Where<MedicationRequest?>(a_, ax_);
        CqlValueSet? az_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest?>? ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, az_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? bb_ = context.Operators.Union<MedicationRequest?>(ay_, ba_);
        IEnumerable<MedicationRequest?>? bc_ = context.Operators.Union<MedicationRequest?>(aw_, bb_);
        IEnumerable<MedicationRequest?>? bd_ = Status_1_15_000.Instance.isMedicationOrder(context, bc_);

        bool? be_(MedicationRequest? ADHDMedications) {
            CqlInterval<CqlDate?>? fz_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate? ga_ = context.Operators.Start(fz_);
            CqlDateTime? gb_ = context.Operators.ConvertDateToDateTime(ga_);
            CqlInterval<CqlDateTime?>? gc_ = this.Intake_Period(context);
            bool? gd_ = context.Operators.In<CqlDateTime?>(gb_, gc_, (string?)default);
            return gd_;
        }

        IEnumerable<MedicationRequest?>? bf_ = context.Operators.Where<MedicationRequest?>(bd_, be_);

        bool? bg_(MedicationRequest? ADHDMedicationOrder) {
            IEnumerable<MedicationRequest?>? ge_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? gf_(MedicationRequest? MR) {
                IEnumerable<Medication?>? il_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? im_(Medication? M) {
                    object? io_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? ip_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? iq_ = context.Operators.Split(((string?)ip_)!, "/");
                    string? ir_ = context.Operators.Last<string?>(iq_!);
                    bool? is_ = context.Operators.Equal(io_, ir_);
                    CodeableConcept? it_ = M?.Code;
                    CqlConcept? iu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, it_);
                    CqlValueSet? iv_ = this.Atomoxetine(context);
                    bool? iw_ = context.Operators.ConceptInValueSet(iu_, iv_);
                    bool? ix_ = context.Operators.And(is_, iw_);
                    return ix_;
                }

                bool? in_ = context.Operators.WhereAny<Medication?>(il_, im_);
                return in_;
            }

            IEnumerable<MedicationRequest?>? gg_ = context.Operators.Where<MedicationRequest?>(ge_, gf_);
            CqlValueSet? gh_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest?>? gi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? gj_ = context.Operators.Union<MedicationRequest?>(gg_, gi_);

            bool? gk_(MedicationRequest? MR) {
                IEnumerable<Medication?>? iy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? iz_(Medication? M) {
                    object? jb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? jc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? jd_ = context.Operators.Split(((string?)jc_)!, "/");
                    string? je_ = context.Operators.Last<string?>(jd_!);
                    bool? jf_ = context.Operators.Equal(jb_, je_);
                    CodeableConcept? jg_ = M?.Code;
                    CqlConcept? jh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jg_);
                    CqlValueSet? ji_ = this.Clonidine(context);
                    bool? jj_ = context.Operators.ConceptInValueSet(jh_, ji_);
                    bool? jk_ = context.Operators.And(jf_, jj_);
                    return jk_;
                }

                bool? ja_ = context.Operators.WhereAny<Medication?>(iy_, iz_);
                return ja_;
            }

            IEnumerable<MedicationRequest?>? gl_ = context.Operators.Where<MedicationRequest?>(ge_, gk_);
            CqlValueSet? gm_ = this.Clonidine(context);
            IEnumerable<MedicationRequest?>? gn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? go_ = context.Operators.Union<MedicationRequest?>(gl_, gn_);
            IEnumerable<MedicationRequest?>? gp_ = context.Operators.Union<MedicationRequest?>(gj_, go_);

            bool? gq_(MedicationRequest? MR) {
                IEnumerable<Medication?>? jl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? jm_(Medication? M) {
                    object? jo_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? jp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? jq_ = context.Operators.Split(((string?)jp_)!, "/");
                    string? jr_ = context.Operators.Last<string?>(jq_!);
                    bool? js_ = context.Operators.Equal(jo_, jr_);
                    CodeableConcept? jt_ = M?.Code;
                    CqlConcept? ju_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jt_);
                    CqlValueSet? jv_ = this.Dexmethylphenidate(context);
                    bool? jw_ = context.Operators.ConceptInValueSet(ju_, jv_);
                    bool? jx_ = context.Operators.And(js_, jw_);
                    return jx_;
                }

                bool? jn_ = context.Operators.WhereAny<Medication?>(jl_, jm_);
                return jn_;
            }

            IEnumerable<MedicationRequest?>? gr_ = context.Operators.Where<MedicationRequest?>(ge_, gq_);
            CqlValueSet? gs_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest?>? gt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? gu_ = context.Operators.Union<MedicationRequest?>(gr_, gt_);
            IEnumerable<MedicationRequest?>? gv_ = context.Operators.Union<MedicationRequest?>(gp_, gu_);

            bool? gw_(MedicationRequest? MR) {
                IEnumerable<Medication?>? jy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? jz_(Medication? M) {
                    object? kb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? kc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? kd_ = context.Operators.Split(((string?)kc_)!, "/");
                    string? ke_ = context.Operators.Last<string?>(kd_!);
                    bool? kf_ = context.Operators.Equal(kb_, ke_);
                    CodeableConcept? kg_ = M?.Code;
                    CqlConcept? kh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kg_);
                    CqlValueSet? ki_ = this.Dextroamphetamine(context);
                    bool? kj_ = context.Operators.ConceptInValueSet(kh_, ki_);
                    bool? kk_ = context.Operators.And(kf_, kj_);
                    return kk_;
                }

                bool? ka_ = context.Operators.WhereAny<Medication?>(jy_, jz_);
                return ka_;
            }

            IEnumerable<MedicationRequest?>? gx_ = context.Operators.Where<MedicationRequest?>(ge_, gw_);
            CqlValueSet? gy_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest?>? gz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? ha_ = context.Operators.Union<MedicationRequest?>(gx_, gz_);
            IEnumerable<MedicationRequest?>? hb_ = context.Operators.Union<MedicationRequest?>(gv_, ha_);

            bool? hc_(MedicationRequest? MR) {
                IEnumerable<Medication?>? kl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? km_(Medication? M) {
                    object? ko_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? kp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? kq_ = context.Operators.Split(((string?)kp_)!, "/");
                    string? kr_ = context.Operators.Last<string?>(kq_!);
                    bool? ks_ = context.Operators.Equal(ko_, kr_);
                    CodeableConcept? kt_ = M?.Code;
                    CqlConcept? ku_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kt_);
                    CqlValueSet? kv_ = this.Lisdexamfetamine(context);
                    bool? kw_ = context.Operators.ConceptInValueSet(ku_, kv_);
                    bool? kx_ = context.Operators.And(ks_, kw_);
                    return kx_;
                }

                bool? kn_ = context.Operators.WhereAny<Medication?>(kl_, km_);
                return kn_;
            }

            IEnumerable<MedicationRequest?>? hd_ = context.Operators.Where<MedicationRequest?>(ge_, hc_);
            CqlValueSet? he_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest?>? hf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, he_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? hg_ = context.Operators.Union<MedicationRequest?>(hd_, hf_);
            IEnumerable<MedicationRequest?>? hh_ = context.Operators.Union<MedicationRequest?>(hb_, hg_);

            bool? hi_(MedicationRequest? MR) {
                IEnumerable<Medication?>? ky_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? kz_(Medication? M) {
                    object? lb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? lc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? ld_ = context.Operators.Split(((string?)lc_)!, "/");
                    string? le_ = context.Operators.Last<string?>(ld_!);
                    bool? lf_ = context.Operators.Equal(lb_, le_);
                    CodeableConcept? lg_ = M?.Code;
                    CqlConcept? lh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lg_);
                    CqlCode? li_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                    CqlConcept? lj_ = context.Operators.ConvertCodeToConcept(li_);
                    bool? lk_ = context.Operators.Equivalent(lh_, lj_);
                    bool? ll_ = context.Operators.And(lf_, lk_);
                    return ll_;
                }

                bool? la_ = context.Operators.WhereAny<Medication?>(ky_, kz_);
                return la_;
            }

            IEnumerable<MedicationRequest?>? hj_ = context.Operators.Where<MedicationRequest?>(ge_, hi_);
            CqlCode? hk_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode?>? hl_ = context.Operators.ToList<CqlCode?>(hk_);
            IEnumerable<MedicationRequest?>? hm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, hl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? hn_ = context.Operators.Union<MedicationRequest?>(hj_, hm_);
            IEnumerable<MedicationRequest?>? ho_ = context.Operators.Union<MedicationRequest?>(hh_, hn_);

            bool? hp_(MedicationRequest? MR) {
                IEnumerable<Medication?>? lm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ln_(Medication? M) {
                    object? lp_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? lq_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? lr_ = context.Operators.Split(((string?)lq_)!, "/");
                    string? ls_ = context.Operators.Last<string?>(lr_!);
                    bool? lt_ = context.Operators.Equal(lp_, ls_);
                    CodeableConcept? lu_ = M?.Code;
                    CqlConcept? lv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lu_);
                    CqlValueSet? lw_ = this.Methylphenidate(context);
                    bool? lx_ = context.Operators.ConceptInValueSet(lv_, lw_);
                    bool? ly_ = context.Operators.And(lt_, lx_);
                    return ly_;
                }

                bool? lo_ = context.Operators.WhereAny<Medication?>(lm_, ln_);
                return lo_;
            }

            IEnumerable<MedicationRequest?>? hq_ = context.Operators.Where<MedicationRequest?>(ge_, hp_);
            CqlValueSet? hr_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest?>? hs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? ht_ = context.Operators.Union<MedicationRequest?>(hq_, hs_);
            IEnumerable<MedicationRequest?>? hu_ = context.Operators.Union<MedicationRequest?>(ho_, ht_);

            bool? hv_(MedicationRequest? MR) {
                IEnumerable<Medication?>? lz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ma_(Medication? M) {
                    object? mc_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? md_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? me_ = context.Operators.Split(((string?)md_)!, "/");
                    string? mf_ = context.Operators.Last<string?>(me_!);
                    bool? mg_ = context.Operators.Equal(mc_, mf_);
                    CodeableConcept? mh_ = M?.Code;
                    CqlConcept? mi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mh_);
                    CqlValueSet? mj_ = this.Guanfacine_Medications(context);
                    bool? mk_ = context.Operators.ConceptInValueSet(mi_, mj_);
                    bool? ml_ = context.Operators.And(mg_, mk_);
                    return ml_;
                }

                bool? mb_ = context.Operators.WhereAny<Medication?>(lz_, ma_);
                return mb_;
            }

            IEnumerable<MedicationRequest?>? hw_ = context.Operators.Where<MedicationRequest?>(ge_, hv_);
            CqlValueSet? hx_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest?>? hy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? hz_ = context.Operators.Union<MedicationRequest?>(hw_, hy_);
            IEnumerable<MedicationRequest?>? ia_ = context.Operators.Union<MedicationRequest?>(hu_, hz_);

            bool? ib_(MedicationRequest? MR) {
                IEnumerable<Medication?>? mm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? mn_(Medication? M) {
                    object? mp_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                    object? mq_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                    IEnumerable<string?>? mr_ = context.Operators.Split(((string?)mq_)!, "/");
                    string? ms_ = context.Operators.Last<string?>(mr_!);
                    bool? mt_ = context.Operators.Equal(mp_, ms_);
                    CodeableConcept? mu_ = M?.Code;
                    CqlConcept? mv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mu_);
                    CqlValueSet? mw_ = this.Viloxazine(context);
                    bool? mx_ = context.Operators.ConceptInValueSet(mv_, mw_);
                    bool? my_ = context.Operators.And(mt_, mx_);
                    return my_;
                }

                bool? mo_ = context.Operators.WhereAny<Medication?>(mm_, mn_);
                return mo_;
            }

            IEnumerable<MedicationRequest?>? ic_ = context.Operators.Where<MedicationRequest?>(ge_, ib_);
            CqlValueSet? id_ = this.Viloxazine(context);
            IEnumerable<MedicationRequest?>? ie_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, id_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? if_ = context.Operators.Union<MedicationRequest?>(ic_, ie_);
            IEnumerable<MedicationRequest?>? ig_ = context.Operators.Union<MedicationRequest?>(ia_, if_);
            IEnumerable<MedicationRequest?>? ih_ = Status_1_15_000.Instance.isMedicationActive(context, ig_);

            bool? ii_(MedicationRequest? ActiveADHDMedication) {
                CqlInterval<CqlDate?>? mz_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate?>? na_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate? nb_ = context.Operators.Start(na_);
                CqlDateTime? nc_ = context.Operators.ConvertDateToDateTime(nb_);
                CqlDate? nd_ = context.Operators.DateFrom(nc_);
                CqlQuantity? ne_ = context.Operators.Quantity(120m, "days");
                CqlDate? nf_ = context.Operators.Subtract(nd_, ne_);
                CqlInterval<CqlDate?>? ng_ = context.Operators.Interval(nf_, nd_, true, false);
                bool? nh_ = context.Operators.Overlaps(mz_!, ng_!, (string?)default);
                return nh_;
            }

            bool? ij_ = context.Operators.WhereAny<MedicationRequest?>(ih_, ii_);
            bool? ik_ = context.Operators.Not(ij_);
            return ik_;
        }


        (CqlTupleMetadata, CqlDate? startDate)? bh_(MedicationRequest? QualifyingMed) {
            CqlInterval<CqlDate?>? ni_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate? nj_ = context.Operators.Start(ni_);
            (CqlTupleMetadata, CqlDate? startDate)? nk_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, nj_);
            return nk_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate? startDate)?>? bi_ = context.Operators.WhereSelect<MedicationRequest?, (CqlTupleMetadata, CqlDate? startDate)?>(bf_, bg_, bh_);

        object bj_((CqlTupleMetadata, CqlDate? startDate)? @this) {
            CqlDate? nl_ = @this?.startDate;
            return nl_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate? startDate)?>? bk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate? startDate)?>(bi_, bj_, System.ComponentModel.ListSortDirection.Ascending);
        return bk_;
    }


    [CqlExpressionDefinition("First ADHD Medication Prescribed During Intake Period")]
    public CqlDate? First_ADHD_Medication_Prescribed_During_Intake_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_ADHD_Medication_Prescribed_During_Intake_Period, First_ADHD_Medication_Prescribed_During_Intake_Period_Compute);

    private const long _cacheIndex_First_ADHD_Medication_Prescribed_During_Intake_Period = -4639298654653847318L;

    private CqlDate? First_ADHD_Medication_Prescribed_During_Intake_Period_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDate? startDate)?>? a_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(context);

        bool? b_((CqlTupleMetadata, CqlDate? startDate)? @this) {
            CqlDate? f_ = @this?.startDate;
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            return g_;
        }


        CqlDate? c_((CqlTupleMetadata, CqlDate? startDate)? @this) {
            CqlDate? h_ = @this?.startDate;
            return h_;
        }

        IEnumerable<CqlDate?>? d_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlDate? startDate)?, CqlDate?>(a_, b_, c_);
        CqlDate? e_ = context.Operators.First<CqlDate?>(d_!);
        return e_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate? IPSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IPSD, IPSD_Compute);

    private const long _cacheIndex_IPSD = 2995733269230836253L;

    private CqlDate? IPSD_Compute(CqlContext context)
    {
        CqlDate? a_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter?>? Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = -1279258466511628036L;

    private IEnumerable<Encounter?>? Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? c_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);
        CqlValueSet? f_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter?>? g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter?>? i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter?>(g_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(e_, j_);
        IEnumerable<Encounter?>? l_ = Status_1_15_000.Instance.isEncounterPerformed(context, k_);

        bool? m_(Encounter? ValidEncounters) {
            CqlDate? o_ = this.IPSD(context);
            CqlQuantity? p_ = context.Operators.Quantity(6m, "months");
            CqlDate? q_ = context.Operators.Subtract(o_, p_);
            CqlInterval<CqlDate?>? r_ = context.Operators.Interval(q_, o_, true, true);
            Period? s_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime?>? t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlInterval<CqlDate?>? u_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, t_);
            bool? v_ = context.Operators.IntervalIncludesInterval<CqlDate?>(r_, u_, "day");
            return v_;
        }

        IEnumerable<Encounter?>? n_ = context.Operators.Where<Encounter?>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis")]
    public IEnumerable<Encounter?>? Inpatient_Stay_with_Qualifying_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis, Inpatient_Stay_with_Qualifying_Diagnosis_Compute);

    private const long _cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis = 7411720648034793077L;

    private IEnumerable<Encounter?>? Inpatient_Stay_with_Qualifying_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

        bool? d_(Encounter? InpatientStay) {
            CqlValueSet? f_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders(context);
            bool? g_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, InpatientStay, f_);
            return g_;
        }

        IEnumerable<Encounter?>? e_ = context.Operators.Where<Encounter?>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
    public IEnumerable<Encounter?>? Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase, Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase_Compute);

    private const long _cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase = -8156220072775179379L;

    private IEnumerable<Encounter?>? Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);

        bool? b_(Encounter? InpatientStay) {
            Period? d_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime?>? e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlInterval<CqlDate?>? f_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, e_);
            CqlDate? g_ = context.Operators.Start(f_);
            CqlDate? h_ = this.IPSD(context);
            CqlQuantity? i_ = context.Operators.Quantity(30m, "days");
            CqlDate? j_ = context.Operators.Add(h_, i_);
            CqlInterval<CqlDate?>? k_ = context.Operators.Interval(h_, j_, false, true);
            bool? l_ = context.Operators.In<CqlDate?>(g_, k_, "day");
            bool? m_ = context.Operators.Not((bool?)(h_ is null));
            bool? n_ = context.Operators.And(l_, m_);
            return n_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_1, Initial_Population_1_Compute);

    private const long _cacheIndex_Initial_Population_1 = -1620489078424121883L;

    private bool? Initial_Population_1_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Intake_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 6);
        CqlDateTime? j_ = context.Operators.End(e_);
        CqlDate? k_ = context.Operators.DateFrom(j_);
        int? l_ = context.Operators.CalculateAgeAt(d_, k_, "year");
        bool? m_ = context.Operators.LessOrEqual(l_, 12);
        bool? n_ = context.Operators.And(i_, m_);
        IEnumerable<Encounter?>? o_ = this.Qualifying_Encounter(context);
        bool? p_ = context.Operators.Exists<Encounter?>(o_!);
        bool? q_ = context.Operators.And(n_, p_);
        CqlDate? r_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? s_ = context.Operators.Not((bool?)(r_ is null));
        bool? t_ = context.Operators.And(q_, s_);
        IEnumerable<Encounter?>? u_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(context);
        bool? v_ = context.Operators.Exists<Encounter?>(u_!);
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
    public IEnumerable<Condition?>? Narcolepsy_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Narcolepsy_Exclusion, Narcolepsy_Exclusion_Compute);

    private const long _cacheIndex_Narcolepsy_Exclusion = -3383504585349343618L;

    private IEnumerable<Condition?>? Narcolepsy_Exclusion_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Narcolepsy(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);
        IEnumerable<Condition?>? e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition? NarcolepsyDx) {
            CqlInterval<CqlDateTime?>? h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NarcolepsyDx);
            CqlDateTime? i_ = context.Operators.Start(h_);
            CqlInterval<CqlDateTime?>? j_ = this.Measurement_Period(context);
            CqlDateTime? k_ = context.Operators.End(j_);
            bool? l_ = context.Operators.SameOrBefore(i_, k_, (string?)default);
            return l_;
        }

        IEnumerable<Condition?>? g_ = context.Operators.Where<Condition?>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4235625962082214445L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition?>? b_ = this.Narcolepsy_Exclusion(context);
        bool? c_ = context.Operators.Exists<Condition?>(b_!);
        bool? d_ = context.Operators.Or(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Qualifying Numerator Encounter")]
    public IEnumerable<Encounter?>? Qualifying_Numerator_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Numerator_Encounter, Qualifying_Numerator_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Numerator_Encounter = 9160626202490665926L;

    private IEnumerable<Encounter?>? Qualifying_Numerator_Encounter_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? c_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);
        CqlValueSet? f_ = this.Behavioral_Health_Follow_up_Visit(context);
        IEnumerable<Encounter?>? g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? h_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter?>? i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter?>(g_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(e_, j_);
        CqlValueSet? l_ = this.Psychotherapy_and_Pharmacologic_Management(context);
        IEnumerable<Encounter?>? m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? n_(Encounter? PsychPharmManagement) {
            List<Encounter.LocationComponent>? al_ = PsychPharmManagement?.Location;

            bool? am_(Encounter.LocationComponent? Location) {
                ResourceReference? ao_ = Location?.Location;
                Location? ap_ = CQMCommon_4_1_000.Instance.GetLocation(context, ao_);
                List<CodeableConcept>? aq_ = ap_?.Type;

                CqlConcept? ar_(CodeableConcept? @this) {
                    CqlConcept? av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return av_;
                }

                IEnumerable<CqlConcept?>? as_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)aq_, ar_);
                CqlValueSet? at_ = this.Ambulatory(context);
                bool? au_ = context.Operators.ConceptsInValueSet(as_, at_);
                return au_;
            }

            bool? an_ = context.Operators.WhereAny<Encounter.LocationComponent?>((IEnumerable<Encounter.LocationComponent?>?)al_, am_);
            return an_;
        }

        IEnumerable<Encounter?>? o_ = context.Operators.Where<Encounter?>(m_, n_);
        CqlValueSet? p_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter?>? q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? r_ = context.Operators.Union<Encounter?>(o_, q_);
        IEnumerable<Encounter?>? s_ = context.Operators.Union<Encounter?>(k_, r_);
        CqlValueSet? t_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter?>? u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? v_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter?>? w_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? x_ = context.Operators.Union<Encounter?>(u_, w_);
        IEnumerable<Encounter?>? y_ = context.Operators.Union<Encounter?>(s_, x_);
        CqlValueSet? z_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter?>? aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? ab_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter?>? ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? ad_ = context.Operators.Union<Encounter?>(aa_, ac_);
        IEnumerable<Encounter?>? ae_ = context.Operators.Union<Encounter?>(y_, ad_);
        CqlValueSet? af_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter?>? ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? ah_ = this.Telephone_Visits(context);
        IEnumerable<Encounter?>? ai_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? aj_ = context.Operators.Union<Encounter?>(ag_, ai_);
        IEnumerable<Encounter?>? ak_ = context.Operators.Union<Encounter?>(ae_, aj_);
        return ak_;
    }


    [CqlExpressionDefinition("Encounter During Initiation Phase")]
    public IEnumerable<Encounter?>? Encounter_During_Initiation_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_During_Initiation_Phase, Encounter_During_Initiation_Phase_Compute);

    private const long _cacheIndex_Encounter_During_Initiation_Phase = 5455347647867241726L;

    private IEnumerable<Encounter?>? Encounter_During_Initiation_Phase_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter?>? b_ = Status_1_15_000.Instance.isEncounterPerformed(context, a_);

        bool? c_(Encounter? ValidNumeratorEncounter) {
            Period? e_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime?>? f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlInterval<CqlDate?>? g_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, f_);
            CqlDate? h_ = context.Operators.Start(g_);
            CqlDate? i_ = this.IPSD(context);
            CqlQuantity? j_ = context.Operators.Quantity(30m, "days");
            CqlDate? k_ = context.Operators.Add(i_, j_);
            CqlInterval<CqlDate?>? l_ = context.Operators.Interval(i_, k_, false, true);
            bool? m_ = context.Operators.In<CqlDate?>(h_, l_, "day");
            bool? n_ = context.Operators.Not((bool?)(i_ is null));
            bool? o_ = context.Operators.And(m_, n_);
            return o_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -1892291096978746434L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_During_Initiation_Phase(context);
        bool? b_ = context.Operators.Exists<Encounter?>(a_!);
        return b_;
    }


    [CqlExpressionDefinition("ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
    public IEnumerable<CqlInterval<CqlDate?>?>? ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase, ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase = -1527460206037085161L;

    private IEnumerable<CqlInterval<CqlDate?>?>? ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ei_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ej_(Medication? M) {
                object? el_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? em_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? en_ = context.Operators.Split(((string?)em_)!, "/");
                string? eo_ = context.Operators.Last<string?>(en_!);
                bool? ep_ = context.Operators.Equal(el_, eo_);
                CodeableConcept? eq_ = M?.Code;
                CqlConcept? er_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eq_);
                CqlValueSet? es_ = this.Atomoxetine(context);
                bool? et_ = context.Operators.ConceptInValueSet(er_, es_);
                bool? eu_ = context.Operators.And(ep_, et_);
                return eu_;
            }

            bool? ek_ = context.Operators.WhereAny<Medication?>(ei_, ej_);
            return ek_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);
        IEnumerable<MedicationRequest?>? g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? h_(MedicationRequest? AtomoxetineMed) {
            CqlInterval<CqlDate?>? ev_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate? ew_ = context.Operators.Start(ev_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? ex_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ev_, ew_);
            return ex_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? i_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(g_, h_);

        object j_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? ey_ = @this?.periodStart;
            return ey_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);

        bool? l_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? ez_ = @this?.period;
            bool? fa_ = context.Operators.Not((bool?)(ez_ is null));
            return fa_;
        }


        CqlInterval<CqlDate?>? m_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? fb_ = @this?.period;
            return fb_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? n_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(k_, l_, m_);
        IEnumerable<CqlInterval<CqlDate?>?>? o_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, n_);

        bool? p_(MedicationRequest? MR) {
            IEnumerable<Medication?>? fc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fd_(Medication? M) {
                object? ff_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? fg_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? fh_ = context.Operators.Split(((string?)fg_)!, "/");
                string? fi_ = context.Operators.Last<string?>(fh_!);
                bool? fj_ = context.Operators.Equal(ff_, fi_);
                CodeableConcept? fk_ = M?.Code;
                CqlConcept? fl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fk_);
                CqlValueSet? fm_ = this.Clonidine(context);
                bool? fn_ = context.Operators.ConceptInValueSet(fl_, fm_);
                bool? fo_ = context.Operators.And(fj_, fn_);
                return fo_;
            }

            bool? fe_ = context.Operators.WhereAny<Medication?>(fc_, fd_);
            return fe_;
        }

        IEnumerable<MedicationRequest?>? q_ = context.Operators.Where<MedicationRequest?>(a_, p_);
        CqlValueSet? r_ = this.Clonidine(context);
        IEnumerable<MedicationRequest?>? s_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? t_ = context.Operators.Union<MedicationRequest?>(q_, s_);
        IEnumerable<MedicationRequest?>? u_ = Status_1_15_000.Instance.isMedicationOrder(context, t_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? v_(MedicationRequest? ClonidineMed) {
            CqlInterval<CqlDate?>? fp_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate? fq_ = context.Operators.Start(fp_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? fr_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fp_, fq_);
            return fr_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? w_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(u_, v_);

        object x_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? fs_ = @this?.periodStart;
            return fs_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? y_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);

        bool? z_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? ft_ = @this?.period;
            bool? fu_ = context.Operators.Not((bool?)(ft_ is null));
            return fu_;
        }


        CqlInterval<CqlDate?>? aa_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? fv_ = @this?.period;
            return fv_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? ab_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(y_, z_, aa_);
        IEnumerable<CqlInterval<CqlDate?>?>? ac_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ab_);
        IEnumerable<CqlInterval<CqlDate?>?>? ad_ = context.Operators.Union<CqlInterval<CqlDate?>?>(o_, ac_);

        bool? ae_(MedicationRequest? MR) {
            IEnumerable<Medication?>? fw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fx_(Medication? M) {
                object? fz_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ga_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? gb_ = context.Operators.Split(((string?)ga_)!, "/");
                string? gc_ = context.Operators.Last<string?>(gb_!);
                bool? gd_ = context.Operators.Equal(fz_, gc_);
                CodeableConcept? ge_ = M?.Code;
                CqlConcept? gf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ge_);
                CqlValueSet? gg_ = this.Dexmethylphenidate(context);
                bool? gh_ = context.Operators.ConceptInValueSet(gf_, gg_);
                bool? gi_ = context.Operators.And(gd_, gh_);
                return gi_;
            }

            bool? fy_ = context.Operators.WhereAny<Medication?>(fw_, fx_);
            return fy_;
        }

        IEnumerable<MedicationRequest?>? af_ = context.Operators.Where<MedicationRequest?>(a_, ae_);
        CqlValueSet? ag_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest?>? ah_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? ai_ = context.Operators.Union<MedicationRequest?>(af_, ah_);
        IEnumerable<MedicationRequest?>? aj_ = Status_1_15_000.Instance.isMedicationOrder(context, ai_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? ak_(MedicationRequest? DexmethylphenidateMed) {
            CqlInterval<CqlDate?>? gj_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate? gk_ = context.Operators.Start(gj_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? gl_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gj_, gk_);
            return gl_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? al_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(aj_, ak_);

        object am_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? gm_ = @this?.periodStart;
            return gm_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? an_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);

        bool? ao_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? gn_ = @this?.period;
            bool? go_ = context.Operators.Not((bool?)(gn_ is null));
            return go_;
        }


        CqlInterval<CqlDate?>? ap_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? gp_ = @this?.period;
            return gp_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? aq_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(an_, ao_, ap_);
        IEnumerable<CqlInterval<CqlDate?>?>? ar_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, aq_);

        bool? as_(MedicationRequest? MR) {
            IEnumerable<Medication?>? gq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gr_(Medication? M) {
                object? gt_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? gu_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? gv_ = context.Operators.Split(((string?)gu_)!, "/");
                string? gw_ = context.Operators.Last<string?>(gv_!);
                bool? gx_ = context.Operators.Equal(gt_, gw_);
                CodeableConcept? gy_ = M?.Code;
                CqlConcept? gz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gy_);
                CqlValueSet? ha_ = this.Dextroamphetamine(context);
                bool? hb_ = context.Operators.ConceptInValueSet(gz_, ha_);
                bool? hc_ = context.Operators.And(gx_, hb_);
                return hc_;
            }

            bool? gs_ = context.Operators.WhereAny<Medication?>(gq_, gr_);
            return gs_;
        }

        IEnumerable<MedicationRequest?>? at_ = context.Operators.Where<MedicationRequest?>(a_, as_);
        CqlValueSet? au_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest?>? av_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, au_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? aw_ = context.Operators.Union<MedicationRequest?>(at_, av_);
        IEnumerable<MedicationRequest?>? ax_ = Status_1_15_000.Instance.isMedicationOrder(context, aw_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? ay_(MedicationRequest? DextroamphetamineMed) {
            CqlInterval<CqlDate?>? hd_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate? he_ = context.Operators.Start(hd_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? hf_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, hd_, he_);
            return hf_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? az_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(ax_, ay_);

        object ba_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? hg_ = @this?.periodStart;
            return hg_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? bb_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bc_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? hh_ = @this?.period;
            bool? hi_ = context.Operators.Not((bool?)(hh_ is null));
            return hi_;
        }


        CqlInterval<CqlDate?>? bd_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? hj_ = @this?.period;
            return hj_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? be_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(bb_, bc_, bd_);
        IEnumerable<CqlInterval<CqlDate?>?>? bf_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, be_);
        IEnumerable<CqlInterval<CqlDate?>?>? bg_ = context.Operators.Union<CqlInterval<CqlDate?>?>(ar_, bf_);
        IEnumerable<CqlInterval<CqlDate?>?>? bh_ = context.Operators.Union<CqlInterval<CqlDate?>?>(ad_, bg_);

        bool? bi_(MedicationRequest? MR) {
            IEnumerable<Medication?>? hk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hl_(Medication? M) {
                object? hn_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ho_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? hp_ = context.Operators.Split(((string?)ho_)!, "/");
                string? hq_ = context.Operators.Last<string?>(hp_!);
                bool? hr_ = context.Operators.Equal(hn_, hq_);
                CodeableConcept? hs_ = M?.Code;
                CqlConcept? ht_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hs_);
                CqlValueSet? hu_ = this.Lisdexamfetamine(context);
                bool? hv_ = context.Operators.ConceptInValueSet(ht_, hu_);
                bool? hw_ = context.Operators.And(hr_, hv_);
                return hw_;
            }

            bool? hm_ = context.Operators.WhereAny<Medication?>(hk_, hl_);
            return hm_;
        }

        IEnumerable<MedicationRequest?>? bj_ = context.Operators.Where<MedicationRequest?>(a_, bi_);
        CqlValueSet? bk_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest?>? bl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? bm_ = context.Operators.Union<MedicationRequest?>(bj_, bl_);
        IEnumerable<MedicationRequest?>? bn_ = Status_1_15_000.Instance.isMedicationOrder(context, bm_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? bo_(MedicationRequest? LisdexamfetamineMed) {
            CqlInterval<CqlDate?>? hx_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate? hy_ = context.Operators.Start(hx_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? hz_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, hx_, hy_);
            return hz_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? bp_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(bn_, bo_);

        object bq_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? ia_ = @this?.periodStart;
            return ia_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? br_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bs_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? ib_ = @this?.period;
            bool? ic_ = context.Operators.Not((bool?)(ib_ is null));
            return ic_;
        }


        CqlInterval<CqlDate?>? bt_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? id_ = @this?.period;
            return id_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? bu_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(br_, bs_, bt_);
        IEnumerable<CqlInterval<CqlDate?>?>? bv_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, bu_);

        bool? bw_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ie_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? if_(Medication? M) {
                object? ih_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ii_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ij_ = context.Operators.Split(((string?)ii_)!, "/");
                string? ik_ = context.Operators.Last<string?>(ij_!);
                bool? il_ = context.Operators.Equal(ih_, ik_);
                CodeableConcept? im_ = M?.Code;
                CqlConcept? in_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, im_);
                CqlValueSet? io_ = this.Methylphenidate(context);
                bool? ip_ = context.Operators.ConceptInValueSet(in_, io_);
                bool? iq_ = context.Operators.And(il_, ip_);
                return iq_;
            }

            bool? ig_ = context.Operators.WhereAny<Medication?>(ie_, if_);
            return ig_;
        }

        IEnumerable<MedicationRequest?>? bx_ = context.Operators.Where<MedicationRequest?>(a_, bw_);
        CqlValueSet? by_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest?>? bz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, by_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? ca_ = context.Operators.Union<MedicationRequest?>(bx_, bz_);
        IEnumerable<MedicationRequest?>? cb_ = Status_1_15_000.Instance.isMedicationOrder(context, ca_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? cc_(MedicationRequest? MethylphenidateMed) {
            CqlInterval<CqlDate?>? ir_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate? is_ = context.Operators.Start(ir_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? it_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ir_, is_);
            return it_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? cd_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(cb_, cc_);

        object ce_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? iu_ = @this?.periodStart;
            return iu_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? cf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cg_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? iv_ = @this?.period;
            bool? iw_ = context.Operators.Not((bool?)(iv_ is null));
            return iw_;
        }


        CqlInterval<CqlDate?>? ch_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? ix_ = @this?.period;
            return ix_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? ci_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(cf_, cg_, ch_);
        IEnumerable<CqlInterval<CqlDate?>?>? cj_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ci_);
        IEnumerable<CqlInterval<CqlDate?>?>? ck_ = context.Operators.Union<CqlInterval<CqlDate?>?>(bv_, cj_);
        IEnumerable<CqlInterval<CqlDate?>?>? cl_ = context.Operators.Union<CqlInterval<CqlDate?>?>(bh_, ck_);

        bool? cm_(MedicationRequest? MR) {
            IEnumerable<Medication?>? iy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? iz_(Medication? M) {
                object? jb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? jc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? jd_ = context.Operators.Split(((string?)jc_)!, "/");
                string? je_ = context.Operators.Last<string?>(jd_!);
                bool? jf_ = context.Operators.Equal(jb_, je_);
                CodeableConcept? jg_ = M?.Code;
                CqlConcept? jh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jg_);
                CqlValueSet? ji_ = this.Guanfacine_Medications(context);
                bool? jj_ = context.Operators.ConceptInValueSet(jh_, ji_);
                bool? jk_ = context.Operators.And(jf_, jj_);
                return jk_;
            }

            bool? ja_ = context.Operators.WhereAny<Medication?>(iy_, iz_);
            return ja_;
        }

        IEnumerable<MedicationRequest?>? cn_ = context.Operators.Where<MedicationRequest?>(a_, cm_);
        CqlValueSet? co_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest?>? cp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? cq_ = context.Operators.Union<MedicationRequest?>(cn_, cp_);
        IEnumerable<MedicationRequest?>? cr_ = Status_1_15_000.Instance.isMedicationOrder(context, cq_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? cs_(MedicationRequest? GuanfacineMed) {
            CqlInterval<CqlDate?>? jl_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate? jm_ = context.Operators.Start(jl_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? jn_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jl_, jm_);
            return jn_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? ct_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(cr_, cs_);

        object cu_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? jo_ = @this?.periodStart;
            return jo_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? cv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cw_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? jp_ = @this?.period;
            bool? jq_ = context.Operators.Not((bool?)(jp_ is null));
            return jq_;
        }


        CqlInterval<CqlDate?>? cx_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? jr_ = @this?.period;
            return jr_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? cy_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(cv_, cw_, cx_);
        IEnumerable<CqlInterval<CqlDate?>?>? cz_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, cy_);

        bool? da_(MedicationRequest? MR) {
            IEnumerable<Medication?>? js_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jt_(Medication? M) {
                object? jv_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? jw_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? jx_ = context.Operators.Split(((string?)jw_)!, "/");
                string? jy_ = context.Operators.Last<string?>(jx_!);
                bool? jz_ = context.Operators.Equal(jv_, jy_);
                CodeableConcept? ka_ = M?.Code;
                CqlConcept? kb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ka_);
                CqlCode? kc_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept? kd_ = context.Operators.ConvertCodeToConcept(kc_);
                bool? ke_ = context.Operators.Equivalent(kb_, kd_);
                bool? kf_ = context.Operators.And(jz_, ke_);
                return kf_;
            }

            bool? ju_ = context.Operators.WhereAny<Medication?>(js_, jt_);
            return ju_;
        }

        IEnumerable<MedicationRequest?>? db_ = context.Operators.Where<MedicationRequest?>(a_, da_);
        CqlCode? dc_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode?>? dd_ = context.Operators.ToList<CqlCode?>(dc_);
        IEnumerable<MedicationRequest?>? de_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, dd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? df_ = context.Operators.Union<MedicationRequest?>(db_, de_);
        IEnumerable<MedicationRequest?>? dg_ = Status_1_15_000.Instance.isMedicationOrder(context, df_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? dh_(MedicationRequest? MethamphetamineMed) {
            CqlInterval<CqlDate?>? kg_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate? kh_ = context.Operators.Start(kg_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? ki_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kg_, kh_);
            return ki_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? di_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(dg_, dh_);

        object dj_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? kj_ = @this?.periodStart;
            return kj_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? dk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(di_, dj_, System.ComponentModel.ListSortDirection.Ascending);

        bool? dl_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? kk_ = @this?.period;
            bool? kl_ = context.Operators.Not((bool?)(kk_ is null));
            return kl_;
        }


        CqlInterval<CqlDate?>? dm_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? km_ = @this?.period;
            return km_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? dn_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(dk_, dl_, dm_);
        IEnumerable<CqlInterval<CqlDate?>?>? do_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, dn_);
        IEnumerable<CqlInterval<CqlDate?>?>? dp_ = context.Operators.Union<CqlInterval<CqlDate?>?>(cz_, do_);
        IEnumerable<CqlInterval<CqlDate?>?>? dq_ = context.Operators.Union<CqlInterval<CqlDate?>?>(cl_, dp_);

        bool? dr_(MedicationRequest? MR) {
            IEnumerable<Medication?>? kn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ko_(Medication? M) {
                object? kq_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? kr_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ks_ = context.Operators.Split(((string?)kr_)!, "/");
                string? kt_ = context.Operators.Last<string?>(ks_!);
                bool? ku_ = context.Operators.Equal(kq_, kt_);
                CodeableConcept? kv_ = M?.Code;
                CqlConcept? kw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kv_);
                CqlValueSet? kx_ = this.Viloxazine(context);
                bool? ky_ = context.Operators.ConceptInValueSet(kw_, kx_);
                bool? kz_ = context.Operators.And(ku_, ky_);
                return kz_;
            }

            bool? kp_ = context.Operators.WhereAny<Medication?>(kn_, ko_);
            return kp_;
        }

        IEnumerable<MedicationRequest?>? ds_ = context.Operators.Where<MedicationRequest?>(a_, dr_);
        CqlValueSet? dt_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest?>? du_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? dv_ = context.Operators.Union<MedicationRequest?>(ds_, du_);
        IEnumerable<MedicationRequest?>? dw_ = Status_1_15_000.Instance.isMedicationOrder(context, dv_);

        (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? dx_(MedicationRequest? ViloxazineMed) {
            CqlInterval<CqlDate?>? la_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ViloxazineMed);
            CqlDate? lb_ = context.Operators.Start(la_);
            (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? lc_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, la_, lb_);
            return lc_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? dy_ = context.Operators.Select<MedicationRequest?, (CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(dw_, dx_);

        object dz_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlDate? ld_ = @this?.periodStart;
            return ld_!;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>? ea_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?>(dy_, dz_, System.ComponentModel.ListSortDirection.Ascending);

        bool? eb_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? le_ = @this?.period;
            bool? lf_ = context.Operators.Not((bool?)(le_ is null));
            return lf_;
        }


        CqlInterval<CqlDate?>? ec_((CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)? @this) {
            CqlInterval<CqlDate>? lg_ = @this?.period;
            return lg_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? ed_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate?>? period, CqlDate? periodStart)?, CqlInterval<CqlDate?>?>(ea_, eb_, ec_);
        IEnumerable<CqlInterval<CqlDate?>?>? ee_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ed_);
        IEnumerable<CqlInterval<CqlDate?>?>? ef_ = context.Operators.Union<CqlInterval<CqlDate?>?>(dq_, ee_);

        CqlInterval<CqlDate?>? eg_(CqlInterval<CqlDate?>? ADHDMedication) {
            CqlDate? lh_ = this.IPSD(context);
            CqlQuantity? li_ = context.Operators.Quantity(300m, "days");
            CqlDate? lj_ = context.Operators.Add(lh_, li_);
            CqlInterval<CqlDate?>? lk_ = context.Operators.Interval(lh_, lj_, true, true);
            CqlInterval<CqlDate?>? ll_ = context.Operators.Intersect<CqlDate?>(ADHDMedication, lk_);
            return ll_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? eh_ = context.Operators.Select<CqlInterval<CqlDate?>?, CqlInterval<CqlDate?>?>(ef_, eg_);
        return eh_;
    }


    [CqlExpressionDefinition("ADHD Cumulative Medication Duration")]
    public int? ADHD_Cumulative_Medication_Duration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ADHD_Cumulative_Medication_Duration, ADHD_Cumulative_Medication_Duration_Compute);

    private const long _cacheIndex_ADHD_Cumulative_Medication_Duration = -3886580344192465847L;

    private int? ADHD_Cumulative_Medication_Duration_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate?>?>? a_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
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
    public IEnumerable<Encounter?>? Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase, Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase = -2133610025250707462L;

    private IEnumerable<Encounter?>? Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);

        bool? b_(Encounter? InpatientStay) {
            Period? d_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime?>? e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlInterval<CqlDate?>? f_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, e_);
            CqlDate? g_ = context.Operators.Start(f_);
            CqlDate? h_ = this.IPSD(context);
            CqlQuantity? i_ = context.Operators.Quantity(300m, "days");
            CqlDate? j_ = context.Operators.Add(h_, i_);
            CqlInterval<CqlDate?>? k_ = context.Operators.Interval(h_, j_, false, true);
            bool? l_ = context.Operators.In<CqlDate?>(g_, k_, "day");
            bool? m_ = context.Operators.Not((bool?)(h_ is null));
            bool? n_ = context.Operators.And(l_, m_);
            return n_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_2, Initial_Population_2_Compute);

    private const long _cacheIndex_Initial_Population_2 = -2621416679819002185L;

    private bool? Initial_Population_2_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Intake_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 6);
        CqlDateTime? j_ = context.Operators.End(e_);
        CqlDate? k_ = context.Operators.DateFrom(j_);
        int? l_ = context.Operators.CalculateAgeAt(d_, k_, "year");
        bool? m_ = context.Operators.LessOrEqual(l_, 12);
        bool? n_ = context.Operators.And(i_, m_);
        IEnumerable<Encounter?>? o_ = this.Qualifying_Encounter(context);
        bool? p_ = context.Operators.Exists<Encounter?>(o_!);
        bool? q_ = context.Operators.And(n_, p_);
        CqlDate? r_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? s_ = context.Operators.Not((bool?)(r_ is null));
        bool? t_ = context.Operators.And(q_, s_);
        bool? u_ = this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(context);
        bool? v_ = context.Operators.And(t_, u_);
        IEnumerable<Encounter?>? w_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(context);
        bool? x_ = context.Operators.Exists<Encounter?>(w_!);
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
    public IEnumerable<CqlDate?>? Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase, Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase = 1910591399646290016L;

    private IEnumerable<CqlDate?>? Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter?>? b_ = Status_1_15_000.Instance.isEncounterPerformed(context, a_);

        bool? c_(Encounter? ValidNumeratorEncounter) {
            Period? g_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime?>? h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            CqlInterval<CqlDate?>? i_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, h_);
            CqlDate? j_ = context.Operators.Start(i_);
            CqlDate? k_ = this.IPSD(context);
            CqlQuantity? l_ = context.Operators.Quantity(31m, "days");
            CqlDate? m_ = context.Operators.Add(k_, l_);
            CqlQuantity? n_ = context.Operators.Quantity(300m, "days");
            CqlDate? o_ = context.Operators.Add(k_, n_);
            CqlInterval<CqlDate?>? p_ = context.Operators.Interval(m_, o_, true, true);
            bool? q_ = context.Operators.In<CqlDate?>(j_, p_, "day");
            return q_;
        }


        CqlDate? d_(Encounter? ValidNumeratorEncounter) {
            Period? r_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime?>? s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime? t_ = context.Operators.Start(s_);
            CqlDate? u_ = context.Operators.DateFrom(t_);
            return u_;
        }

        IEnumerable<CqlDate?>? e_ = context.Operators.WhereSelect<Encounter?, CqlDate?>(b_, c_, d_);
        IEnumerable<CqlDate?>? f_ = context.Operators.Distinct<CqlDate?>(e_!);
        return f_;
    }


    [CqlExpressionDefinition("Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
    public bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase, Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase = 9168811075567996819L;

    private bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        IEnumerable<CqlDate?>? a_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        int? b_ = context.Operators.Count<CqlDate?>(a_);
        bool? c_ = context.Operators.GreaterOrEqual(b_, 2);
        return c_;
    }


    [CqlExpressionDefinition("Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate?>? Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase, Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute);

    private const long _cacheIndex_Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase = 4453205296495751162L;

    private IEnumerable<CqlDate?>? Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

        bool? d_(Encounter? VirtualEnc) {
            Period? h_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlInterval<CqlDate?>? j_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, i_);
            CqlDate? k_ = context.Operators.Start(j_);
            CqlDate? l_ = this.IPSD(context);
            CqlQuantity? m_ = context.Operators.Quantity(31m, "days");
            CqlDate? n_ = context.Operators.Add(l_, m_);
            CqlQuantity? o_ = context.Operators.Quantity(300m, "days");
            CqlDate? p_ = context.Operators.Add(l_, o_);
            CqlInterval<CqlDate?>? q_ = context.Operators.Interval(n_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDate?>(k_, q_, "day");
            return r_;
        }


        CqlDate? e_(Encounter? VirtualEnc) {
            Period? s_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime?>? t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime? u_ = context.Operators.Start(t_);
            CqlDate? v_ = context.Operators.DateFrom(u_);
            return v_;
        }

        IEnumerable<CqlDate?>? f_ = context.Operators.WhereSelect<Encounter?, CqlDate?>(c_, d_, e_);
        IEnumerable<CqlDate?>? g_ = context.Operators.Distinct<CqlDate?>(f_!);
        return g_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -2855501864183294304L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_During_Initiation_Phase(context);
        bool? b_ = context.Operators.Exists<Encounter?>(a_!);
        bool? c_ = this.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate?>? d_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);

        bool? e_(CqlDate? Encounter1) {
            IEnumerable<CqlDate?>? i_ = this.Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);

            bool? j_(CqlDate? Encounter2) {
                bool? l_ = context.Operators.Not((bool?)(Encounter1 is null));
                bool? m_ = context.Operators.Not((bool?)(Encounter2 is null));
                bool? n_ = context.Operators.And(l_, m_);
                bool? o_ = context.Operators.Equivalent(Encounter1, Encounter2);
                bool? p_ = context.Operators.Not(o_);
                bool? q_ = context.Operators.And(n_, p_);
                return q_;
            }

            bool? k_ = context.Operators.WhereAny<CqlDate?>(i_, j_);
            return k_;
        }

        bool? f_ = context.Operators.WhereAny<CqlDate?>(d_, e_);
        bool? g_ = context.Operators.Or(c_, f_);
        bool? h_ = context.Operators.And(b_, g_);
        return h_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 7798486612078586507L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 7363118988704722449L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 2276067258728685427L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5817697175571891270L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
