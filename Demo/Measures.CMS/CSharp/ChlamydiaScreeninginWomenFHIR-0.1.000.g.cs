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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("ChlamydiaScreeninginWomenFHIR", "0.1.000")]
public partial class ChlamydiaScreeninginWomenFHIR_0_1_000 : ILibrary, ISingleton<ChlamydiaScreeninginWomenFHIR_0_1_000>
{
    private ChlamydiaScreeninginWomenFHIR_0_1_000() {}

    public static ChlamydiaScreeninginWomenFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "ChlamydiaScreeninginWomenFHIR";
    string ILibrary.Version => "0.1.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Status_1_8_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Chlamydia Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052")]
    public CqlValueSet Chlamydia_Screening(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", default);



    [CqlDeclaration("Complications of Pregnancy, Childbirth and the Puerperium")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012")]
    public CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", default);



    [CqlDeclaration("Contraceptive Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080")]
    public CqlValueSet Contraceptive_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", default);



    [CqlDeclaration("Diagnoses Used to Indicate Sexual Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018")]
    public CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", default);



    [CqlDeclaration("Diagnostic Studies During Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008")]
    public CqlValueSet Diagnostic_Studies_During_Pregnancy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", default);



    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
    public CqlValueSet HIV(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);



    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);



    [CqlDeclaration("Isotretinoin")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143")]
    public CqlValueSet Isotretinoin(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", default);



    [CqlDeclaration("Lab Tests During Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007")]
    public CqlValueSet Lab_Tests_During_Pregnancy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", default);



    [CqlDeclaration("Lab Tests for Sexually Transmitted Infections")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051")]
    public CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", default);



    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);



    [CqlDeclaration("Virtual Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Virtual_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);



    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
    public CqlValueSet Pap_Test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", default);



    [CqlDeclaration("Pregnancy Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011")]
    public CqlValueSet Pregnancy_Test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", default);



    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);



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



    [CqlDeclaration("Procedures Used to Indicate Sexual Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017")]
    public CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", default);



    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);



    [CqlDeclaration("XRay Study")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034")]
    public CqlValueSet XRay_Study(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", default);



    [CqlDeclaration("Female")]
    public CqlCode Female(CqlContext context) =>
        new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);



    [CqlDeclaration("Have you ever had vaginal intercourse [PhenX]")]
    public CqlCode Have_you_ever_had_vaginal_intercourse__PhenX_(CqlContext context) =>
        new CqlCode("64728-9", "http://loinc.org", default, default);



    [CqlDeclaration("Yes (qualifier value)")]
    public CqlCode Yes__qualifier_value_(CqlContext context) =>
        new CqlCode("373066001", "http://snomed.info/sct", default, default);



    [CqlDeclaration("AdministrativeGender")]
    public CqlCode[] AdministrativeGender(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("64728-9", "http://loinc.org", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("373066001", "http://snomed.info/sct", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", c_);

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
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        IEnumerable<Encounter> x_ = Status_1_8_000.Instance.isEncounterPerformed(context, w_);
        bool? y_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
            Period ab_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_1_000.Instance.toInterval(context, ac_ as object);
            bool? ae_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aa_, ad_, "day");

            return ae_;
        };
        IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(x_, y_);

        return z_;
    }



    [CqlDeclaration("Has Assessments Identifying Sexual Activity")]
    public bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlCode a_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        bool? e_(Observation SexualActivityAssessment)
        {
            DataType h_ = SexualActivityAssessment?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlCode j_ = this.Yes__qualifier_value_(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_ as CqlConcept, k_);
            DataType m_ = SexualActivityAssessment?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_);
            CqlInterval<CqlDateTime> p_()
            {
                bool s_()
                {
                    CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                    CqlDateTime u_ = context.Operators.End(t_);

                    return u_ is null;
                };
                if (s_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                    CqlDateTime w_ = context.Operators.End(v_);
                    CqlDateTime y_ = context.Operators.End(v_);
                    CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

                    return z_;
                }
            };
            bool? q_ = context.Operators.SameOrBefore(o_, p_(), default);
            bool? r_ = context.Operators.And(l_, q_);

            return r_;
        };
        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);

        return g_;
    }



    [CqlDeclaration("Has Diagnoses Identifying Sexual Activity")]
    public bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet a_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.HIV(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
        bool? i_(Condition SexualActivityDiagnosis)
        {
            CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SexualActivityDiagnosis);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            bool? n_ = context.Operators.Overlaps(l_, m_, default);

            return n_;
        };
        IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
        bool? k_ = context.Operators.Exists<Condition>(j_);

        return k_;
    }



    [CqlDeclaration("Has Active Contraceptive Medications")]
    public bool? Has_Active_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet a_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = Status_1_8_000.Instance.isMedicationActive(context, e_);
        bool? g_(MedicationRequest ActiveContraceptives)
        {
            CqlInterval<CqlDate> j_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
            CqlDate k_ = j_?.low;
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
            CqlDate n_ = j_?.high;
            CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
            bool? q_ = j_?.lowClosed;
            bool? s_ = j_?.highClosed;
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(l_, o_, q_, s_);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            bool? v_ = context.Operators.Overlaps(t_, u_, default);

            return v_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        bool? i_ = context.Operators.Exists<MedicationRequest>(h_);

        return i_;
    }



    [CqlDeclaration("Has Ordered Contraceptive Medications")]
    public bool? Has_Ordered_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet a_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = Status_1_8_000.Instance.isMedicationOrder(context, e_);
        bool? g_(MedicationRequest OrderedContraceptives)
        {
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            FhirDateTime k_ = OrderedContraceptives?.AuthoredOnElement;
            CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.toInterval(context, l_ as object);
            bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, "day");

            return n_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        bool? i_ = context.Operators.Exists<MedicationRequest>(h_);

        return i_;
    }



    [CqlDeclaration("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context)
    {
        CqlValueSet a_ = this.Pap_Test(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet c_ = this.Lab_Tests_During_Pregnancy(context);
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        CqlValueSet f_ = this.Lab_Tests_for_Sexually_Transmitted_Infections(context);
        IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> h_ = context.Operators.Union<ServiceRequest>(e_, g_);
        IEnumerable<ServiceRequest> i_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, h_);
        bool? j_(ServiceRequest LabOrders)
        {
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            FhirDateTime n_ = LabOrders?.AuthoredOnElement;
            CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

            return q_;
        };
        IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
        bool? l_ = context.Operators.Exists<ServiceRequest>(k_);

        return l_;
    }



    [CqlDeclaration("Has Laboratory Tests Identifying Sexual Activity")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, b_);
        bool? d_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            FhirDateTime j_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.toInterval(context, k_ as object);
            bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, l_, "day");

            return m_;
        };
        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
        bool? f_ = context.Operators.Exists<ServiceRequest>(e_);
        bool? g_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? h_ = context.Operators.Or(f_, g_);

        return h_;
    }



    [CqlDeclaration("Has Diagnostic Studies Identifying Sexual Activity")]
    public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet a_ = this.Diagnostic_Studies_During_Pregnancy(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, b_);
        bool? d_(ServiceRequest SexualActivityDiagnostics)
        {
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            FhirDateTime h_ = SexualActivityDiagnostics?.AuthoredOnElement;
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.toInterval(context, i_ as object);
            bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

            return k_;
        };
        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
        bool? f_ = context.Operators.Exists<ServiceRequest>(e_);

        return f_;
    }



    [CqlDeclaration("Has Procedures Identifying Sexual Activity")]
    public bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet a_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_8_000.Instance.isProcedurePerformed(context, b_);
        bool? d_(Procedure ProceduresForSexualActivity)
        {
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            DataType h_ = ProceduresForSexualActivity?.Performed;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.toInterval(context, i_);
            bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

            return k_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        bool? f_ = context.Operators.Exists<Procedure>(e_);

        return f_;
    }



    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(16, 24, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        Code<AdministrativeGender> l_ = a_?.GenderElement;
        AdministrativeGender? m_ = l_?.Value;
        string n_ = context.Operators.Convert<string>(m_);
        bool? o_ = context.Operators.Equal(n_, "female");
        bool? p_ = context.Operators.And(j_, o_);
        IEnumerable<Encounter> q_ = this.Qualifying_Encounters(context);
        bool? r_ = context.Operators.Exists<Encounter>(q_);
        bool? s_ = context.Operators.And(p_, r_);
        bool? t_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? u_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? v_ = context.Operators.Or(t_, u_);
        bool? w_ = this.Has_Active_Contraceptive_Medications(context);
        bool? x_ = context.Operators.Or(v_, w_);
        bool? y_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? z_ = context.Operators.Or(x_, y_);
        bool? aa_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
        bool? ab_ = context.Operators.Or(z_, aa_);
        bool? ac_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? ad_ = context.Operators.Or(ab_, ac_);
        bool? ae_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? af_ = context.Operators.Or(ad_, ae_);
        bool? ag_ = context.Operators.And(s_, af_);

        return ag_;
    }



    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }



    [CqlDeclaration("Has Pregnancy Test Exclusion")]
    public bool? Has_Pregnancy_Test_Exclusion(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, b_);
        IEnumerable<ServiceRequest> d_(ServiceRequest PregnancyTest)
        {
            CqlValueSet q_ = this.XRay_Study(context);
            IEnumerable<ServiceRequest> r_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> s_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, r_);
            bool? t_(ServiceRequest XrayOrder)
            {
                FhirDateTime x_ = XrayOrder?.AuthoredOnElement;
                CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
                CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
                CqlDateTime aa_ = context.Operators.Start(z_);
                FhirDateTime ab_ = PregnancyTest?.AuthoredOnElement;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_1_000.Instance.toInterval(context, ac_ as object);
                CqlDateTime ae_ = context.Operators.End(ad_);
                CqlDateTime ag_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_1_000.Instance.toInterval(context, ag_ as object);
                CqlDateTime ai_ = context.Operators.End(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(6m, "days");
                CqlDateTime ak_ = context.Operators.Add(ai_, aj_);
                CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ae_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(aa_, al_, "day");
                CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_1_000.Instance.toInterval(context, ao_ as object);
                CqlDateTime aq_ = context.Operators.End(ap_);
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                bool? as_ = context.Operators.And(am_, ar_);

                return as_;
            };
            IEnumerable<ServiceRequest> u_ = context.Operators.Where<ServiceRequest>(s_, t_);
            ServiceRequest v_(ServiceRequest XrayOrder) =>
                PregnancyTest;
            IEnumerable<ServiceRequest> w_ = context.Operators.Select<ServiceRequest, ServiceRequest>(u_, v_);

            return w_;
        };
        IEnumerable<ServiceRequest> e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);
        bool? f_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> at_ = this.Measurement_Period(context);
            FhirDateTime au_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
            CqlInterval<CqlDateTime> aw_ = QICoreCommon_2_1_000.Instance.toInterval(context, av_ as object);
            bool? ax_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(at_, aw_, default);

            return ax_;
        };
        IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> j_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, i_);
        IEnumerable<ServiceRequest> k_(ServiceRequest PregnancyTestOrder)
        {
            CqlValueSet ay_ = this.Isotretinoin(context);
            IEnumerable<MedicationRequest> az_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> bb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(az_, bb_);
            IEnumerable<MedicationRequest> bd_ = Status_1_8_000.Instance.isMedicationOrder(context, bc_);
            bool? be_(MedicationRequest AccutaneOrder)
            {
                FhirDateTime bi_ = AccutaneOrder?.AuthoredOnElement;
                CqlDateTime bj_ = context.Operators.Convert<CqlDateTime>(bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_1_000.Instance.toInterval(context, bj_ as object);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                FhirDateTime bm_ = PregnancyTestOrder?.AuthoredOnElement;
                CqlDateTime bn_ = context.Operators.Convert<CqlDateTime>(bm_);
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bn_ as object);
                CqlDateTime bp_ = context.Operators.End(bo_);
                CqlDateTime br_ = context.Operators.Convert<CqlDateTime>(bm_);
                CqlInterval<CqlDateTime> bs_ = QICoreCommon_2_1_000.Instance.toInterval(context, br_ as object);
                CqlDateTime bt_ = context.Operators.End(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(6m, "days");
                CqlDateTime bv_ = context.Operators.Add(bt_, bu_);
                CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bp_, bv_, true, true);
                bool? bx_ = context.Operators.In<CqlDateTime>(bl_, bw_, "day");
                CqlDateTime bz_ = context.Operators.Convert<CqlDateTime>(bm_);
                CqlInterval<CqlDateTime> ca_ = QICoreCommon_2_1_000.Instance.toInterval(context, bz_ as object);
                CqlDateTime cb_ = context.Operators.End(ca_);
                bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                bool? cd_ = context.Operators.And(bx_, cc_);

                return cd_;
            };
            IEnumerable<MedicationRequest> bf_ = context.Operators.Where<MedicationRequest>(bd_, be_);
            ServiceRequest bg_(MedicationRequest AccutaneOrder) =>
                PregnancyTestOrder;
            IEnumerable<ServiceRequest> bh_ = context.Operators.Select<MedicationRequest, ServiceRequest>(bf_, bg_);

            return bh_;
        };
        IEnumerable<ServiceRequest> l_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(j_, k_);
        bool? m_(ServiceRequest PregnancyTestOrder)
        {
            CqlInterval<CqlDateTime> ce_ = this.Measurement_Period(context);
            FhirDateTime cf_ = PregnancyTestOrder?.AuthoredOnElement;
            CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
            CqlInterval<CqlDateTime> ch_ = QICoreCommon_2_1_000.Instance.toInterval(context, cg_ as object);
            bool? ci_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ce_, ch_, default);

            return ci_;
        };
        IEnumerable<ServiceRequest> n_ = context.Operators.Where<ServiceRequest>(l_, m_);
        IEnumerable<ServiceRequest> o_ = context.Operators.Union<ServiceRequest>(g_, n_);
        bool? p_ = context.Operators.Exists<ServiceRequest>(o_);

        return p_;
    }



    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? b_ = this.Has_Pregnancy_Test_Exclusion(context);
        bool? c_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? d_ = context.Operators.Not(c_);
        bool? e_ = context.Operators.And(b_, d_);
        bool? f_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? g_ = context.Operators.Not(f_);
        bool? h_ = context.Operators.And(e_, g_);
        bool? i_ = this.Has_Active_Contraceptive_Medications(context);
        bool? j_ = context.Operators.Not(i_);
        bool? k_ = context.Operators.And(h_, j_);
        bool? l_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? m_ = context.Operators.Not(l_);
        bool? n_ = context.Operators.And(k_, m_);
        bool? o_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? p_ = context.Operators.Not(o_);
        bool? q_ = context.Operators.And(n_, p_);
        bool? r_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? s_ = context.Operators.Not(r_);
        bool? t_ = context.Operators.And(q_, s_);
        bool? u_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? v_ = context.Operators.Not(u_);
        bool? w_ = context.Operators.And(t_, v_);
        bool? x_ = context.Operators.Or(a_, w_);

        return x_;
    }



    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet a_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> c_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, b_);
        bool? d_(Observation ChlamydiaTest)
        {
            object g_()
            {
                bool o_()
                {
                    DataType r_ = ChlamydiaTest?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool t_ = s_ is CqlDateTime;

                    return t_;
                };
                bool p_()
                {
                    DataType u_ = ChlamydiaTest?.Effective;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlInterval<CqlDateTime>;

                    return w_;
                };
                bool q_()
                {
                    DataType x_ = ChlamydiaTest?.Effective;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlDateTime;

                    return z_;
                };
                if (o_())
                {
                    DataType aa_ = ChlamydiaTest?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlDateTime) as object;
                }
                else if (p_())
                {
                    DataType ac_ = ChlamydiaTest?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (q_())
                {
                    DataType ae_ = ChlamydiaTest?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);

                    return (af_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime h_ = QICoreCommon_2_1_000.Instance.latest(context, g_());
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            bool? j_ = context.Operators.In<CqlDateTime>(h_, i_, "day");
            DataType k_ = ChlamydiaTest?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            bool? m_ = context.Operators.Not((bool?)(l_ is null));
            bool? n_ = context.Operators.And(j_, m_);

            return n_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);

        return f_;
    }



    [CqlDeclaration("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(16, 20, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }



    [CqlDeclaration("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(21, 24, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }



}
