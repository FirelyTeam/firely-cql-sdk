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
                FhirString bq_;
                DataType ca_ = MR?.Medication;
                bool cb_ = ca_ is ResourceReference;
                if (cb_)
                {
                    FhirString cc_ = (ca_ as ResourceReference)?.ReferenceElement;
                    bq_ = cc_;
                }
                else
                {
                    bq_ = default;
                }
                string br_ = bq_?.Value;
                IEnumerable<string> bs_ = context.Operators.Split(br_, "/");
                string bt_ = context.Operators.Last<string>(bs_);
                bool? bu_ = context.Operators.Equal(bp_, bt_);
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
            IEnumerable<Medication> cd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ce_(Medication M) {
                Id cg_ = M?.IdElement;
                string ch_ = cg_?.Value;
                FhirString ci_;
                DataType cs_ = MR?.Medication;
                bool ct_ = cs_ is ResourceReference;
                if (ct_)
                {
                    FhirString cu_ = (cs_ as ResourceReference)?.ReferenceElement;
                    ci_ = cu_;
                }
                else
                {
                    ci_ = default;
                }
                string cj_ = ci_?.Value;
                IEnumerable<string> ck_ = context.Operators.Split(cj_, "/");
                string cl_ = context.Operators.Last<string>(ck_);
                bool? cm_ = context.Operators.Equal(ch_, cl_);
                CodeableConcept cn_ = M?.Code;
                CqlConcept co_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cn_);
                CqlValueSet cp_ = this.Clonidine(context);
                bool? cq_ = context.Operators.ConceptInValueSet(co_, cp_);
                bool? cr_ = context.Operators.And(cm_, cq_);
                return cr_;
            }

            bool? cf_ = context.Operators.WhereAny<Medication>(cd_, ce_);
            return cf_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> cv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cw_(Medication M) {
                Id cy_ = M?.IdElement;
                string cz_ = cy_?.Value;
                FhirString da_;
                DataType dk_ = MR?.Medication;
                bool dl_ = dk_ is ResourceReference;
                if (dl_)
                {
                    FhirString dm_ = (dk_ as ResourceReference)?.ReferenceElement;
                    da_ = dm_;
                }
                else
                {
                    da_ = default;
                }
                string db_ = da_?.Value;
                IEnumerable<string> dc_ = context.Operators.Split(db_, "/");
                string dd_ = context.Operators.Last<string>(dc_);
                bool? de_ = context.Operators.Equal(cz_, dd_);
                CodeableConcept df_ = M?.Code;
                CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
                CqlValueSet dh_ = this.Dexmethylphenidate(context);
                bool? di_ = context.Operators.ConceptInValueSet(dg_, dh_);
                bool? dj_ = context.Operators.And(de_, di_);
                return dj_;
            }

            bool? cx_ = context.Operators.WhereAny<Medication>(cv_, cw_);
            return cx_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(a_, m_);
        CqlValueSet o_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest MR) {
            IEnumerable<Medication> dn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? do_(Medication M) {
                Id dq_ = M?.IdElement;
                string dr_ = dq_?.Value;
                FhirString ds_;
                DataType ec_ = MR?.Medication;
                bool ed_ = ec_ is ResourceReference;
                if (ed_)
                {
                    FhirString ee_ = (ec_ as ResourceReference)?.ReferenceElement;
                    ds_ = ee_;
                }
                else
                {
                    ds_ = default;
                }
                string dt_ = ds_?.Value;
                IEnumerable<string> du_ = context.Operators.Split(dt_, "/");
                string dv_ = context.Operators.Last<string>(du_);
                bool? dw_ = context.Operators.Equal(dr_, dv_);
                CodeableConcept dx_ = M?.Code;
                CqlConcept dy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dx_);
                CqlValueSet dz_ = this.Dextroamphetamine(context);
                bool? ea_ = context.Operators.ConceptInValueSet(dy_, dz_);
                bool? eb_ = context.Operators.And(dw_, ea_);
                return eb_;
            }

            bool? dp_ = context.Operators.WhereAny<Medication>(dn_, do_);
            return dp_;
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(a_, s_);
        CqlValueSet u_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> w_ = context.Operators.Union<MedicationRequest>(t_, v_);
        IEnumerable<MedicationRequest> x_ = context.Operators.Union<MedicationRequest>(r_, w_);

        bool? y_(MedicationRequest MR) {
            IEnumerable<Medication> ef_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? eg_(Medication M) {
                Id ei_ = M?.IdElement;
                string ej_ = ei_?.Value;
                FhirString ek_;
                DataType eu_ = MR?.Medication;
                bool ev_ = eu_ is ResourceReference;
                if (ev_)
                {
                    FhirString ew_ = (eu_ as ResourceReference)?.ReferenceElement;
                    ek_ = ew_;
                }
                else
                {
                    ek_ = default;
                }
                string el_ = ek_?.Value;
                IEnumerable<string> em_ = context.Operators.Split(el_, "/");
                string en_ = context.Operators.Last<string>(em_);
                bool? eo_ = context.Operators.Equal(ej_, en_);
                CodeableConcept ep_ = M?.Code;
                CqlConcept eq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ep_);
                CqlValueSet er_ = this.Lisdexamfetamine(context);
                bool? es_ = context.Operators.ConceptInValueSet(eq_, er_);
                bool? et_ = context.Operators.And(eo_, es_);
                return et_;
            }

            bool? eh_ = context.Operators.WhereAny<Medication>(ef_, eg_);
            return eh_;
        }

        IEnumerable<MedicationRequest> z_ = context.Operators.Where<MedicationRequest>(a_, y_);
        CqlValueSet aa_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(z_, ab_);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(x_, ac_);

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> ex_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ey_(Medication M) {
                Id fa_ = M?.IdElement;
                string fb_ = fa_?.Value;
                FhirString fc_;
                DataType fn_ = MR?.Medication;
                bool fo_ = fn_ is ResourceReference;
                if (fo_)
                {
                    FhirString fp_ = (fn_ as ResourceReference)?.ReferenceElement;
                    fc_ = fp_;
                }
                else
                {
                    fc_ = default;
                }
                string fd_ = fc_?.Value;
                IEnumerable<string> fe_ = context.Operators.Split(fd_, "/");
                string ff_ = context.Operators.Last<string>(fe_);
                bool? fg_ = context.Operators.Equal(fb_, ff_);
                CodeableConcept fh_ = M?.Code;
                CqlConcept fi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fh_);
                CqlCode fj_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept fk_ = context.Operators.ConvertCodeToConcept(fj_);
                bool? fl_ = context.Operators.Equivalent(fi_, fk_);
                bool? fm_ = context.Operators.And(fg_, fl_);
                return fm_;
            }

            bool? ez_ = context.Operators.WhereAny<Medication>(ex_, ey_);
            return ez_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(a_, ae_);
        CqlCode ag_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(af_, ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ad_, aj_);

        bool? al_(MedicationRequest MR) {
            IEnumerable<Medication> fq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fr_(Medication M) {
                Id ft_ = M?.IdElement;
                string fu_ = ft_?.Value;
                FhirString fv_;
                DataType gf_ = MR?.Medication;
                bool gg_ = gf_ is ResourceReference;
                if (gg_)
                {
                    FhirString gh_ = (gf_ as ResourceReference)?.ReferenceElement;
                    fv_ = gh_;
                }
                else
                {
                    fv_ = default;
                }
                string fw_ = fv_?.Value;
                IEnumerable<string> fx_ = context.Operators.Split(fw_, "/");
                string fy_ = context.Operators.Last<string>(fx_);
                bool? fz_ = context.Operators.Equal(fu_, fy_);
                CodeableConcept ga_ = M?.Code;
                CqlConcept gb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ga_);
                CqlValueSet gc_ = this.Methylphenidate(context);
                bool? gd_ = context.Operators.ConceptInValueSet(gb_, gc_);
                bool? ge_ = context.Operators.And(fz_, gd_);
                return ge_;
            }

            bool? fs_ = context.Operators.WhereAny<Medication>(fq_, fr_);
            return fs_;
        }

        IEnumerable<MedicationRequest> am_ = context.Operators.Where<MedicationRequest>(a_, al_);
        CqlValueSet an_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Union<MedicationRequest>(ak_, ap_);

        bool? ar_(MedicationRequest MR) {
            IEnumerable<Medication> gi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gj_(Medication M) {
                Id gl_ = M?.IdElement;
                string gm_ = gl_?.Value;
                FhirString gn_;
                DataType gx_ = MR?.Medication;
                bool gy_ = gx_ is ResourceReference;
                if (gy_)
                {
                    FhirString gz_ = (gx_ as ResourceReference)?.ReferenceElement;
                    gn_ = gz_;
                }
                else
                {
                    gn_ = default;
                }
                string go_ = gn_?.Value;
                IEnumerable<string> gp_ = context.Operators.Split(go_, "/");
                string gq_ = context.Operators.Last<string>(gp_);
                bool? gr_ = context.Operators.Equal(gm_, gq_);
                CodeableConcept gs_ = M?.Code;
                CqlConcept gt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gs_);
                CqlValueSet gu_ = this.Guanfacine_Medications(context);
                bool? gv_ = context.Operators.ConceptInValueSet(gt_, gu_);
                bool? gw_ = context.Operators.And(gr_, gv_);
                return gw_;
            }

            bool? gk_ = context.Operators.WhereAny<Medication>(gi_, gj_);
            return gk_;
        }

        IEnumerable<MedicationRequest> as_ = context.Operators.Where<MedicationRequest>(a_, ar_);
        CqlValueSet at_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(aq_, av_);

        bool? ax_(MedicationRequest MR) {
            IEnumerable<Medication> ha_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hb_(Medication M) {
                Id hd_ = M?.IdElement;
                string he_ = hd_?.Value;
                FhirString hf_;
                DataType hp_ = MR?.Medication;
                bool hq_ = hp_ is ResourceReference;
                if (hq_)
                {
                    FhirString hr_ = (hp_ as ResourceReference)?.ReferenceElement;
                    hf_ = hr_;
                }
                else
                {
                    hf_ = default;
                }
                string hg_ = hf_?.Value;
                IEnumerable<string> hh_ = context.Operators.Split(hg_, "/");
                string hi_ = context.Operators.Last<string>(hh_);
                bool? hj_ = context.Operators.Equal(he_, hi_);
                CodeableConcept hk_ = M?.Code;
                CqlConcept hl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hk_);
                CqlValueSet hm_ = this.Viloxazine(context);
                bool? hn_ = context.Operators.ConceptInValueSet(hl_, hm_);
                bool? ho_ = context.Operators.And(hj_, hn_);
                return ho_;
            }

            bool? hc_ = context.Operators.WhereAny<Medication>(ha_, hb_);
            return hc_;
        }

        IEnumerable<MedicationRequest> ay_ = context.Operators.Where<MedicationRequest>(a_, ax_);
        CqlValueSet az_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, az_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(ay_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(aw_, bb_);
        IEnumerable<MedicationRequest> bd_ = Status_1_15_000.Instance.isMedicationOrder(context, bc_);

        bool? be_(MedicationRequest ADHDMedications) {
            CqlInterval<CqlDate> hs_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate ht_ = context.Operators.Start(hs_);
            CqlDateTime hu_ = context.Operators.ConvertDateToDateTime(ht_);
            CqlInterval<CqlDateTime> hv_ = this.Intake_Period(context);
            bool? hw_ = context.Operators.In<CqlDateTime>(hu_, hv_, (string)default);
            return hw_;
        }

        IEnumerable<MedicationRequest> bf_ = context.Operators.Where<MedicationRequest>(bd_, be_);

        bool? bg_(MedicationRequest ADHDMedicationOrder) {
            IEnumerable<MedicationRequest> hx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? hy_(MedicationRequest MR) {
                IEnumerable<Medication> ke_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? kf_(Medication M) {
                    Id kh_ = M?.IdElement;
                    string ki_ = kh_?.Value;
                    FhirString kj_;
                    DataType kt_ = MR?.Medication;
                    bool ku_ = kt_ is ResourceReference;
                    if (ku_)
                    {
                        FhirString kv_ = (kt_ as ResourceReference)?.ReferenceElement;
                        kj_ = kv_;
                    }
                    else
                    {
                        kj_ = default;
                    }
                    string kk_ = kj_?.Value;
                    IEnumerable<string> kl_ = context.Operators.Split(kk_, "/");
                    string km_ = context.Operators.Last<string>(kl_);
                    bool? kn_ = context.Operators.Equal(ki_, km_);
                    CodeableConcept ko_ = M?.Code;
                    CqlConcept kp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ko_);
                    CqlValueSet kq_ = this.Atomoxetine(context);
                    bool? kr_ = context.Operators.ConceptInValueSet(kp_, kq_);
                    bool? ks_ = context.Operators.And(kn_, kr_);
                    return ks_;
                }

                bool? kg_ = context.Operators.WhereAny<Medication>(ke_, kf_);
                return kg_;
            }

            IEnumerable<MedicationRequest> hz_ = context.Operators.Where<MedicationRequest>(hx_, hy_);
            CqlValueSet ia_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> ib_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ia_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ic_ = context.Operators.Union<MedicationRequest>(hz_, ib_);

            bool? id_(MedicationRequest MR) {
                IEnumerable<Medication> kw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? kx_(Medication M) {
                    Id kz_ = M?.IdElement;
                    string la_ = kz_?.Value;
                    FhirString lb_;
                    DataType ll_ = MR?.Medication;
                    bool lm_ = ll_ is ResourceReference;
                    if (lm_)
                    {
                        FhirString ln_ = (ll_ as ResourceReference)?.ReferenceElement;
                        lb_ = ln_;
                    }
                    else
                    {
                        lb_ = default;
                    }
                    string lc_ = lb_?.Value;
                    IEnumerable<string> ld_ = context.Operators.Split(lc_, "/");
                    string le_ = context.Operators.Last<string>(ld_);
                    bool? lf_ = context.Operators.Equal(la_, le_);
                    CodeableConcept lg_ = M?.Code;
                    CqlConcept lh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lg_);
                    CqlValueSet li_ = this.Clonidine(context);
                    bool? lj_ = context.Operators.ConceptInValueSet(lh_, li_);
                    bool? lk_ = context.Operators.And(lf_, lj_);
                    return lk_;
                }

                bool? ky_ = context.Operators.WhereAny<Medication>(kw_, kx_);
                return ky_;
            }

            IEnumerable<MedicationRequest> ie_ = context.Operators.Where<MedicationRequest>(hx_, id_);
            CqlValueSet if_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> ig_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, if_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ih_ = context.Operators.Union<MedicationRequest>(ie_, ig_);
            IEnumerable<MedicationRequest> ii_ = context.Operators.Union<MedicationRequest>(ic_, ih_);

            bool? ij_(MedicationRequest MR) {
                IEnumerable<Medication> lo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? lp_(Medication M) {
                    Id lr_ = M?.IdElement;
                    string ls_ = lr_?.Value;
                    FhirString lt_;
                    DataType md_ = MR?.Medication;
                    bool me_ = md_ is ResourceReference;
                    if (me_)
                    {
                        FhirString mf_ = (md_ as ResourceReference)?.ReferenceElement;
                        lt_ = mf_;
                    }
                    else
                    {
                        lt_ = default;
                    }
                    string lu_ = lt_?.Value;
                    IEnumerable<string> lv_ = context.Operators.Split(lu_, "/");
                    string lw_ = context.Operators.Last<string>(lv_);
                    bool? lx_ = context.Operators.Equal(ls_, lw_);
                    CodeableConcept ly_ = M?.Code;
                    CqlConcept lz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ly_);
                    CqlValueSet ma_ = this.Dexmethylphenidate(context);
                    bool? mb_ = context.Operators.ConceptInValueSet(lz_, ma_);
                    bool? mc_ = context.Operators.And(lx_, mb_);
                    return mc_;
                }

                bool? lq_ = context.Operators.WhereAny<Medication>(lo_, lp_);
                return lq_;
            }

            IEnumerable<MedicationRequest> ik_ = context.Operators.Where<MedicationRequest>(hx_, ij_);
            CqlValueSet il_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> im_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, il_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> in_ = context.Operators.Union<MedicationRequest>(ik_, im_);
            IEnumerable<MedicationRequest> io_ = context.Operators.Union<MedicationRequest>(ii_, in_);

            bool? ip_(MedicationRequest MR) {
                IEnumerable<Medication> mg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? mh_(Medication M) {
                    Id mj_ = M?.IdElement;
                    string mk_ = mj_?.Value;
                    FhirString ml_;
                    DataType mv_ = MR?.Medication;
                    bool mw_ = mv_ is ResourceReference;
                    if (mw_)
                    {
                        FhirString mx_ = (mv_ as ResourceReference)?.ReferenceElement;
                        ml_ = mx_;
                    }
                    else
                    {
                        ml_ = default;
                    }
                    string mm_ = ml_?.Value;
                    IEnumerable<string> mn_ = context.Operators.Split(mm_, "/");
                    string mo_ = context.Operators.Last<string>(mn_);
                    bool? mp_ = context.Operators.Equal(mk_, mo_);
                    CodeableConcept mq_ = M?.Code;
                    CqlConcept mr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mq_);
                    CqlValueSet ms_ = this.Dextroamphetamine(context);
                    bool? mt_ = context.Operators.ConceptInValueSet(mr_, ms_);
                    bool? mu_ = context.Operators.And(mp_, mt_);
                    return mu_;
                }

                bool? mi_ = context.Operators.WhereAny<Medication>(mg_, mh_);
                return mi_;
            }

            IEnumerable<MedicationRequest> iq_ = context.Operators.Where<MedicationRequest>(hx_, ip_);
            CqlValueSet ir_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> is_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ir_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> it_ = context.Operators.Union<MedicationRequest>(iq_, is_);
            IEnumerable<MedicationRequest> iu_ = context.Operators.Union<MedicationRequest>(io_, it_);

            bool? iv_(MedicationRequest MR) {
                IEnumerable<Medication> my_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? mz_(Medication M) {
                    Id nb_ = M?.IdElement;
                    string nc_ = nb_?.Value;
                    FhirString nd_;
                    DataType nn_ = MR?.Medication;
                    bool no_ = nn_ is ResourceReference;
                    if (no_)
                    {
                        FhirString np_ = (nn_ as ResourceReference)?.ReferenceElement;
                        nd_ = np_;
                    }
                    else
                    {
                        nd_ = default;
                    }
                    string ne_ = nd_?.Value;
                    IEnumerable<string> nf_ = context.Operators.Split(ne_, "/");
                    string ng_ = context.Operators.Last<string>(nf_);
                    bool? nh_ = context.Operators.Equal(nc_, ng_);
                    CodeableConcept ni_ = M?.Code;
                    CqlConcept nj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ni_);
                    CqlValueSet nk_ = this.Lisdexamfetamine(context);
                    bool? nl_ = context.Operators.ConceptInValueSet(nj_, nk_);
                    bool? nm_ = context.Operators.And(nh_, nl_);
                    return nm_;
                }

                bool? na_ = context.Operators.WhereAny<Medication>(my_, mz_);
                return na_;
            }

            IEnumerable<MedicationRequest> iw_ = context.Operators.Where<MedicationRequest>(hx_, iv_);
            CqlValueSet ix_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> iy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ix_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> iz_ = context.Operators.Union<MedicationRequest>(iw_, iy_);
            IEnumerable<MedicationRequest> ja_ = context.Operators.Union<MedicationRequest>(iu_, iz_);

            bool? jb_(MedicationRequest MR) {
                IEnumerable<Medication> nq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? nr_(Medication M) {
                    Id nt_ = M?.IdElement;
                    string nu_ = nt_?.Value;
                    FhirString nv_;
                    DataType og_ = MR?.Medication;
                    bool oh_ = og_ is ResourceReference;
                    if (oh_)
                    {
                        FhirString oi_ = (og_ as ResourceReference)?.ReferenceElement;
                        nv_ = oi_;
                    }
                    else
                    {
                        nv_ = default;
                    }
                    string nw_ = nv_?.Value;
                    IEnumerable<string> nx_ = context.Operators.Split(nw_, "/");
                    string ny_ = context.Operators.Last<string>(nx_);
                    bool? nz_ = context.Operators.Equal(nu_, ny_);
                    CodeableConcept oa_ = M?.Code;
                    CqlConcept ob_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, oa_);
                    CqlCode oc_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                    CqlConcept od_ = context.Operators.ConvertCodeToConcept(oc_);
                    bool? oe_ = context.Operators.Equivalent(ob_, od_);
                    bool? of_ = context.Operators.And(nz_, oe_);
                    return of_;
                }

                bool? ns_ = context.Operators.WhereAny<Medication>(nq_, nr_);
                return ns_;
            }

            IEnumerable<MedicationRequest> jc_ = context.Operators.Where<MedicationRequest>(hx_, jb_);
            CqlCode jd_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> je_ = context.Operators.ToList<CqlCode>(jd_);
            IEnumerable<MedicationRequest> jf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, je_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jg_ = context.Operators.Union<MedicationRequest>(jc_, jf_);
            IEnumerable<MedicationRequest> jh_ = context.Operators.Union<MedicationRequest>(ja_, jg_);

            bool? ji_(MedicationRequest MR) {
                IEnumerable<Medication> oj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ok_(Medication M) {
                    Id om_ = M?.IdElement;
                    string on_ = om_?.Value;
                    FhirString oo_;
                    DataType oy_ = MR?.Medication;
                    bool oz_ = oy_ is ResourceReference;
                    if (oz_)
                    {
                        FhirString pa_ = (oy_ as ResourceReference)?.ReferenceElement;
                        oo_ = pa_;
                    }
                    else
                    {
                        oo_ = default;
                    }
                    string op_ = oo_?.Value;
                    IEnumerable<string> oq_ = context.Operators.Split(op_, "/");
                    string or_ = context.Operators.Last<string>(oq_);
                    bool? os_ = context.Operators.Equal(on_, or_);
                    CodeableConcept ot_ = M?.Code;
                    CqlConcept ou_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ot_);
                    CqlValueSet ov_ = this.Methylphenidate(context);
                    bool? ow_ = context.Operators.ConceptInValueSet(ou_, ov_);
                    bool? ox_ = context.Operators.And(os_, ow_);
                    return ox_;
                }

                bool? ol_ = context.Operators.WhereAny<Medication>(oj_, ok_);
                return ol_;
            }

            IEnumerable<MedicationRequest> jj_ = context.Operators.Where<MedicationRequest>(hx_, ji_);
            CqlValueSet jk_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> jl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jm_ = context.Operators.Union<MedicationRequest>(jj_, jl_);
            IEnumerable<MedicationRequest> jn_ = context.Operators.Union<MedicationRequest>(jh_, jm_);

            bool? jo_(MedicationRequest MR) {
                IEnumerable<Medication> pb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? pc_(Medication M) {
                    Id pe_ = M?.IdElement;
                    string pf_ = pe_?.Value;
                    FhirString pg_;
                    DataType pq_ = MR?.Medication;
                    bool pr_ = pq_ is ResourceReference;
                    if (pr_)
                    {
                        FhirString ps_ = (pq_ as ResourceReference)?.ReferenceElement;
                        pg_ = ps_;
                    }
                    else
                    {
                        pg_ = default;
                    }
                    string ph_ = pg_?.Value;
                    IEnumerable<string> pi_ = context.Operators.Split(ph_, "/");
                    string pj_ = context.Operators.Last<string>(pi_);
                    bool? pk_ = context.Operators.Equal(pf_, pj_);
                    CodeableConcept pl_ = M?.Code;
                    CqlConcept pm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pl_);
                    CqlValueSet pn_ = this.Guanfacine_Medications(context);
                    bool? po_ = context.Operators.ConceptInValueSet(pm_, pn_);
                    bool? pp_ = context.Operators.And(pk_, po_);
                    return pp_;
                }

                bool? pd_ = context.Operators.WhereAny<Medication>(pb_, pc_);
                return pd_;
            }

            IEnumerable<MedicationRequest> jp_ = context.Operators.Where<MedicationRequest>(hx_, jo_);
            CqlValueSet jq_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> jr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> js_ = context.Operators.Union<MedicationRequest>(jp_, jr_);
            IEnumerable<MedicationRequest> jt_ = context.Operators.Union<MedicationRequest>(jn_, js_);

            bool? ju_(MedicationRequest MR) {
                IEnumerable<Medication> pt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? pu_(Medication M) {
                    Id pw_ = M?.IdElement;
                    string px_ = pw_?.Value;
                    FhirString py_;
                    DataType qi_ = MR?.Medication;
                    bool qj_ = qi_ is ResourceReference;
                    if (qj_)
                    {
                        FhirString qk_ = (qi_ as ResourceReference)?.ReferenceElement;
                        py_ = qk_;
                    }
                    else
                    {
                        py_ = default;
                    }
                    string pz_ = py_?.Value;
                    IEnumerable<string> qa_ = context.Operators.Split(pz_, "/");
                    string qb_ = context.Operators.Last<string>(qa_);
                    bool? qc_ = context.Operators.Equal(px_, qb_);
                    CodeableConcept qd_ = M?.Code;
                    CqlConcept qe_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qd_);
                    CqlValueSet qf_ = this.Viloxazine(context);
                    bool? qg_ = context.Operators.ConceptInValueSet(qe_, qf_);
                    bool? qh_ = context.Operators.And(qc_, qg_);
                    return qh_;
                }

                bool? pv_ = context.Operators.WhereAny<Medication>(pt_, pu_);
                return pv_;
            }

            IEnumerable<MedicationRequest> jv_ = context.Operators.Where<MedicationRequest>(hx_, ju_);
            CqlValueSet jw_ = this.Viloxazine(context);
            IEnumerable<MedicationRequest> jx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jy_ = context.Operators.Union<MedicationRequest>(jv_, jx_);
            IEnumerable<MedicationRequest> jz_ = context.Operators.Union<MedicationRequest>(jt_, jy_);
            IEnumerable<MedicationRequest> ka_ = Status_1_15_000.Instance.isMedicationActive(context, jz_);

            bool? kb_(MedicationRequest ActiveADHDMedication) {
                CqlInterval<CqlDate> ql_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> qm_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate qn_ = context.Operators.Start(qm_);
                CqlDateTime qo_ = context.Operators.ConvertDateToDateTime(qn_);
                CqlDate qp_ = context.Operators.DateFrom(qo_);
                CqlQuantity qq_ = context.Operators.Quantity(120m, "days");
                CqlDate qr_ = context.Operators.Subtract(qp_, qq_);
                CqlInterval<CqlDate> qs_ = context.Operators.Interval(qr_, qp_, true, false);
                bool? qt_ = context.Operators.Overlaps(ql_, qs_, (string)default);
                return qt_;
            }

            bool? kc_ = context.Operators.WhereAny<MedicationRequest>(ka_, kb_);
            bool? kd_ = context.Operators.Not(kc_);
            return kd_;
        }


        (CqlTupleMetadata, CqlDate startDate)? bh_(MedicationRequest QualifyingMed) {
            CqlInterval<CqlDate> qu_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate qv_ = context.Operators.Start(qu_);
            (CqlTupleMetadata, CqlDate startDate)? qw_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, qv_);
            return qw_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> bi_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(bf_, bg_, bh_);

        object bj_((CqlTupleMetadata, CqlDate startDate)? @this) {
            CqlDate qx_ = @this?.startDate;
            return qx_;
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
                FhirString en_;
                DataType ex_ = MR?.Medication;
                bool ey_ = ex_ is ResourceReference;
                if (ey_)
                {
                    FhirString ez_ = (ex_ as ResourceReference)?.ReferenceElement;
                    en_ = ez_;
                }
                else
                {
                    en_ = default;
                }
                string eo_ = en_?.Value;
                IEnumerable<string> ep_ = context.Operators.Split(eo_, "/");
                string eq_ = context.Operators.Last<string>(ep_);
                bool? er_ = context.Operators.Equal(em_, eq_);
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
            CqlInterval<CqlDate> fa_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate fb_ = context.Operators.Start(fa_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fc_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fa_, fb_);
            return fc_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(g_, h_);

        object j_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate fd_ = @this?.periodStart;
            return fd_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);

        bool? l_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fe_ = @this?.period;
            bool? ff_ = context.Operators.Not((bool?)(fe_ is null));
            return ff_;
        }


        CqlInterval<CqlDate> m_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> fg_ = @this?.period;
            return fg_;
        }

        IEnumerable<CqlInterval<CqlDate>> n_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(k_, l_, m_);
        IEnumerable<CqlInterval<CqlDate>> o_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, n_);

        bool? p_(MedicationRequest MR) {
            IEnumerable<Medication> fh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fi_(Medication M) {
                Id fk_ = M?.IdElement;
                string fl_ = fk_?.Value;
                FhirString fm_;
                DataType fw_ = MR?.Medication;
                bool fx_ = fw_ is ResourceReference;
                if (fx_)
                {
                    FhirString fy_ = (fw_ as ResourceReference)?.ReferenceElement;
                    fm_ = fy_;
                }
                else
                {
                    fm_ = default;
                }
                string fn_ = fm_?.Value;
                IEnumerable<string> fo_ = context.Operators.Split(fn_, "/");
                string fp_ = context.Operators.Last<string>(fo_);
                bool? fq_ = context.Operators.Equal(fl_, fp_);
                CodeableConcept fr_ = M?.Code;
                CqlConcept fs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fr_);
                CqlValueSet ft_ = this.Clonidine(context);
                bool? fu_ = context.Operators.ConceptInValueSet(fs_, ft_);
                bool? fv_ = context.Operators.And(fq_, fu_);
                return fv_;
            }

            bool? fj_ = context.Operators.WhereAny<Medication>(fh_, fi_);
            return fj_;
        }

        IEnumerable<MedicationRequest> q_ = context.Operators.Where<MedicationRequest>(a_, p_);
        CqlValueSet r_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> s_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(q_, s_);
        IEnumerable<MedicationRequest> u_ = Status_1_15_000.Instance.isMedicationOrder(context, t_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? v_(MedicationRequest ClonidineMed) {
            CqlInterval<CqlDate> fz_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate ga_ = context.Operators.Start(fz_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gb_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fz_, ga_);
            return gb_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> w_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(u_, v_);

        object x_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate gc_ = @this?.periodStart;
            return gc_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> y_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);

        bool? z_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gd_ = @this?.period;
            bool? ge_ = context.Operators.Not((bool?)(gd_ is null));
            return ge_;
        }


        CqlInterval<CqlDate> aa_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> gf_ = @this?.period;
            return gf_;
        }

        IEnumerable<CqlInterval<CqlDate>> ab_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(y_, z_, aa_);
        IEnumerable<CqlInterval<CqlDate>> ac_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ab_);
        IEnumerable<CqlInterval<CqlDate>> ad_ = context.Operators.Union<CqlInterval<CqlDate>>(o_, ac_);

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> gg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gh_(Medication M) {
                Id gj_ = M?.IdElement;
                string gk_ = gj_?.Value;
                FhirString gl_;
                DataType gv_ = MR?.Medication;
                bool gw_ = gv_ is ResourceReference;
                if (gw_)
                {
                    FhirString gx_ = (gv_ as ResourceReference)?.ReferenceElement;
                    gl_ = gx_;
                }
                else
                {
                    gl_ = default;
                }
                string gm_ = gl_?.Value;
                IEnumerable<string> gn_ = context.Operators.Split(gm_, "/");
                string go_ = context.Operators.Last<string>(gn_);
                bool? gp_ = context.Operators.Equal(gk_, go_);
                CodeableConcept gq_ = M?.Code;
                CqlConcept gr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gq_);
                CqlValueSet gs_ = this.Dexmethylphenidate(context);
                bool? gt_ = context.Operators.ConceptInValueSet(gr_, gs_);
                bool? gu_ = context.Operators.And(gp_, gt_);
                return gu_;
            }

            bool? gi_ = context.Operators.WhereAny<Medication>(gg_, gh_);
            return gi_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(a_, ae_);
        CqlValueSet ag_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ai_ = context.Operators.Union<MedicationRequest>(af_, ah_);
        IEnumerable<MedicationRequest> aj_ = Status_1_15_000.Instance.isMedicationOrder(context, ai_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ak_(MedicationRequest DexmethylphenidateMed) {
            CqlInterval<CqlDate> gy_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate gz_ = context.Operators.Start(gy_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ha_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gy_, gz_);
            return ha_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> al_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(aj_, ak_);

        object am_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate hb_ = @this?.periodStart;
            return hb_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> an_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);

        bool? ao_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> hc_ = @this?.period;
            bool? hd_ = context.Operators.Not((bool?)(hc_ is null));
            return hd_;
        }


        CqlInterval<CqlDate> ap_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> he_ = @this?.period;
            return he_;
        }

        IEnumerable<CqlInterval<CqlDate>> aq_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(an_, ao_, ap_);
        IEnumerable<CqlInterval<CqlDate>> ar_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, aq_);

        bool? as_(MedicationRequest MR) {
            IEnumerable<Medication> hf_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hg_(Medication M) {
                Id hi_ = M?.IdElement;
                string hj_ = hi_?.Value;
                FhirString hk_;
                DataType hu_ = MR?.Medication;
                bool hv_ = hu_ is ResourceReference;
                if (hv_)
                {
                    FhirString hw_ = (hu_ as ResourceReference)?.ReferenceElement;
                    hk_ = hw_;
                }
                else
                {
                    hk_ = default;
                }
                string hl_ = hk_?.Value;
                IEnumerable<string> hm_ = context.Operators.Split(hl_, "/");
                string hn_ = context.Operators.Last<string>(hm_);
                bool? ho_ = context.Operators.Equal(hj_, hn_);
                CodeableConcept hp_ = M?.Code;
                CqlConcept hq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hp_);
                CqlValueSet hr_ = this.Dextroamphetamine(context);
                bool? hs_ = context.Operators.ConceptInValueSet(hq_, hr_);
                bool? ht_ = context.Operators.And(ho_, hs_);
                return ht_;
            }

            bool? hh_ = context.Operators.WhereAny<Medication>(hf_, hg_);
            return hh_;
        }

        IEnumerable<MedicationRequest> at_ = context.Operators.Where<MedicationRequest>(a_, as_);
        CqlValueSet au_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> av_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, au_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(at_, av_);
        IEnumerable<MedicationRequest> ax_ = Status_1_15_000.Instance.isMedicationOrder(context, aw_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ay_(MedicationRequest DextroamphetamineMed) {
            CqlInterval<CqlDate> hx_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate hy_ = context.Operators.Start(hx_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hz_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, hx_, hy_);
            return hz_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> az_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ax_, ay_);

        object ba_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate ia_ = @this?.periodStart;
            return ia_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bb_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ib_ = @this?.period;
            bool? ic_ = context.Operators.Not((bool?)(ib_ is null));
            return ic_;
        }


        CqlInterval<CqlDate> bd_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> id_ = @this?.period;
            return id_;
        }

        IEnumerable<CqlInterval<CqlDate>> be_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bb_, bc_, bd_);
        IEnumerable<CqlInterval<CqlDate>> bf_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, be_);
        IEnumerable<CqlInterval<CqlDate>> bg_ = context.Operators.Union<CqlInterval<CqlDate>>(ar_, bf_);
        IEnumerable<CqlInterval<CqlDate>> bh_ = context.Operators.Union<CqlInterval<CqlDate>>(ad_, bg_);

        bool? bi_(MedicationRequest MR) {
            IEnumerable<Medication> ie_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? if_(Medication M) {
                Id ih_ = M?.IdElement;
                string ii_ = ih_?.Value;
                FhirString ij_;
                DataType it_ = MR?.Medication;
                bool iu_ = it_ is ResourceReference;
                if (iu_)
                {
                    FhirString iv_ = (it_ as ResourceReference)?.ReferenceElement;
                    ij_ = iv_;
                }
                else
                {
                    ij_ = default;
                }
                string ik_ = ij_?.Value;
                IEnumerable<string> il_ = context.Operators.Split(ik_, "/");
                string im_ = context.Operators.Last<string>(il_);
                bool? in_ = context.Operators.Equal(ii_, im_);
                CodeableConcept io_ = M?.Code;
                CqlConcept ip_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, io_);
                CqlValueSet iq_ = this.Lisdexamfetamine(context);
                bool? ir_ = context.Operators.ConceptInValueSet(ip_, iq_);
                bool? is_ = context.Operators.And(in_, ir_);
                return is_;
            }

            bool? ig_ = context.Operators.WhereAny<Medication>(ie_, if_);
            return ig_;
        }

        IEnumerable<MedicationRequest> bj_ = context.Operators.Where<MedicationRequest>(a_, bi_);
        CqlValueSet bk_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> bl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bm_ = context.Operators.Union<MedicationRequest>(bj_, bl_);
        IEnumerable<MedicationRequest> bn_ = Status_1_15_000.Instance.isMedicationOrder(context, bm_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? bo_(MedicationRequest LisdexamfetamineMed) {
            CqlInterval<CqlDate> iw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate ix_ = context.Operators.Start(iw_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? iy_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, iw_, ix_);
            return iy_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bp_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bn_, bo_);

        object bq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate iz_ = @this?.periodStart;
            return iz_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> br_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);

        bool? bs_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ja_ = @this?.period;
            bool? jb_ = context.Operators.Not((bool?)(ja_ is null));
            return jb_;
        }


        CqlInterval<CqlDate> bt_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jc_ = @this?.period;
            return jc_;
        }

        IEnumerable<CqlInterval<CqlDate>> bu_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(br_, bs_, bt_);
        IEnumerable<CqlInterval<CqlDate>> bv_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, bu_);

        bool? bw_(MedicationRequest MR) {
            IEnumerable<Medication> jd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? je_(Medication M) {
                Id jg_ = M?.IdElement;
                string jh_ = jg_?.Value;
                FhirString ji_;
                DataType js_ = MR?.Medication;
                bool jt_ = js_ is ResourceReference;
                if (jt_)
                {
                    FhirString ju_ = (js_ as ResourceReference)?.ReferenceElement;
                    ji_ = ju_;
                }
                else
                {
                    ji_ = default;
                }
                string jj_ = ji_?.Value;
                IEnumerable<string> jk_ = context.Operators.Split(jj_, "/");
                string jl_ = context.Operators.Last<string>(jk_);
                bool? jm_ = context.Operators.Equal(jh_, jl_);
                CodeableConcept jn_ = M?.Code;
                CqlConcept jo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jn_);
                CqlValueSet jp_ = this.Methylphenidate(context);
                bool? jq_ = context.Operators.ConceptInValueSet(jo_, jp_);
                bool? jr_ = context.Operators.And(jm_, jq_);
                return jr_;
            }

            bool? jf_ = context.Operators.WhereAny<Medication>(jd_, je_);
            return jf_;
        }

        IEnumerable<MedicationRequest> bx_ = context.Operators.Where<MedicationRequest>(a_, bw_);
        CqlValueSet by_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> bz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, by_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bx_, bz_);
        IEnumerable<MedicationRequest> cb_ = Status_1_15_000.Instance.isMedicationOrder(context, ca_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cc_(MedicationRequest MethylphenidateMed) {
            CqlInterval<CqlDate> jv_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate jw_ = context.Operators.Start(jv_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jx_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jv_, jw_);
            return jx_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cd_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cb_, cc_);

        object ce_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate jy_ = @this?.periodStart;
            return jy_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> jz_ = @this?.period;
            bool? ka_ = context.Operators.Not((bool?)(jz_ is null));
            return ka_;
        }


        CqlInterval<CqlDate> ch_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> kb_ = @this?.period;
            return kb_;
        }

        IEnumerable<CqlInterval<CqlDate>> ci_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cf_, cg_, ch_);
        IEnumerable<CqlInterval<CqlDate>> cj_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ci_);
        IEnumerable<CqlInterval<CqlDate>> ck_ = context.Operators.Union<CqlInterval<CqlDate>>(bv_, cj_);
        IEnumerable<CqlInterval<CqlDate>> cl_ = context.Operators.Union<CqlInterval<CqlDate>>(bh_, ck_);

        bool? cm_(MedicationRequest MR) {
            IEnumerable<Medication> kc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kd_(Medication M) {
                Id kf_ = M?.IdElement;
                string kg_ = kf_?.Value;
                FhirString kh_;
                DataType kr_ = MR?.Medication;
                bool ks_ = kr_ is ResourceReference;
                if (ks_)
                {
                    FhirString kt_ = (kr_ as ResourceReference)?.ReferenceElement;
                    kh_ = kt_;
                }
                else
                {
                    kh_ = default;
                }
                string ki_ = kh_?.Value;
                IEnumerable<string> kj_ = context.Operators.Split(ki_, "/");
                string kk_ = context.Operators.Last<string>(kj_);
                bool? kl_ = context.Operators.Equal(kg_, kk_);
                CodeableConcept km_ = M?.Code;
                CqlConcept kn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, km_);
                CqlValueSet ko_ = this.Guanfacine_Medications(context);
                bool? kp_ = context.Operators.ConceptInValueSet(kn_, ko_);
                bool? kq_ = context.Operators.And(kl_, kp_);
                return kq_;
            }

            bool? ke_ = context.Operators.WhereAny<Medication>(kc_, kd_);
            return ke_;
        }

        IEnumerable<MedicationRequest> cn_ = context.Operators.Where<MedicationRequest>(a_, cm_);
        CqlValueSet co_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> cp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cq_ = context.Operators.Union<MedicationRequest>(cn_, cp_);
        IEnumerable<MedicationRequest> cr_ = Status_1_15_000.Instance.isMedicationOrder(context, cq_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cs_(MedicationRequest GuanfacineMed) {
            CqlInterval<CqlDate> ku_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate kv_ = context.Operators.Start(ku_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kw_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ku_, kv_);
            return kw_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ct_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cr_, cs_);

        object cu_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate kx_ = @this?.periodStart;
            return kx_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);

        bool? cw_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ky_ = @this?.period;
            bool? kz_ = context.Operators.Not((bool?)(ky_ is null));
            return kz_;
        }


        CqlInterval<CqlDate> cx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> la_ = @this?.period;
            return la_;
        }

        IEnumerable<CqlInterval<CqlDate>> cy_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cv_, cw_, cx_);
        IEnumerable<CqlInterval<CqlDate>> cz_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, cy_);

        bool? da_(MedicationRequest MR) {
            IEnumerable<Medication> lb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lc_(Medication M) {
                Id le_ = M?.IdElement;
                string lf_ = le_?.Value;
                FhirString lg_;
                DataType lr_ = MR?.Medication;
                bool ls_ = lr_ is ResourceReference;
                if (ls_)
                {
                    FhirString lt_ = (lr_ as ResourceReference)?.ReferenceElement;
                    lg_ = lt_;
                }
                else
                {
                    lg_ = default;
                }
                string lh_ = lg_?.Value;
                IEnumerable<string> li_ = context.Operators.Split(lh_, "/");
                string lj_ = context.Operators.Last<string>(li_);
                bool? lk_ = context.Operators.Equal(lf_, lj_);
                CodeableConcept ll_ = M?.Code;
                CqlConcept lm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ll_);
                CqlCode ln_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept lo_ = context.Operators.ConvertCodeToConcept(ln_);
                bool? lp_ = context.Operators.Equivalent(lm_, lo_);
                bool? lq_ = context.Operators.And(lk_, lp_);
                return lq_;
            }

            bool? ld_ = context.Operators.WhereAny<Medication>(lb_, lc_);
            return ld_;
        }

        IEnumerable<MedicationRequest> db_ = context.Operators.Where<MedicationRequest>(a_, da_);
        CqlCode dc_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> dd_ = context.Operators.ToList<CqlCode>(dc_);
        IEnumerable<MedicationRequest> de_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, dd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(db_, de_);
        IEnumerable<MedicationRequest> dg_ = Status_1_15_000.Instance.isMedicationOrder(context, df_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dh_(MedicationRequest MethamphetamineMed) {
            CqlInterval<CqlDate> lu_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate lv_ = context.Operators.Start(lu_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lw_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, lu_, lv_);
            return lw_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> di_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dg_, dh_);

        object dj_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate lx_ = @this?.periodStart;
            return lx_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(di_, dj_, System.ComponentModel.ListSortDirection.Ascending);

        bool? dl_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ly_ = @this?.period;
            bool? lz_ = context.Operators.Not((bool?)(ly_ is null));
            return lz_;
        }


        CqlInterval<CqlDate> dm_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> ma_ = @this?.period;
            return ma_;
        }

        IEnumerable<CqlInterval<CqlDate>> dn_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dk_, dl_, dm_);
        IEnumerable<CqlInterval<CqlDate>> do_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, dn_);
        IEnumerable<CqlInterval<CqlDate>> dp_ = context.Operators.Union<CqlInterval<CqlDate>>(cz_, do_);
        IEnumerable<CqlInterval<CqlDate>> dq_ = context.Operators.Union<CqlInterval<CqlDate>>(cl_, dp_);

        bool? dr_(MedicationRequest MR) {
            IEnumerable<Medication> mb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? mc_(Medication M) {
                Id me_ = M?.IdElement;
                string mf_ = me_?.Value;
                FhirString mg_;
                DataType mq_ = MR?.Medication;
                bool mr_ = mq_ is ResourceReference;
                if (mr_)
                {
                    FhirString ms_ = (mq_ as ResourceReference)?.ReferenceElement;
                    mg_ = ms_;
                }
                else
                {
                    mg_ = default;
                }
                string mh_ = mg_?.Value;
                IEnumerable<string> mi_ = context.Operators.Split(mh_, "/");
                string mj_ = context.Operators.Last<string>(mi_);
                bool? mk_ = context.Operators.Equal(mf_, mj_);
                CodeableConcept ml_ = M?.Code;
                CqlConcept mm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ml_);
                CqlValueSet mn_ = this.Viloxazine(context);
                bool? mo_ = context.Operators.ConceptInValueSet(mm_, mn_);
                bool? mp_ = context.Operators.And(mk_, mo_);
                return mp_;
            }

            bool? md_ = context.Operators.WhereAny<Medication>(mb_, mc_);
            return md_;
        }

        IEnumerable<MedicationRequest> ds_ = context.Operators.Where<MedicationRequest>(a_, dr_);
        CqlValueSet dt_ = this.Viloxazine(context);
        IEnumerable<MedicationRequest> du_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dv_ = context.Operators.Union<MedicationRequest>(ds_, du_);
        IEnumerable<MedicationRequest> dw_ = Status_1_15_000.Instance.isMedicationOrder(context, dv_);

        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dx_(MedicationRequest ViloxazineMed) {
            CqlInterval<CqlDate> mt_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ViloxazineMed);
            CqlDate mu_ = context.Operators.Start(mt_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? mv_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, mt_, mu_);
            return mv_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dy_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dw_, dx_);

        object dz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlDate mw_ = @this?.periodStart;
            return mw_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ea_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dy_, dz_, System.ComponentModel.ListSortDirection.Ascending);

        bool? eb_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> mx_ = @this?.period;
            bool? my_ = context.Operators.Not((bool?)(mx_ is null));
            return my_;
        }


        CqlInterval<CqlDate> ec_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this) {
            CqlInterval<CqlDate> mz_ = @this?.period;
            return mz_;
        }

        IEnumerable<CqlInterval<CqlDate>> ed_ = context.Operators.WhereSelect<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ea_, eb_, ec_);
        IEnumerable<CqlInterval<CqlDate>> ee_ = CumulativeMedicationDuration_6_0_000.Instance.rolloutIntervals(context, ed_);
        IEnumerable<CqlInterval<CqlDate>> ef_ = context.Operators.Union<CqlInterval<CqlDate>>(dq_, ee_);

        CqlInterval<CqlDate> eg_(CqlInterval<CqlDate> ADHDMedication) {
            CqlDate na_ = this.IPSD(context);
            CqlQuantity nb_ = context.Operators.Quantity(300m, "days");
            CqlDate nc_ = context.Operators.Add(na_, nb_);
            CqlInterval<CqlDate> nd_ = context.Operators.Interval(na_, nc_, true, true);
            CqlInterval<CqlDate> ne_ = context.Operators.Intersect<CqlDate>(ADHDMedication, nd_);
            return ne_;
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
