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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("FallsScreeningForFutureFallRiskFHIR", "0.2.001")]
public partial class FallsScreeningForFutureFallRiskFHIR_0_2_001 : ILibrary, ISingleton<FallsScreeningForFutureFallRiskFHIR_0_2_001>
{
    private FallsScreeningForFutureFallRiskFHIR_0_2_001() {}

    public static FallsScreeningForFutureFallRiskFHIR_0_2_001 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "FallsScreeningForFutureFallRiskFHIR";
    string ILibrary.Version => "0.2.001";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);



    [CqlDeclaration("Audiology Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1066")]
    public CqlValueSet Audiology_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1066", default);



    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);



    [CqlDeclaration("Discharge Services Nursing Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013")]
    public CqlValueSet Discharge_Services_Nursing_Facility(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", default);



    [CqlDeclaration("Falls Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1028")]
    public CqlValueSet Falls_Screening(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1028", default);



    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);



    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);



    [CqlDeclaration("Occupational Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011")]
    public CqlValueSet Occupational_Therapy_Evaluation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", default);



    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);



    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
    public CqlValueSet Ophthalmological_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);



    [CqlDeclaration("Physical Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022")]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", default);



    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);



    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);



    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);



    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);



    [CqlDeclaration("Virtual Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Virtual_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);



    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("FallsScreeningForFutureFallRiskFHIR-0.2.001", "Measurement Period", c_);

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



    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        CqlValueSet x_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet z_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
        CqlValueSet ad_ = this.Audiology_Visit(context);
        IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet af_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ah_ = context.Operators.Union<Encounter>(ae_, ag_);
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ac_, ah_);
        CqlValueSet aj_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet al_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);
        IEnumerable<Encounter> ao_ = context.Operators.Union<Encounter>(ai_, an_);
        CqlValueSet ap_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> aq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ar_ = context.Operators.Union<Encounter>(ao_, aq_);
        IEnumerable<Encounter> as_ = Status_1_8_000.Instance.isEncounterPerformed(context, ar_);
        bool? at_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> av_ = this.Measurement_Period(context);
            Period aw_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
            CqlInterval<CqlDateTime> ay_ = QICoreCommon_2_1_000.Instance.toInterval(context, ax_ as object);
            bool? az_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(av_, ay_, "day");

            return az_;
        };
        IEnumerable<Encounter> au_ = context.Operators.Where<Encounter>(as_, at_);

        return au_;
    }



    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 65);
        IEnumerable<Encounter> j_ = this.Qualifying_Encounter(context);
        bool? k_ = context.Operators.Exists<Encounter>(j_);
        bool? l_ = context.Operators.And(i_, k_);

        return l_;
    }



    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }



    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return a_;
    }



    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet a_ = this.Falls_Screening(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> c_ = Status_1_8_000.Instance.isAssessmentPerformed(context, b_);
        bool? d_(Observation FallsScreening)
        {
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            DataType h_ = FallsScreening?.Effective;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.toInterval(context, i_);
            bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

            return k_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);

        return f_;
    }


    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ = new(
        [typeof(CqlConcept), typeof(CqlInterval<CqlDateTime>)],
        ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
        [typeof(CqlDate)],
        ["AntidepressantDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU = new(
        [typeof(Encounter), typeof(Condition)],
        ["VisitWithAntibiotic", "AcutePharyngitisTonsillitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV = new(
        [typeof(Observation), typeof(Encounter)],
        ["GroupAStreptococcusTest", "EncounterWithPharyngitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounters", "URI"]);

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    private static CqlTupleMetadata CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["DTaPVaccination1", "DTaPVaccination2", "DTaPVaccination3", "DTaPVaccination4"]);

    private static CqlTupleMetadata CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["PolioVaccination1", "PolioVaccination2", "PolioVaccination3"]);

    private static CqlTupleMetadata CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["HepatitisBVaccination1", "HepatitisBVaccination2", "HepatitisBVaccination3"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["HepatitisBVaccination1", "HepatitisBVaccination2", "NewBornVaccine3"]);

    private static CqlTupleMetadata CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["PneumococcalVaccination1", "PneumococcalVaccination2", "PneumococcalVaccination3", "PneumococcalVaccination4"]);

    private static CqlTupleMetadata CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["FluVaccination1", "FluVaccination2"]);

    private static CqlTupleMetadata CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb = new(
        [typeof(string), typeof(CqlDateTime)],
        ["ID", "AuthorDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
        [typeof(CqlQuantity), typeof(Observation)],
        ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

}
