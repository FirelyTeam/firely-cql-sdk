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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR", "0.1.001")]
public partial class FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001 : ILibrary, ISingleton<FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001>
{
    private FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001() {}

    public static FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Status_1_8_000.Instance];

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

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("24 HR dexmethylphenidate hydrochloride 40 MG Extended Release Oral Capsule", codeId: "1006608", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule(CqlContext _) => __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule;
    private static readonly CqlCode __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule = new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("methamphetamine hydrochloride 5 MG Oral Tablet", codeId: "977860", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet(CqlContext _) => _methamphetamine_hydrochloride_5_MG_Oral_Tablet;
    private static readonly CqlCode _methamphetamine_hydrochloride_5_MG_Oral_Tablet = new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("RXNORM", codeSystemId: "http://www.nlm.nih.gov/research/umls/rxnorm", codeSystemVersion: null)]
    public CqlCodeSystem RXNORM(CqlContext _) => _RXNORM;
    private static readonly CqlCodeSystem _RXNORM =
      new CqlCodeSystem("http://www.nlm.nih.gov/research/umls/rxnorm", null, [
          __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule,
          _methamphetamine_hydrochloride_5_MG_Oral_Tablet]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR-0.1.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Expressions

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
            IEnumerable<Medication> dv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? dw_(Medication M)
            {
                object ea_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object eb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ec_ = context.Operators.Split((string)eb_, "/");
                string ed_ = context.Operators.Last<string>(ec_);
                bool? ee_ = context.Operators.Equal(ea_, ed_);
                CodeableConcept ef_ = M?.Code;
                CqlConcept eg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ef_);
                CqlValueSet eh_ = this.Atomoxetine(context);
                bool? ei_ = context.Operators.ConceptInValueSet(eg_, eh_);
                bool? ej_ = context.Operators.And(ee_, ei_);

                return ej_;
            };
            IEnumerable<Medication> dx_ = context.Operators.Where<Medication>(dv_, dw_);
            MedicationRequest dy_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> dz_ = context.Operators.Select<Medication, MedicationRequest>(dx_, dy_);

            return dz_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_(MedicationRequest MR)
        {
            IEnumerable<Medication> ek_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? el_(Medication M)
            {
                object ep_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object eq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> er_ = context.Operators.Split((string)eq_, "/");
                string es_ = context.Operators.Last<string>(er_);
                bool? et_ = context.Operators.Equal(ep_, es_);
                CodeableConcept eu_ = M?.Code;
                CqlConcept ev_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eu_);
                CqlValueSet ew_ = this.Clonidine(context);
                bool? ex_ = context.Operators.ConceptInValueSet(ev_, ew_);
                bool? ey_ = context.Operators.And(et_, ex_);

                return ey_;
            };
            IEnumerable<Medication> em_ = context.Operators.Where<Medication>(ek_, el_);
            MedicationRequest en_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> eo_ = context.Operators.Select<Medication, MedicationRequest>(em_, en_);

            return eo_;
        };
        IEnumerable<MedicationRequest> k_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        CqlValueSet n_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_(MedicationRequest MR)
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
                CqlValueSet fl_ = this.Dexmethylphenidate(context);
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
        IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, q_);
        IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(o_, r_);
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(m_, s_);
        CqlValueSet u_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> x_(MedicationRequest MR)
        {
            IEnumerable<Medication> fo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? fp_(Medication M)
            {
                object ft_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fv_ = context.Operators.Split((string)fu_, "/");
                string fw_ = context.Operators.Last<string>(fv_);
                bool? fx_ = context.Operators.Equal(ft_, fw_);
                CodeableConcept fy_ = M?.Code;
                CqlConcept fz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fy_);
                CqlValueSet ga_ = this.Dextroamphetamine(context);
                bool? gb_ = context.Operators.ConceptInValueSet(fz_, ga_);
                bool? gc_ = context.Operators.And(fx_, gb_);

                return gc_;
            };
            IEnumerable<Medication> fq_ = context.Operators.Where<Medication>(fo_, fp_);
            MedicationRequest fr_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> fs_ = context.Operators.Select<Medication, MedicationRequest>(fq_, fr_);

            return fs_;
        };
        IEnumerable<MedicationRequest> y_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, x_);
        IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(v_, y_);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(t_, z_);
        CqlValueSet ab_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> ac_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ae_(MedicationRequest MR)
        {
            IEnumerable<Medication> gd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ge_(Medication M)
            {
                object gi_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gk_ = context.Operators.Split((string)gj_, "/");
                string gl_ = context.Operators.Last<string>(gk_);
                bool? gm_ = context.Operators.Equal(gi_, gl_);
                CodeableConcept gn_ = M?.Code;
                CqlConcept go_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gn_);
                CqlValueSet gp_ = this.Lisdexamfetamine(context);
                bool? gq_ = context.Operators.ConceptInValueSet(go_, gp_);
                bool? gr_ = context.Operators.And(gm_, gq_);

                return gr_;
            };
            IEnumerable<Medication> gf_ = context.Operators.Where<Medication>(gd_, ge_);
            MedicationRequest gg_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> gh_ = context.Operators.Select<Medication, MedicationRequest>(gf_, gg_);

            return gh_;
        };
        IEnumerable<MedicationRequest> af_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ae_);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ac_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(aa_, ag_);
        CqlCode ai_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> aj_ = context.Operators.ToList<CqlCode>(ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, aj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> am_(MedicationRequest MR)
        {
            IEnumerable<Medication> gs_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? gt_(Medication M)
            {
                object gx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gy_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gz_ = context.Operators.Split((string)gy_, "/");
                string ha_ = context.Operators.Last<string>(gz_);
                bool? hb_ = context.Operators.Equal(gx_, ha_);
                CodeableConcept hc_ = M?.Code;
                CqlConcept hd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hc_);
                CqlCode he_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept hf_ = context.Operators.ConvertCodeToConcept(he_);
                bool? hg_ = context.Operators.Equivalent(hd_, hf_);
                bool? hh_ = context.Operators.And(hb_, hg_);

                return hh_;
            };
            IEnumerable<Medication> gu_ = context.Operators.Where<Medication>(gs_, gt_);
            MedicationRequest gv_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> gw_ = context.Operators.Select<Medication, MedicationRequest>(gu_, gv_);

            return gw_;
        };
        IEnumerable<MedicationRequest> an_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, am_);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Union<MedicationRequest>(ak_, an_);
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(ah_, ao_);
        CqlValueSet aq_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> ar_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> at_(MedicationRequest MR)
        {
            IEnumerable<Medication> hi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? hj_(Medication M)
            {
                object hn_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ho_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hp_ = context.Operators.Split((string)ho_, "/");
                string hq_ = context.Operators.Last<string>(hp_);
                bool? hr_ = context.Operators.Equal(hn_, hq_);
                CodeableConcept hs_ = M?.Code;
                CqlConcept ht_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hs_);
                CqlValueSet hu_ = this.Methylphenidate(context);
                bool? hv_ = context.Operators.ConceptInValueSet(ht_, hu_);
                bool? hw_ = context.Operators.And(hr_, hv_);

                return hw_;
            };
            IEnumerable<Medication> hk_ = context.Operators.Where<Medication>(hi_, hj_);
            MedicationRequest hl_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> hm_ = context.Operators.Select<Medication, MedicationRequest>(hk_, hl_);

            return hm_;
        };
        IEnumerable<MedicationRequest> au_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, at_);
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(ar_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(ap_, av_);
        CqlValueSet ax_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ba_(MedicationRequest MR)
        {
            IEnumerable<Medication> hx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? hy_(Medication M)
            {
                object ic_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object id_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ie_ = context.Operators.Split((string)id_, "/");
                string if_ = context.Operators.Last<string>(ie_);
                bool? ig_ = context.Operators.Equal(ic_, if_);
                CodeableConcept ih_ = M?.Code;
                CqlConcept ii_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ih_);
                CqlValueSet ij_ = this.Guanfacine_Medications(context);
                bool? ik_ = context.Operators.ConceptInValueSet(ii_, ij_);
                bool? il_ = context.Operators.And(ig_, ik_);

                return il_;
            };
            IEnumerable<Medication> hz_ = context.Operators.Where<Medication>(hx_, hy_);
            MedicationRequest ia_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ib_ = context.Operators.Select<Medication, MedicationRequest>(hz_, ia_);

            return ib_;
        };
        IEnumerable<MedicationRequest> bb_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ay_, bb_);
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(aw_, bc_);
        IEnumerable<MedicationRequest> be_ = Status_1_8_000.Instance.isMedicationOrder(context, bd_);
        bool? bf_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> im_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate in_ = context.Operators.Start(im_);
            CqlDateTime io_ = context.Operators.ConvertDateToDateTime(in_);
            CqlInterval<CqlDateTime> ip_ = this.Intake_Period(context);
            bool? iq_ = context.Operators.In<CqlDateTime>(io_, ip_, default);

            return iq_;
        };
        IEnumerable<MedicationRequest> bg_ = context.Operators.Where<MedicationRequest>(be_, bf_);
        IEnumerable<MedicationRequest> bi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bk_(MedicationRequest MR)
        {
            IEnumerable<Medication> ir_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? is_(Medication M)
            {
                object iw_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ix_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> iy_ = context.Operators.Split((string)ix_, "/");
                string iz_ = context.Operators.Last<string>(iy_);
                bool? ja_ = context.Operators.Equal(iw_, iz_);
                CodeableConcept jb_ = M?.Code;
                CqlConcept jc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jb_);
                CqlValueSet jd_ = this.Atomoxetine(context);
                bool? je_ = context.Operators.ConceptInValueSet(jc_, jd_);
                bool? jf_ = context.Operators.And(ja_, je_);

                return jf_;
            };
            IEnumerable<Medication> it_ = context.Operators.Where<Medication>(ir_, is_);
            MedicationRequest iu_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> iv_ = context.Operators.Select<Medication, MedicationRequest>(it_, iu_);

            return iv_;
        };
        IEnumerable<MedicationRequest> bl_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bk_);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Union<MedicationRequest>(bi_, bl_);
        IEnumerable<MedicationRequest> bo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bq_(MedicationRequest MR)
        {
            IEnumerable<Medication> jg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? jh_(Medication M)
            {
                object jl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object jm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jn_ = context.Operators.Split((string)jm_, "/");
                string jo_ = context.Operators.Last<string>(jn_);
                bool? jp_ = context.Operators.Equal(jl_, jo_);
                CodeableConcept jq_ = M?.Code;
                CqlConcept jr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jq_);
                CqlValueSet js_ = this.Clonidine(context);
                bool? jt_ = context.Operators.ConceptInValueSet(jr_, js_);
                bool? ju_ = context.Operators.And(jp_, jt_);

                return ju_;
            };
            IEnumerable<Medication> ji_ = context.Operators.Where<Medication>(jg_, jh_);
            MedicationRequest jj_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> jk_ = context.Operators.Select<Medication, MedicationRequest>(ji_, jj_);

            return jk_;
        };
        IEnumerable<MedicationRequest> br_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bq_);
        IEnumerable<MedicationRequest> bs_ = context.Operators.Union<MedicationRequest>(bo_, br_);
        IEnumerable<MedicationRequest> bt_ = context.Operators.Union<MedicationRequest>(bm_, bs_);
        IEnumerable<MedicationRequest> bv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bx_(MedicationRequest MR)
        {
            IEnumerable<Medication> jv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? jw_(Medication M)
            {
                object ka_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kc_ = context.Operators.Split((string)kb_, "/");
                string kd_ = context.Operators.Last<string>(kc_);
                bool? ke_ = context.Operators.Equal(ka_, kd_);
                CodeableConcept kf_ = M?.Code;
                CqlConcept kg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kf_);
                CqlValueSet kh_ = this.Dexmethylphenidate(context);
                bool? ki_ = context.Operators.ConceptInValueSet(kg_, kh_);
                bool? kj_ = context.Operators.And(ke_, ki_);

                return kj_;
            };
            IEnumerable<Medication> jx_ = context.Operators.Where<Medication>(jv_, jw_);
            MedicationRequest jy_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> jz_ = context.Operators.Select<Medication, MedicationRequest>(jx_, jy_);

            return jz_;
        };
        IEnumerable<MedicationRequest> by_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bx_);
        IEnumerable<MedicationRequest> bz_ = context.Operators.Union<MedicationRequest>(bv_, by_);
        IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bt_, bz_);
        IEnumerable<MedicationRequest> cc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ce_(MedicationRequest MR)
        {
            IEnumerable<Medication> kk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? kl_(Medication M)
            {
                object kp_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kr_ = context.Operators.Split((string)kq_, "/");
                string ks_ = context.Operators.Last<string>(kr_);
                bool? kt_ = context.Operators.Equal(kp_, ks_);
                CodeableConcept ku_ = M?.Code;
                CqlConcept kv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ku_);
                CqlValueSet kw_ = this.Dextroamphetamine(context);
                bool? kx_ = context.Operators.ConceptInValueSet(kv_, kw_);
                bool? ky_ = context.Operators.And(kt_, kx_);

                return ky_;
            };
            IEnumerable<Medication> km_ = context.Operators.Where<Medication>(kk_, kl_);
            MedicationRequest kn_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ko_ = context.Operators.Select<Medication, MedicationRequest>(km_, kn_);

            return ko_;
        };
        IEnumerable<MedicationRequest> cf_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ce_);
        IEnumerable<MedicationRequest> cg_ = context.Operators.Union<MedicationRequest>(cc_, cf_);
        IEnumerable<MedicationRequest> ch_ = context.Operators.Union<MedicationRequest>(ca_, cg_);
        IEnumerable<MedicationRequest> cj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cl_(MedicationRequest MR)
        {
            IEnumerable<Medication> kz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? la_(Medication M)
            {
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
            };
            IEnumerable<Medication> lb_ = context.Operators.Where<Medication>(kz_, la_);
            MedicationRequest lc_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ld_ = context.Operators.Select<Medication, MedicationRequest>(lb_, lc_);

            return ld_;
        };
        IEnumerable<MedicationRequest> cm_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, cl_);
        IEnumerable<MedicationRequest> cn_ = context.Operators.Union<MedicationRequest>(cj_, cm_);
        IEnumerable<MedicationRequest> co_ = context.Operators.Union<MedicationRequest>(ch_, cn_);
        IEnumerable<CqlCode> cq_ = context.Operators.ToList<CqlCode>(ai_);
        IEnumerable<MedicationRequest> cr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, cq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ct_(MedicationRequest MR)
        {
            IEnumerable<Medication> lo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? lp_(Medication M)
            {
                object lt_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> lv_ = context.Operators.Split((string)lu_, "/");
                string lw_ = context.Operators.Last<string>(lv_);
                bool? lx_ = context.Operators.Equal(lt_, lw_);
                CodeableConcept ly_ = M?.Code;
                CqlConcept lz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ly_);
                CqlCode ma_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept mb_ = context.Operators.ConvertCodeToConcept(ma_);
                bool? mc_ = context.Operators.Equivalent(lz_, mb_);
                bool? md_ = context.Operators.And(lx_, mc_);

                return md_;
            };
            IEnumerable<Medication> lq_ = context.Operators.Where<Medication>(lo_, lp_);
            MedicationRequest lr_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ls_ = context.Operators.Select<Medication, MedicationRequest>(lq_, lr_);

            return ls_;
        };
        IEnumerable<MedicationRequest> cu_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ct_);
        IEnumerable<MedicationRequest> cv_ = context.Operators.Union<MedicationRequest>(cr_, cu_);
        IEnumerable<MedicationRequest> cw_ = context.Operators.Union<MedicationRequest>(co_, cv_);
        IEnumerable<MedicationRequest> cy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> da_(MedicationRequest MR)
        {
            IEnumerable<Medication> me_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? mf_(Medication M)
            {
                object mj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ml_ = context.Operators.Split((string)mk_, "/");
                string mm_ = context.Operators.Last<string>(ml_);
                bool? mn_ = context.Operators.Equal(mj_, mm_);
                CodeableConcept mo_ = M?.Code;
                CqlConcept mp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mo_);
                CqlValueSet mq_ = this.Methylphenidate(context);
                bool? mr_ = context.Operators.ConceptInValueSet(mp_, mq_);
                bool? ms_ = context.Operators.And(mn_, mr_);

                return ms_;
            };
            IEnumerable<Medication> mg_ = context.Operators.Where<Medication>(me_, mf_);
            MedicationRequest mh_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> mi_ = context.Operators.Select<Medication, MedicationRequest>(mg_, mh_);

            return mi_;
        };
        IEnumerable<MedicationRequest> db_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, da_);
        IEnumerable<MedicationRequest> dc_ = context.Operators.Union<MedicationRequest>(cy_, db_);
        IEnumerable<MedicationRequest> dd_ = context.Operators.Union<MedicationRequest>(cw_, dc_);
        IEnumerable<MedicationRequest> df_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dh_(MedicationRequest MR)
        {
            IEnumerable<Medication> mt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? mu_(Medication M)
            {
                object my_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> na_ = context.Operators.Split((string)mz_, "/");
                string nb_ = context.Operators.Last<string>(na_);
                bool? nc_ = context.Operators.Equal(my_, nb_);
                CodeableConcept nd_ = M?.Code;
                CqlConcept ne_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nd_);
                CqlValueSet nf_ = this.Guanfacine_Medications(context);
                bool? ng_ = context.Operators.ConceptInValueSet(ne_, nf_);
                bool? nh_ = context.Operators.And(nc_, ng_);

                return nh_;
            };
            IEnumerable<Medication> mv_ = context.Operators.Where<Medication>(mt_, mu_);
            MedicationRequest mw_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> mx_ = context.Operators.Select<Medication, MedicationRequest>(mv_, mw_);

            return mx_;
        };
        IEnumerable<MedicationRequest> di_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, dh_);
        IEnumerable<MedicationRequest> dj_ = context.Operators.Union<MedicationRequest>(df_, di_);
        IEnumerable<MedicationRequest> dk_ = context.Operators.Union<MedicationRequest>(dd_, dj_);
        IEnumerable<MedicationRequest> dl_ = Status_1_8_000.Instance.isMedicationOrder(context, dk_);
        bool? dm_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> ni_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate nj_ = context.Operators.Start(ni_);
            CqlDateTime nk_ = context.Operators.ConvertDateToDateTime(nj_);
            CqlInterval<CqlDateTime> nl_ = this.Intake_Period(context);
            bool? nm_ = context.Operators.In<CqlDateTime>(nk_, nl_, default);

            return nm_;
        };
        IEnumerable<MedicationRequest> dn_ = context.Operators.Where<MedicationRequest>(dl_, dm_);
        IEnumerable<MedicationRequest> do_(MedicationRequest ADHDMedicationOrder)
        {
            CqlValueSet nn_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> no_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> np_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> nq_(MedicationRequest MR)
            {
                IEnumerable<Medication> pw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? px_(Medication M)
                {
                    object qb_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object qc_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> qd_ = context.Operators.Split((string)qc_, "/");
                    string qe_ = context.Operators.Last<string>(qd_);
                    bool? qf_ = context.Operators.Equal(qb_, qe_);
                    CodeableConcept qg_ = M?.Code;
                    CqlConcept qh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qg_);
                    CqlValueSet qi_ = this.Atomoxetine(context);
                    bool? qj_ = context.Operators.ConceptInValueSet(qh_, qi_);
                    bool? qk_ = context.Operators.And(qf_, qj_);

                    return qk_;
                };
                IEnumerable<Medication> py_ = context.Operators.Where<Medication>(pw_, px_);
                MedicationRequest pz_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> qa_ = context.Operators.Select<Medication, MedicationRequest>(py_, pz_);

                return qa_;
            };
            IEnumerable<MedicationRequest> nr_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(np_, nq_);
            IEnumerable<MedicationRequest> ns_ = context.Operators.Union<MedicationRequest>(no_, nr_);
            CqlValueSet nt_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> nu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> nw_(MedicationRequest MR)
            {
                IEnumerable<Medication> ql_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? qm_(Medication M)
                {
                    object qq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object qr_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> qs_ = context.Operators.Split((string)qr_, "/");
                    string qt_ = context.Operators.Last<string>(qs_);
                    bool? qu_ = context.Operators.Equal(qq_, qt_);
                    CodeableConcept qv_ = M?.Code;
                    CqlConcept qw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qv_);
                    CqlValueSet qx_ = this.Clonidine(context);
                    bool? qy_ = context.Operators.ConceptInValueSet(qw_, qx_);
                    bool? qz_ = context.Operators.And(qu_, qy_);

                    return qz_;
                };
                IEnumerable<Medication> qn_ = context.Operators.Where<Medication>(ql_, qm_);
                MedicationRequest qo_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> qp_ = context.Operators.Select<Medication, MedicationRequest>(qn_, qo_);

                return qp_;
            };
            IEnumerable<MedicationRequest> nx_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(np_, nw_);
            IEnumerable<MedicationRequest> ny_ = context.Operators.Union<MedicationRequest>(nu_, nx_);
            IEnumerable<MedicationRequest> nz_ = context.Operators.Union<MedicationRequest>(ns_, ny_);
            CqlValueSet oa_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> ob_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, oa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> od_(MedicationRequest MR)
            {
                IEnumerable<Medication> ra_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? rb_(Medication M)
                {
                    object rf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object rg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> rh_ = context.Operators.Split((string)rg_, "/");
                    string ri_ = context.Operators.Last<string>(rh_);
                    bool? rj_ = context.Operators.Equal(rf_, ri_);
                    CodeableConcept rk_ = M?.Code;
                    CqlConcept rl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rk_);
                    CqlValueSet rm_ = this.Dexmethylphenidate(context);
                    bool? rn_ = context.Operators.ConceptInValueSet(rl_, rm_);
                    bool? ro_ = context.Operators.And(rj_, rn_);

                    return ro_;
                };
                IEnumerable<Medication> rc_ = context.Operators.Where<Medication>(ra_, rb_);
                MedicationRequest rd_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> re_ = context.Operators.Select<Medication, MedicationRequest>(rc_, rd_);

                return re_;
            };
            IEnumerable<MedicationRequest> oe_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(np_, od_);
            IEnumerable<MedicationRequest> of_ = context.Operators.Union<MedicationRequest>(ob_, oe_);
            IEnumerable<MedicationRequest> og_ = context.Operators.Union<MedicationRequest>(nz_, of_);
            CqlValueSet oh_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> oi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, oh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ok_(MedicationRequest MR)
            {
                IEnumerable<Medication> rp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? rq_(Medication M)
                {
                    object ru_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object rv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> rw_ = context.Operators.Split((string)rv_, "/");
                    string rx_ = context.Operators.Last<string>(rw_);
                    bool? ry_ = context.Operators.Equal(ru_, rx_);
                    CodeableConcept rz_ = M?.Code;
                    CqlConcept sa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rz_);
                    CqlValueSet sb_ = this.Dextroamphetamine(context);
                    bool? sc_ = context.Operators.ConceptInValueSet(sa_, sb_);
                    bool? sd_ = context.Operators.And(ry_, sc_);

                    return sd_;
                };
                IEnumerable<Medication> rr_ = context.Operators.Where<Medication>(rp_, rq_);
                MedicationRequest rs_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> rt_ = context.Operators.Select<Medication, MedicationRequest>(rr_, rs_);

                return rt_;
            };
            IEnumerable<MedicationRequest> ol_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(np_, ok_);
            IEnumerable<MedicationRequest> om_ = context.Operators.Union<MedicationRequest>(oi_, ol_);
            IEnumerable<MedicationRequest> on_ = context.Operators.Union<MedicationRequest>(og_, om_);
            CqlValueSet oo_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> op_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, oo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> or_(MedicationRequest MR)
            {
                IEnumerable<Medication> se_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? sf_(Medication M)
                {
                    object sj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object sk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> sl_ = context.Operators.Split((string)sk_, "/");
                    string sm_ = context.Operators.Last<string>(sl_);
                    bool? sn_ = context.Operators.Equal(sj_, sm_);
                    CodeableConcept so_ = M?.Code;
                    CqlConcept sp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, so_);
                    CqlValueSet sq_ = this.Lisdexamfetamine(context);
                    bool? sr_ = context.Operators.ConceptInValueSet(sp_, sq_);
                    bool? ss_ = context.Operators.And(sn_, sr_);

                    return ss_;
                };
                IEnumerable<Medication> sg_ = context.Operators.Where<Medication>(se_, sf_);
                MedicationRequest sh_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> si_ = context.Operators.Select<Medication, MedicationRequest>(sg_, sh_);

                return si_;
            };
            IEnumerable<MedicationRequest> os_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(np_, or_);
            IEnumerable<MedicationRequest> ot_ = context.Operators.Union<MedicationRequest>(op_, os_);
            IEnumerable<MedicationRequest> ou_ = context.Operators.Union<MedicationRequest>(on_, ot_);
            CqlCode ov_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> ow_ = context.Operators.ToList<CqlCode>(ov_);
            IEnumerable<MedicationRequest> ox_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ow_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> oz_(MedicationRequest MR)
            {
                IEnumerable<Medication> st_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? su_(Medication M)
                {
                    object sy_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object sz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> ta_ = context.Operators.Split((string)sz_, "/");
                    string tb_ = context.Operators.Last<string>(ta_);
                    bool? tc_ = context.Operators.Equal(sy_, tb_);
                    CodeableConcept td_ = M?.Code;
                    CqlConcept te_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, td_);
                    CqlCode tf_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                    CqlConcept tg_ = context.Operators.ConvertCodeToConcept(tf_);
                    bool? th_ = context.Operators.Equivalent(te_, tg_);
                    bool? ti_ = context.Operators.And(tc_, th_);

                    return ti_;
                };
                IEnumerable<Medication> sv_ = context.Operators.Where<Medication>(st_, su_);
                MedicationRequest sw_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> sx_ = context.Operators.Select<Medication, MedicationRequest>(sv_, sw_);

                return sx_;
            };
            IEnumerable<MedicationRequest> pa_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(np_, oz_);
            IEnumerable<MedicationRequest> pb_ = context.Operators.Union<MedicationRequest>(ox_, pa_);
            IEnumerable<MedicationRequest> pc_ = context.Operators.Union<MedicationRequest>(ou_, pb_);
            CqlValueSet pd_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> pe_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> pg_(MedicationRequest MR)
            {
                IEnumerable<Medication> tj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? tk_(Medication M)
                {
                    object to_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object tp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> tq_ = context.Operators.Split((string)tp_, "/");
                    string tr_ = context.Operators.Last<string>(tq_);
                    bool? ts_ = context.Operators.Equal(to_, tr_);
                    CodeableConcept tt_ = M?.Code;
                    CqlConcept tu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tt_);
                    CqlValueSet tv_ = this.Methylphenidate(context);
                    bool? tw_ = context.Operators.ConceptInValueSet(tu_, tv_);
                    bool? tx_ = context.Operators.And(ts_, tw_);

                    return tx_;
                };
                IEnumerable<Medication> tl_ = context.Operators.Where<Medication>(tj_, tk_);
                MedicationRequest tm_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> tn_ = context.Operators.Select<Medication, MedicationRequest>(tl_, tm_);

                return tn_;
            };
            IEnumerable<MedicationRequest> ph_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(np_, pg_);
            IEnumerable<MedicationRequest> pi_ = context.Operators.Union<MedicationRequest>(pe_, ph_);
            IEnumerable<MedicationRequest> pj_ = context.Operators.Union<MedicationRequest>(pc_, pi_);
            CqlValueSet pk_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> pl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> pn_(MedicationRequest MR)
            {
                IEnumerable<Medication> ty_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? tz_(Medication M)
                {
                    object ud_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object ue_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> uf_ = context.Operators.Split((string)ue_, "/");
                    string ug_ = context.Operators.Last<string>(uf_);
                    bool? uh_ = context.Operators.Equal(ud_, ug_);
                    CodeableConcept ui_ = M?.Code;
                    CqlConcept uj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ui_);
                    CqlValueSet uk_ = this.Guanfacine_Medications(context);
                    bool? ul_ = context.Operators.ConceptInValueSet(uj_, uk_);
                    bool? um_ = context.Operators.And(uh_, ul_);

                    return um_;
                };
                IEnumerable<Medication> ua_ = context.Operators.Where<Medication>(ty_, tz_);
                MedicationRequest ub_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> uc_ = context.Operators.Select<Medication, MedicationRequest>(ua_, ub_);

                return uc_;
            };
            IEnumerable<MedicationRequest> po_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(np_, pn_);
            IEnumerable<MedicationRequest> pp_ = context.Operators.Union<MedicationRequest>(pl_, po_);
            IEnumerable<MedicationRequest> pq_ = context.Operators.Union<MedicationRequest>(pj_, pp_);
            IEnumerable<MedicationRequest> pr_ = Status_1_8_000.Instance.isMedicationActive(context, pq_);
            bool? ps_(MedicationRequest ActiveADHDMedication)
            {
                CqlInterval<CqlDate> un_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> uo_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate up_ = context.Operators.Start(uo_);
                CqlDateTime uq_ = context.Operators.ConvertDateToDateTime(up_);
                CqlDate ur_ = context.Operators.DateFrom(uq_);
                CqlQuantity us_ = context.Operators.Quantity(120m, "days");
                CqlDate ut_ = context.Operators.Subtract(ur_, us_);
                CqlDate uv_ = context.Operators.Start(uo_);
                CqlDateTime uw_ = context.Operators.ConvertDateToDateTime(uv_);
                CqlDate ux_ = context.Operators.DateFrom(uw_);
                CqlInterval<CqlDate> uy_ = context.Operators.Interval(ut_, ux_, true, false);
                bool? uz_ = context.Operators.Overlaps(un_, uy_, default);

                return uz_;
            };
            IEnumerable<MedicationRequest> pt_ = context.Operators.Where<MedicationRequest>(pr_, ps_);
            MedicationRequest pu_(MedicationRequest ActiveADHDMedication) =>
                ADHDMedicationOrder;
            IEnumerable<MedicationRequest> pv_ = context.Operators.Select<MedicationRequest, MedicationRequest>(pt_, pu_);

            return pv_;
        };
        IEnumerable<MedicationRequest> dp_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(dn_, do_);
        IEnumerable<MedicationRequest> dq_ = context.Operators.Except<MedicationRequest>(bg_, dp_);
        (CqlTupleMetadata, CqlDate startDate)? dr_(MedicationRequest QualifyingMed)
        {
            CqlInterval<CqlDate> va_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate vb_ = context.Operators.Start(va_);
            (CqlTupleMetadata, CqlDate startDate)? vc_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, vb_);

            return vc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ds_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(dq_, dr_);
        object dt_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate vd_ = @this?.startDate;

            return vd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> du_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(ds_, dt_, System.ComponentModel.ListSortDirection.Ascending);

        return du_;
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


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis")]
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


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
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


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> b_ = this.Narcolepsy_Exclusion(context);
        bool? c_ = context.Operators.Exists<Condition>(b_);
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


    [CqlExpressionDefinition("Encounter During Initiation Phase")]
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
            IEnumerable<Medication> ei_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ej_(Medication M)
            {
                object en_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object eo_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ep_ = context.Operators.Split((string)eo_, "/");
                string eq_ = context.Operators.Last<string>(ep_);
                bool? er_ = context.Operators.Equal(en_, eq_);
                CodeableConcept es_ = M?.Code;
                CqlConcept et_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, es_);
                CqlValueSet eu_ = this.Atomoxetine(context);
                bool? ev_ = context.Operators.ConceptInValueSet(et_, eu_);
                bool? ew_ = context.Operators.And(er_, ev_);

                return ew_;
            };
            IEnumerable<Medication> ek_ = context.Operators.Where<Medication>(ei_, ej_);
            MedicationRequest el_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> em_ = context.Operators.Select<Medication, MedicationRequest>(ek_, el_);

            return em_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_8_000.Instance.isMedicationOrder(context, f_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? h_(MedicationRequest AtomoxetineMed)
        {
            CqlInterval<CqlDate> ex_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate ez_ = context.Operators.Start(ex_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fa_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ex_, ez_);

            return fa_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(g_, h_);
        object j_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate fb_ = @this?.periodStart;

            return fb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
        bool? l_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fc_ = @this?.period;
            bool? fd_ = context.Operators.Not((bool?)(fc_ is null));

            return fd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> m_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(k_, l_);
        CqlInterval<CqlDate> n_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fe_ = @this?.period;

            return fe_;
        };
        IEnumerable<CqlInterval<CqlDate>> o_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(m_, n_);
        IEnumerable<CqlInterval<CqlDate>> p_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, o_);
        CqlValueSet q_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> r_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> t_(MedicationRequest MR)
        {
            IEnumerable<Medication> ff_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? fg_(Medication M)
            {
                object fk_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fl_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fm_ = context.Operators.Split((string)fl_, "/");
                string fn_ = context.Operators.Last<string>(fm_);
                bool? fo_ = context.Operators.Equal(fk_, fn_);
                CodeableConcept fp_ = M?.Code;
                CqlConcept fq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fp_);
                CqlValueSet fr_ = this.Clonidine(context);
                bool? fs_ = context.Operators.ConceptInValueSet(fq_, fr_);
                bool? ft_ = context.Operators.And(fo_, fs_);

                return ft_;
            };
            IEnumerable<Medication> fh_ = context.Operators.Where<Medication>(ff_, fg_);
            MedicationRequest fi_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> fj_ = context.Operators.Select<Medication, MedicationRequest>(fh_, fi_);

            return fj_;
        };
        IEnumerable<MedicationRequest> u_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, t_);
        IEnumerable<MedicationRequest> v_ = context.Operators.Union<MedicationRequest>(r_, u_);
        IEnumerable<MedicationRequest> w_ = Status_1_8_000.Instance.isMedicationOrder(context, v_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? x_(MedicationRequest ClonidineMed)
        {
            CqlInterval<CqlDate> fu_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate fw_ = context.Operators.Start(fu_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fx_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, fu_, fw_);

            return fx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> y_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(w_, x_);
        object z_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate fy_ = @this?.periodStart;

            return fy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> aa_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(y_, z_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ab_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> fz_ = @this?.period;
            bool? ga_ = context.Operators.Not((bool?)(fz_ is null));

            return ga_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ac_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(aa_, ab_);
        CqlInterval<CqlDate> ad_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> gb_ = @this?.period;

            return gb_;
        };
        IEnumerable<CqlInterval<CqlDate>> ae_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ac_, ad_);
        IEnumerable<CqlInterval<CqlDate>> af_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, ae_);
        IEnumerable<CqlInterval<CqlDate>> ag_ = context.Operators.Union<CqlInterval<CqlDate>>(p_, af_);
        CqlValueSet ah_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ak_(MedicationRequest MR)
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
                CqlValueSet go_ = this.Dexmethylphenidate(context);
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
        IEnumerable<MedicationRequest> al_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ak_);
        IEnumerable<MedicationRequest> am_ = context.Operators.Union<MedicationRequest>(ai_, al_);
        IEnumerable<MedicationRequest> an_ = Status_1_8_000.Instance.isMedicationOrder(context, am_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ao_(MedicationRequest DexmethylphenidateMed)
        {
            CqlInterval<CqlDate> gr_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate gt_ = context.Operators.Start(gr_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gu_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, gr_, gt_);

            return gu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ap_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(an_, ao_);
        object aq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate gv_ = @this?.periodStart;

            return gv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ar_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
        bool? as_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> gw_ = @this?.period;
            bool? gx_ = context.Operators.Not((bool?)(gw_ is null));

            return gx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> at_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ar_, as_);
        CqlInterval<CqlDate> au_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> gy_ = @this?.period;

            return gy_;
        };
        IEnumerable<CqlInterval<CqlDate>> av_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(at_, au_);
        IEnumerable<CqlInterval<CqlDate>> aw_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, av_);
        CqlValueSet ax_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ba_(MedicationRequest MR)
        {
            IEnumerable<Medication> gz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ha_(Medication M)
            {
                object he_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hg_ = context.Operators.Split((string)hf_, "/");
                string hh_ = context.Operators.Last<string>(hg_);
                bool? hi_ = context.Operators.Equal(he_, hh_);
                CodeableConcept hj_ = M?.Code;
                CqlConcept hk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hj_);
                CqlValueSet hl_ = this.Dextroamphetamine(context);
                bool? hm_ = context.Operators.ConceptInValueSet(hk_, hl_);
                bool? hn_ = context.Operators.And(hi_, hm_);

                return hn_;
            };
            IEnumerable<Medication> hb_ = context.Operators.Where<Medication>(gz_, ha_);
            MedicationRequest hc_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> hd_ = context.Operators.Select<Medication, MedicationRequest>(hb_, hc_);

            return hd_;
        };
        IEnumerable<MedicationRequest> bb_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ay_, bb_);
        IEnumerable<MedicationRequest> bd_ = Status_1_8_000.Instance.isMedicationOrder(context, bc_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? be_(MedicationRequest DextroamphetamineMed)
        {
            CqlInterval<CqlDate> ho_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate hq_ = context.Operators.Start(ho_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hr_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ho_, hq_);

            return hr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bf_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bd_, be_);
        object bg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate hs_ = @this?.periodStart;

            return hs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
        bool? bi_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> ht_ = @this?.period;
            bool? hu_ = context.Operators.Not((bool?)(ht_ is null));

            return hu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bj_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bh_, bi_);
        CqlInterval<CqlDate> bk_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> hv_ = @this?.period;

            return hv_;
        };
        IEnumerable<CqlInterval<CqlDate>> bl_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bj_, bk_);
        IEnumerable<CqlInterval<CqlDate>> bm_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, bl_);
        IEnumerable<CqlInterval<CqlDate>> bn_ = context.Operators.Union<CqlInterval<CqlDate>>(aw_, bm_);
        IEnumerable<CqlInterval<CqlDate>> bo_ = context.Operators.Union<CqlInterval<CqlDate>>(ag_, bn_);
        CqlValueSet bp_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> bq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bs_(MedicationRequest MR)
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
                CqlValueSet ii_ = this.Lisdexamfetamine(context);
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
        IEnumerable<MedicationRequest> bt_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bs_);
        IEnumerable<MedicationRequest> bu_ = context.Operators.Union<MedicationRequest>(bq_, bt_);
        IEnumerable<MedicationRequest> bv_ = Status_1_8_000.Instance.isMedicationOrder(context, bu_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? bw_(MedicationRequest LisdexamfetamineMed)
        {
            CqlInterval<CqlDate> il_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate in_ = context.Operators.Start(il_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? io_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, il_, in_);

            return io_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bx_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bv_, bw_);
        object by_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate ip_ = @this?.periodStart;

            return ip_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> bz_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bx_, by_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ca_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> iq_ = @this?.period;
            bool? ir_ = context.Operators.Not((bool?)(iq_ is null));

            return ir_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cb_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(bz_, ca_);
        CqlInterval<CqlDate> cc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> is_ = @this?.period;

            return is_;
        };
        IEnumerable<CqlInterval<CqlDate>> cd_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cb_, cc_);
        IEnumerable<CqlInterval<CqlDate>> ce_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, cd_);
        CqlValueSet cf_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> cg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ci_(MedicationRequest MR)
        {
            IEnumerable<Medication> it_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? iu_(Medication M)
            {
                object iy_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object iz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ja_ = context.Operators.Split((string)iz_, "/");
                string jb_ = context.Operators.Last<string>(ja_);
                bool? jc_ = context.Operators.Equal(iy_, jb_);
                CodeableConcept jd_ = M?.Code;
                CqlConcept je_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jd_);
                CqlValueSet jf_ = this.Methylphenidate(context);
                bool? jg_ = context.Operators.ConceptInValueSet(je_, jf_);
                bool? jh_ = context.Operators.And(jc_, jg_);

                return jh_;
            };
            IEnumerable<Medication> iv_ = context.Operators.Where<Medication>(it_, iu_);
            MedicationRequest iw_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ix_ = context.Operators.Select<Medication, MedicationRequest>(iv_, iw_);

            return ix_;
        };
        IEnumerable<MedicationRequest> cj_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ci_);
        IEnumerable<MedicationRequest> ck_ = context.Operators.Union<MedicationRequest>(cg_, cj_);
        IEnumerable<MedicationRequest> cl_ = Status_1_8_000.Instance.isMedicationOrder(context, ck_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? cm_(MedicationRequest MethylphenidateMed)
        {
            CqlInterval<CqlDate> ji_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate jk_ = context.Operators.Start(ji_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jl_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ji_, jk_);

            return jl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cn_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cl_, cm_);
        object co_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate jm_ = @this?.periodStart;

            return jm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cp_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cn_, co_, System.ComponentModel.ListSortDirection.Ascending);
        bool? cq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jn_ = @this?.period;
            bool? jo_ = context.Operators.Not((bool?)(jn_ is null));

            return jo_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> cr_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(cp_, cq_);
        CqlInterval<CqlDate> cs_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jp_ = @this?.period;

            return jp_;
        };
        IEnumerable<CqlInterval<CqlDate>> ct_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cr_, cs_);
        IEnumerable<CqlInterval<CqlDate>> cu_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, ct_);
        IEnumerable<CqlInterval<CqlDate>> cv_ = context.Operators.Union<CqlInterval<CqlDate>>(ce_, cu_);
        IEnumerable<CqlInterval<CqlDate>> cw_ = context.Operators.Union<CqlInterval<CqlDate>>(bo_, cv_);
        CqlValueSet cx_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> cy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> da_(MedicationRequest MR)
        {
            IEnumerable<Medication> jq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? jr_(Medication M)
            {
                object jv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object jw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jx_ = context.Operators.Split((string)jw_, "/");
                string jy_ = context.Operators.Last<string>(jx_);
                bool? jz_ = context.Operators.Equal(jv_, jy_);
                CodeableConcept ka_ = M?.Code;
                CqlConcept kb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ka_);
                CqlValueSet kc_ = this.Guanfacine_Medications(context);
                bool? kd_ = context.Operators.ConceptInValueSet(kb_, kc_);
                bool? ke_ = context.Operators.And(jz_, kd_);

                return ke_;
            };
            IEnumerable<Medication> js_ = context.Operators.Where<Medication>(jq_, jr_);
            MedicationRequest jt_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ju_ = context.Operators.Select<Medication, MedicationRequest>(js_, jt_);

            return ju_;
        };
        IEnumerable<MedicationRequest> db_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, da_);
        IEnumerable<MedicationRequest> dc_ = context.Operators.Union<MedicationRequest>(cy_, db_);
        IEnumerable<MedicationRequest> dd_ = Status_1_8_000.Instance.isMedicationOrder(context, dc_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? de_(MedicationRequest GuanfacineMed)
        {
            CqlInterval<CqlDate> kf_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate kh_ = context.Operators.Start(kf_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ki_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kf_, kh_);

            return ki_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> df_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dd_, de_);
        object dg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate kj_ = @this?.periodStart;

            return kj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(df_, dg_, System.ComponentModel.ListSortDirection.Ascending);
        bool? di_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kk_ = @this?.period;
            bool? kl_ = context.Operators.Not((bool?)(kk_ is null));

            return kl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dj_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dh_, di_);
        CqlInterval<CqlDate> dk_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> km_ = @this?.period;

            return km_;
        };
        IEnumerable<CqlInterval<CqlDate>> dl_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dj_, dk_);
        IEnumerable<CqlInterval<CqlDate>> dm_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, dl_);
        CqlCode dn_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> do_ = context.Operators.ToList<CqlCode>(dn_);
        IEnumerable<MedicationRequest> dp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, do_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dr_(MedicationRequest MR)
        {
            IEnumerable<Medication> kn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ko_(Medication M)
            {
                object ks_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kt_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ku_ = context.Operators.Split((string)kt_, "/");
                string kv_ = context.Operators.Last<string>(ku_);
                bool? kw_ = context.Operators.Equal(ks_, kv_);
                CodeableConcept kx_ = M?.Code;
                CqlConcept ky_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kx_);
                CqlCode kz_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
                CqlConcept la_ = context.Operators.ConvertCodeToConcept(kz_);
                bool? lb_ = context.Operators.Equivalent(ky_, la_);
                bool? lc_ = context.Operators.And(kw_, lb_);

                return lc_;
            };
            IEnumerable<Medication> kp_ = context.Operators.Where<Medication>(kn_, ko_);
            MedicationRequest kq_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> kr_ = context.Operators.Select<Medication, MedicationRequest>(kp_, kq_);

            return kr_;
        };
        IEnumerable<MedicationRequest> ds_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, dr_);
        IEnumerable<MedicationRequest> dt_ = context.Operators.Union<MedicationRequest>(dp_, ds_);
        IEnumerable<MedicationRequest> du_ = Status_1_8_000.Instance.isMedicationOrder(context, dt_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? dv_(MedicationRequest MethamphetamineMed)
        {
            CqlInterval<CqlDate> ld_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate lf_ = context.Operators.Start(ld_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lg_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, ld_, lf_);

            return lg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dw_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(du_, dv_);
        object dx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate lh_ = @this?.periodStart;

            return lh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> dy_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dw_, dx_, System.ComponentModel.ListSortDirection.Ascending);
        bool? dz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> li_ = @this?.period;
            bool? lj_ = context.Operators.Not((bool?)(li_ is null));

            return lj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ea_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(dy_, dz_);
        CqlInterval<CqlDate> eb_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lk_ = @this?.period;

            return lk_;
        };
        IEnumerable<CqlInterval<CqlDate>> ec_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ea_, eb_);
        IEnumerable<CqlInterval<CqlDate>> ed_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, ec_);
        IEnumerable<CqlInterval<CqlDate>> ee_ = context.Operators.Union<CqlInterval<CqlDate>>(dm_, ed_);
        IEnumerable<CqlInterval<CqlDate>> ef_ = context.Operators.Union<CqlInterval<CqlDate>>(cw_, ee_);
        CqlInterval<CqlDate> eg_(CqlInterval<CqlDate> ADHDMedication)
        {
            CqlDate ll_ = this.IPSD(context);
            CqlQuantity ln_ = context.Operators.Quantity(300m, "days");
            CqlDate lo_ = context.Operators.Add(ll_, ln_);
            CqlInterval<CqlDate> lp_ = context.Operators.Interval(ll_, lo_, true, true);
            CqlInterval<CqlDate> lq_ = context.Operators.Intersect<CqlDate>(ADHDMedication, lp_);

            return lq_;
        };
        IEnumerable<CqlInterval<CqlDate>> eh_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(ef_, eg_);

        return eh_;
    }


    [CqlExpressionDefinition("ADHD Cumulative Medication Duration")]
    public int? ADHD_Cumulative_Medication_Duration(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
        int? b_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, a_);

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
        IEnumerable<Encounter> b_ = Status_1_8_000.Instance.isEncounterPerformed(context, a_);
        bool? c_(Encounter ValidNumeratorEncounter)
        {
            Period h_ = ValidNumeratorEncounter?.Period;
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
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        CqlDate e_(Encounter ValidNumeratorEncounter)
        {
            Period u_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlDate x_ = context.Operators.DateFrom(w_);

            return x_;
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
        IEnumerable<Encounter> c_ = Status_1_8_000.Instance.isEncounterPerformed(context, b_);
        bool? d_(Encounter VirtualEnc)
        {
            Period i_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_2_1_000.Instance.toInterval(context, j_ as object);
            CqlInterval<CqlDate> l_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, k_);
            CqlDate m_ = context.Operators.Start(l_);
            CqlDate n_ = this.IPSD(context);
            CqlQuantity o_ = context.Operators.Quantity(31m, "days");
            CqlDate p_ = context.Operators.Add(n_, o_);
            CqlQuantity r_ = context.Operators.Quantity(300m, "days");
            CqlDate s_ = context.Operators.Add(n_, r_);
            CqlInterval<CqlDate> t_ = context.Operators.Interval(p_, s_, true, true);
            bool? u_ = context.Operators.In<CqlDate>(m_, t_, "day");

            return u_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        CqlDate f_(Encounter VirtualEnc)
        {
            Period v_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);

            return y_;
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
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW = new(
      [typeof(CqlDate)],
      ["startDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD = new(
      [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
      ["period", "periodStart"]);

    #endregion CqlTupleMetadata Properties

}
