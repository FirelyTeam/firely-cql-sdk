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
[CqlLibrary("InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR", "0.0.002")]
public partial class InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR_0_0_002 : ILibrary, ISingleton<InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR_0_0_002>
{
    private InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR_0_0_002() {}

    public static InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR_0_0_002 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR";
    public string Version => "0.0.002";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Detoxification Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1059", valueSetVersion: null)]
    public CqlValueSet Detoxification_Visit(CqlContext _) => _Detoxification_Visit;
    private static readonly CqlValueSet _Detoxification_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1059", null);

    [CqlValueSetDefinition("Discharge Services Hospital Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1007", valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Hospital_Inpatient(CqlContext _) => _Discharge_Services_Hospital_Inpatient;
    private static readonly CqlValueSet _Discharge_Services_Hospital_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1007", null);

    [CqlValueSetDefinition("Discharge Services Hospital Inpatient Same Day Discharge", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1006", valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Hospital_Inpatient_Same_Day_Discharge(CqlContext _) => _Discharge_Services_Hospital_Inpatient_Same_Day_Discharge;
    private static readonly CqlValueSet _Discharge_Services_Hospital_Inpatient_Same_Day_Discharge = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1006", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Initial Hospital Inpatient Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1004", valueSetVersion: null)]
    public CqlValueSet Initial_Hospital_Inpatient_Visit(CqlContext _) => _Initial_Hospital_Inpatient_Visit;
    private static readonly CqlValueSet _Initial_Hospital_Inpatient_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1004", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Substance Use Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1001", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder(CqlContext _) => _Substance_Use_Disorder;
    private static readonly CqlValueSet _Substance_Use_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1001", null);

    [CqlValueSetDefinition("Substance Use Disorder Long Acting Medication", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1149", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Long_Acting_Medication(CqlContext _) => _Substance_Use_Disorder_Long_Acting_Medication;
    private static readonly CqlValueSet _Substance_Use_Disorder_Long_Acting_Medication = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1149", null);

    [CqlValueSetDefinition("Substance Use Disorder Long Acting Medication Administration", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1156", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Long_Acting_Medication_Administration(CqlContext _) => _Substance_Use_Disorder_Long_Acting_Medication_Administration;
    private static readonly CqlValueSet _Substance_Use_Disorder_Long_Acting_Medication_Administration = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1156", null);

    [CqlValueSetDefinition("Substance Use Disorder Short Acting Medication", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1150", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Short_Acting_Medication(CqlContext _) => _Substance_Use_Disorder_Short_Acting_Medication;
    private static readonly CqlValueSet _Substance_Use_Disorder_Short_Acting_Medication = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1150", null);

    [CqlValueSetDefinition("Substance Use Disorder Short Acting Medication Administration", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1157", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Short_Acting_Medication_Administration(CqlContext _) => _Substance_Use_Disorder_Short_Acting_Medication_Administration;
    private static readonly CqlValueSet _Substance_Use_Disorder_Short_Acting_Medication_Administration = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1157", null);

    [CqlValueSetDefinition("Substance Use Disorder Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1005", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Treatment(CqlContext _) => _Substance_Use_Disorder_Treatment;
    private static readonly CqlValueSet _Substance_Use_Disorder_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1005", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR-0.0.002", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
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


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Detoxification_Visit(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Initial_Hospital_Inpatient_Visit(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Discharge_Services_Hospital_Inpatient_Same_Day_Discharge(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Discharge_Services_Hospital_Inpatient(context);
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

        return x_;
    }


    [CqlExpressionDefinition("First SUD Episode During Measurement Period")]
    public Encounter First_SUD_Episode_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> b_(Encounter ValidEncounters)
        {
            CqlValueSet k_ = this.Substance_Use_Disorder(context);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? m_(Condition SUDDiagnosis)
            {
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                Period r_ = ValidEncounters?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_ as object);
                bool? u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, t_, default);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
                bool? aa_ = context.Operators.In<CqlDateTime>(w_, z_, default);
                bool? ab_ = context.Operators.And(u_, aa_);
                CqlDateTime ad_ = context.Operators.Start(v_);
                CqlDateTime af_ = context.Operators.End(q_);
                CqlQuantity ag_ = context.Operators.Quantity(47m, "days");
                CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
                bool? ai_ = context.Operators.SameOrBefore(ad_, ah_, "day");
                bool? aj_ = context.Operators.And(ab_, ai_);

                return aj_;
            };
            IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
            Encounter o_(Condition SUDDiagnosis) =>
                ValidEncounters;
            IEnumerable<Encounter> p_ = context.Operators.Select<Condition, Encounter>(n_, o_);

            return p_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? d_(Encounter ValidEncounters)
        {
            Period ak_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_1_000.Instance.toInterval(context, al_ as object);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? ap_ = (CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ, ao_, ValidEncounters);

            return ap_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> e_ = context.Operators.Select<Encounter, (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(e_);
        object g_((CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? @this)
        {
            CqlDate aq_ = @this?.ValidEncounterDate;

            return aq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> h_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? i_ = context.Operators.First<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(h_);
        Encounter j_ = i_?.ValidEncounter;

        return j_;
    }


    [CqlExpressionDefinition("Emergency Department or Detoxification Visit")]
    public IEnumerable<Encounter> Emergency_Department_or_Detoxification_Visit(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Detoxification_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Encounter> f_ = Status_1_8_000.Instance.isEncounterPerformed(context, e_);

        return f_;
    }


    [CqlExpressionDefinition("History of SUD Diagnosis or Treatment")]
    public IEnumerable<object> History_of_SUD_Diagnosis_or_Treatment(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Treatment(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        CqlValueSet f_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet h_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = context.Operators.Union<Procedure>(g_, i_);
        IEnumerable<Procedure> k_ = context.Operators.Union<Procedure>(e_, j_);
        IEnumerable<Procedure> l_ = Status_1_8_000.Instance.isInterventionPerformed(context, k_);
        IEnumerable<Procedure> m_(Procedure Interventions)
        {
            Encounter an_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ao_ = [
                an_,
            ];
            bool? ap_(Encounter FirstSUDEpisode)
            {
                DataType at_ = Interventions?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlInterval<CqlDateTime> av_ = QICoreCommon_2_1_000.Instance.toInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                Period ax_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> az_ = QICoreCommon_2_1_000.Instance.toInterval(context, ay_ as object);
                CqlDateTime ba_ = context.Operators.Start(az_);
                CqlDate bb_ = context.Operators.DateFrom(ba_);
                CqlQuantity bc_ = context.Operators.Quantity(60m, "days");
                CqlDate bd_ = context.Operators.Subtract(bb_, bc_);
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_1_000.Instance.toInterval(context, bf_ as object);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlDate bi_ = context.Operators.DateFrom(bh_);
                CqlInterval<CqlDate> bj_ = context.Operators.Interval(bd_, bi_, true, false);
                CqlDate bk_ = bj_?.low;
                CqlDateTime bl_ = context.Operators.ConvertDateToDateTime(bk_);
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bn_ as object);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDate bq_ = context.Operators.DateFrom(bp_);
                CqlDate bs_ = context.Operators.Subtract(bq_, bc_);
                CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> bv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bu_ as object);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                CqlDate bx_ = context.Operators.DateFrom(bw_);
                CqlInterval<CqlDate> by_ = context.Operators.Interval(bs_, bx_, true, false);
                CqlDate bz_ = by_?.high;
                CqlDateTime ca_ = context.Operators.ConvertDateToDateTime(bz_);
                CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> cd_ = QICoreCommon_2_1_000.Instance.toInterval(context, cc_ as object);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlDate cf_ = context.Operators.DateFrom(ce_);
                CqlDate ch_ = context.Operators.Subtract(cf_, bc_);
                CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> ck_ = QICoreCommon_2_1_000.Instance.toInterval(context, cj_ as object);
                CqlDateTime cl_ = context.Operators.Start(ck_);
                CqlDate cm_ = context.Operators.DateFrom(cl_);
                CqlInterval<CqlDate> cn_ = context.Operators.Interval(ch_, cm_, true, false);
                bool? co_ = cn_?.lowClosed;
                CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> cr_ = QICoreCommon_2_1_000.Instance.toInterval(context, cq_ as object);
                CqlDateTime cs_ = context.Operators.Start(cr_);
                CqlDate ct_ = context.Operators.DateFrom(cs_);
                CqlDate cv_ = context.Operators.Subtract(ct_, bc_);
                CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> cy_ = QICoreCommon_2_1_000.Instance.toInterval(context, cx_ as object);
                CqlDateTime cz_ = context.Operators.Start(cy_);
                CqlDate da_ = context.Operators.DateFrom(cz_);
                CqlInterval<CqlDate> db_ = context.Operators.Interval(cv_, da_, true, false);
                bool? dc_ = db_?.highClosed;
                CqlInterval<CqlDateTime> dd_ = context.Operators.Interval(bl_, ca_, co_, dc_);
                bool? de_ = context.Operators.In<CqlDateTime>(aw_, dd_, "day");
                CqlInterval<CqlDateTime> dg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlInterval<CqlDateTime> dh_ = QICoreCommon_2_1_000.Instance.toInterval(context, dg_ as object);
                CqlDateTime di_ = context.Operators.Start(dh_);
                CqlDate dj_ = context.Operators.DateFrom(di_);
                bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
                bool? dl_ = context.Operators.And(de_, dk_);

                return dl_;
            };
            IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ao_, ap_);
            Procedure ar_(Encounter FirstSUDEpisode) =>
                Interventions;
            IEnumerable<Procedure> as_ = context.Operators.Select<Encounter, Procedure>(aq_, ar_);

            return as_;
        };
        IEnumerable<Procedure> n_ = context.Operators.SelectMany<Procedure, Procedure>(l_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> p_ = this.Emergency_Department_or_Detoxification_Visit(context);
        IEnumerable<Encounter> q_ = context.Operators.Except<Encounter>(o_, p_);
        bool? r_(Encounter QualifyingEncounter)
        {
            IEnumerable<Condition> dm_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, QualifyingEncounter);
            bool? dn_(Condition SUDDiagnosis)
            {
                CodeableConcept dq_ = SUDDiagnosis?.Code;
                CqlConcept dr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dq_);
                CqlValueSet ds_ = this.Substance_Use_Disorder(context);
                bool? dt_ = context.Operators.ConceptInValueSet(dr_, ds_);

                return dt_;
            };
            IEnumerable<Condition> do_ = context.Operators.Where<Condition>(dm_, dn_);
            bool? dp_ = context.Operators.Exists<Condition>(do_);

            return dp_;
        };
        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
        IEnumerable<Encounter> t_(Encounter SUDEncounterDx)
        {
            Encounter du_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] dv_ = [
                du_,
            ];
            bool? dw_(Encounter FirstSUDEpisode)
            {
                Period ea_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                CqlInterval<CqlDateTime> ec_ = QICoreCommon_2_1_000.Instance.toInterval(context, eb_ as object);
                CqlDateTime ed_ = context.Operators.Start(ec_);
                Period ee_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> eg_ = QICoreCommon_2_1_000.Instance.toInterval(context, ef_ as object);
                CqlDateTime eh_ = context.Operators.Start(eg_);
                CqlDate ei_ = context.Operators.DateFrom(eh_);
                CqlQuantity ej_ = context.Operators.Quantity(60m, "days");
                CqlDate ek_ = context.Operators.Subtract(ei_, ej_);
                CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> en_ = QICoreCommon_2_1_000.Instance.toInterval(context, em_ as object);
                CqlDateTime eo_ = context.Operators.Start(en_);
                CqlDate ep_ = context.Operators.DateFrom(eo_);
                CqlInterval<CqlDate> eq_ = context.Operators.Interval(ek_, ep_, true, false);
                CqlDate er_ = eq_?.low;
                CqlDateTime es_ = context.Operators.ConvertDateToDateTime(er_);
                CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> ev_ = QICoreCommon_2_1_000.Instance.toInterval(context, eu_ as object);
                CqlDateTime ew_ = context.Operators.Start(ev_);
                CqlDate ex_ = context.Operators.DateFrom(ew_);
                CqlDate ez_ = context.Operators.Subtract(ex_, ej_);
                CqlInterval<CqlDateTime> fb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> fc_ = QICoreCommon_2_1_000.Instance.toInterval(context, fb_ as object);
                CqlDateTime fd_ = context.Operators.Start(fc_);
                CqlDate fe_ = context.Operators.DateFrom(fd_);
                CqlInterval<CqlDate> ff_ = context.Operators.Interval(ez_, fe_, true, false);
                CqlDate fg_ = ff_?.high;
                CqlDateTime fh_ = context.Operators.ConvertDateToDateTime(fg_);
                CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> fk_ = QICoreCommon_2_1_000.Instance.toInterval(context, fj_ as object);
                CqlDateTime fl_ = context.Operators.Start(fk_);
                CqlDate fm_ = context.Operators.DateFrom(fl_);
                CqlDate fo_ = context.Operators.Subtract(fm_, ej_);
                CqlInterval<CqlDateTime> fq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> fr_ = QICoreCommon_2_1_000.Instance.toInterval(context, fq_ as object);
                CqlDateTime fs_ = context.Operators.Start(fr_);
                CqlDate ft_ = context.Operators.DateFrom(fs_);
                CqlInterval<CqlDate> fu_ = context.Operators.Interval(fo_, ft_, true, false);
                bool? fv_ = fu_?.lowClosed;
                CqlInterval<CqlDateTime> fx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> fy_ = QICoreCommon_2_1_000.Instance.toInterval(context, fx_ as object);
                CqlDateTime fz_ = context.Operators.Start(fy_);
                CqlDate ga_ = context.Operators.DateFrom(fz_);
                CqlDate gc_ = context.Operators.Subtract(ga_, ej_);
                CqlInterval<CqlDateTime> ge_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> gf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ge_ as object);
                CqlDateTime gg_ = context.Operators.Start(gf_);
                CqlDate gh_ = context.Operators.DateFrom(gg_);
                CqlInterval<CqlDate> gi_ = context.Operators.Interval(gc_, gh_, true, false);
                bool? gj_ = gi_?.highClosed;
                CqlInterval<CqlDateTime> gk_ = context.Operators.Interval(es_, fh_, fv_, gj_);
                bool? gl_ = context.Operators.In<CqlDateTime>(ed_, gk_, "day");
                CqlInterval<CqlDateTime> gn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlInterval<CqlDateTime> go_ = QICoreCommon_2_1_000.Instance.toInterval(context, gn_ as object);
                CqlDateTime gp_ = context.Operators.Start(go_);
                CqlDate gq_ = context.Operators.DateFrom(gp_);
                bool? gr_ = context.Operators.Not((bool?)(gq_ is null));
                bool? gs_ = context.Operators.And(gl_, gr_);

                return gs_;
            };
            IEnumerable<Encounter> dx_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)dv_, dw_);
            Encounter dy_(Encounter FirstSUDEpisode) =>
                SUDEncounterDx;
            IEnumerable<Encounter> dz_ = context.Operators.Select<Encounter, Encounter>(dx_, dy_);

            return dz_;
        };
        IEnumerable<Encounter> u_ = context.Operators.SelectMany<Encounter, Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        CqlValueSet w_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> z_(MedicationRequest MR)
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
                CqlValueSet hf_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
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
        IEnumerable<MedicationRequest> aa_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(y_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(x_, aa_);
        CqlValueSet ac_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> af_(MedicationRequest MR)
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
                CqlValueSet hu_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
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
        IEnumerable<MedicationRequest> ag_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(y_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ad_, ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Union<MedicationRequest>(ab_, ah_);
        IEnumerable<MedicationRequest> aj_ = Status_1_8_000.Instance.isMedicationOrder(context, ai_);
        IEnumerable<MedicationRequest> ak_(MedicationRequest SUDMedication)
        {
            Encounter hx_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] hy_ = [
                hx_,
            ];
            bool? hz_(Encounter FirstSUDEpisode)
            {
                FhirDateTime id_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime ie_ = context.Operators.Convert<CqlDateTime>(id_);
                CqlInterval<CqlDateTime> if_ = QICoreCommon_2_1_000.Instance.toInterval(context, ie_ as object);
                CqlDateTime ig_ = context.Operators.End(if_);
                Period ih_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ii_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> ij_ = QICoreCommon_2_1_000.Instance.toInterval(context, ii_ as object);
                CqlDateTime ik_ = context.Operators.Start(ij_);
                CqlDate il_ = context.Operators.DateFrom(ik_);
                CqlQuantity im_ = context.Operators.Quantity(60m, "days");
                CqlDate in_ = context.Operators.Subtract(il_, im_);
                CqlInterval<CqlDateTime> ip_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> iq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ip_ as object);
                CqlDateTime ir_ = context.Operators.Start(iq_);
                CqlDate is_ = context.Operators.DateFrom(ir_);
                CqlInterval<CqlDate> it_ = context.Operators.Interval(in_, is_, true, false);
                CqlDate iu_ = it_?.low;
                CqlDateTime iv_ = context.Operators.ConvertDateToDateTime(iu_);
                CqlInterval<CqlDateTime> ix_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> iy_ = QICoreCommon_2_1_000.Instance.toInterval(context, ix_ as object);
                CqlDateTime iz_ = context.Operators.Start(iy_);
                CqlDate ja_ = context.Operators.DateFrom(iz_);
                CqlDate jc_ = context.Operators.Subtract(ja_, im_);
                CqlInterval<CqlDateTime> je_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> jf_ = QICoreCommon_2_1_000.Instance.toInterval(context, je_ as object);
                CqlDateTime jg_ = context.Operators.Start(jf_);
                CqlDate jh_ = context.Operators.DateFrom(jg_);
                CqlInterval<CqlDate> ji_ = context.Operators.Interval(jc_, jh_, true, false);
                CqlDate jj_ = ji_?.high;
                CqlDateTime jk_ = context.Operators.ConvertDateToDateTime(jj_);
                CqlInterval<CqlDateTime> jm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> jn_ = QICoreCommon_2_1_000.Instance.toInterval(context, jm_ as object);
                CqlDateTime jo_ = context.Operators.Start(jn_);
                CqlDate jp_ = context.Operators.DateFrom(jo_);
                CqlDate jr_ = context.Operators.Subtract(jp_, im_);
                CqlInterval<CqlDateTime> jt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> ju_ = QICoreCommon_2_1_000.Instance.toInterval(context, jt_ as object);
                CqlDateTime jv_ = context.Operators.Start(ju_);
                CqlDate jw_ = context.Operators.DateFrom(jv_);
                CqlInterval<CqlDate> jx_ = context.Operators.Interval(jr_, jw_, true, false);
                bool? jy_ = jx_?.lowClosed;
                CqlInterval<CqlDateTime> ka_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> kb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ka_ as object);
                CqlDateTime kc_ = context.Operators.Start(kb_);
                CqlDate kd_ = context.Operators.DateFrom(kc_);
                CqlDate kf_ = context.Operators.Subtract(kd_, im_);
                CqlInterval<CqlDateTime> kh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> ki_ = QICoreCommon_2_1_000.Instance.toInterval(context, kh_ as object);
                CqlDateTime kj_ = context.Operators.Start(ki_);
                CqlDate kk_ = context.Operators.DateFrom(kj_);
                CqlInterval<CqlDate> kl_ = context.Operators.Interval(kf_, kk_, true, false);
                bool? km_ = kl_?.highClosed;
                CqlInterval<CqlDateTime> kn_ = context.Operators.Interval(iv_, jk_, jy_, km_);
                bool? ko_ = context.Operators.In<CqlDateTime>(ig_, kn_, "day");
                CqlInterval<CqlDateTime> kq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                CqlInterval<CqlDateTime> kr_ = QICoreCommon_2_1_000.Instance.toInterval(context, kq_ as object);
                CqlDateTime ks_ = context.Operators.Start(kr_);
                CqlDate kt_ = context.Operators.DateFrom(ks_);
                bool? ku_ = context.Operators.Not((bool?)(kt_ is null));
                bool? kv_ = context.Operators.And(ko_, ku_);

                return kv_;
            };
            IEnumerable<Encounter> ia_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)hy_, hz_);
            MedicationRequest ib_(Encounter FirstSUDEpisode) =>
                SUDMedication;
            IEnumerable<MedicationRequest> ic_ = context.Operators.Select<Encounter, MedicationRequest>(ia_, ib_);

            return ic_;
        };
        IEnumerable<MedicationRequest> al_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(aj_, ak_);
        IEnumerable<object> am_ = context.Operators.Union<object>(v_ as IEnumerable<object>, al_ as IEnumerable<object>);

        return am_;
    }


    [CqlExpressionDefinition("Initial Population")]
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
        bool? i_ = context.Operators.GreaterOrEqual(h_, 13);
        Encounter j_ = this.First_SUD_Episode_During_Measurement_Period(context);
        bool? k_ = context.Operators.Not((bool?)(j_ is null));
        bool? l_ = context.Operators.And(i_, k_);
        IEnumerable<object> m_ = this.History_of_SUD_Diagnosis_or_Treatment(context);
        bool? n_ = context.Operators.Exists<object>(m_);
        bool? o_ = context.Operators.Not(n_);
        bool? p_ = context.Operators.And(l_, o_);

        return p_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return a_;
    }


    [CqlExpressionDefinition("Psychosocial Visit")]
    public IEnumerable<object> Psychosocial_Visit(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Treatment(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        IEnumerable<Procedure> f_ = Status_1_8_000.Instance.isInterventionPerformed(context, e_);
        CqlValueSet g_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet i_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter> l_ = Status_1_8_000.Instance.isEncounterPerformed(context, k_);
        bool? m_(Encounter TelehealthEncounter)
        {
            IEnumerable<Condition> p_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, TelehealthEncounter);
            bool? q_(Condition SUDDiagnosis)
            {
                CodeableConcept t_ = SUDDiagnosis?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlValueSet v_ = this.Substance_Use_Disorder(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_, v_);

                return w_;
            };
            IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
            bool? s_ = context.Operators.Exists<Condition>(r_);

            return s_;
        };
        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(f_ as IEnumerable<object>, n_ as IEnumerable<object>);

        return o_;
    }


    [CqlExpressionDefinition("Treatment Initiation With Non Medication Intervention Dates")]
    public IEnumerable<CqlDate> Treatment_Initiation_With_Non_Medication_Intervention_Dates(CqlContext context)
    {
        IEnumerable<object> a_ = this.Psychosocial_Visit(context);
        IEnumerable<object> b_(object PsychosocialVisitProcedure)
        {
            Encounter l_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] m_ = [
                l_,
            ];
            bool? n_(Encounter FirstSUDEpisode)
            {
                object r_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                Period w_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_ as object);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_1_000.Instance.toInterval(context, ac_ as object);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(14m, "days");
                CqlDate ah_ = context.Operators.Add(af_, ag_);
                CqlInterval<CqlDate> ai_ = context.Operators.Interval(aa_, ah_, true, false);
                bool? aj_ = context.Operators.In<CqlDate>(v_, ai_, default);
                object ak_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "id");
                string al_ = context.Operators.LateBoundProperty<string>(ak_, "value");
                Id am_ = FirstSUDEpisode?.IdElement;
                string an_ = am_?.Value;
                bool? ao_ = context.Operators.Equivalent(al_, an_);
                bool? ap_ = context.Operators.Not(ao_);
                bool? aq_ = context.Operators.And(aj_, ap_);

                return aq_;
            };
            IEnumerable<Encounter> o_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)m_, n_);
            object p_(Encounter FirstSUDEpisode) =>
                PsychosocialVisitProcedure;
            IEnumerable<object> q_ = context.Operators.Select<Encounter, object>(o_, p_);

            return q_;
        };
        IEnumerable<object> c_ = context.Operators.SelectMany<object, object>(a_, b_);
        CqlDate d_(object PsychosocialVisitProcedure)
        {
            object ar_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            CqlInterval<CqlDateTime> at_ = QICoreCommon_2_1_000.Instance.toInterval(context, as_);
            CqlDateTime au_ = context.Operators.Start(at_);
            CqlDate av_ = context.Operators.DateFrom(au_);

            return av_;
        };
        IEnumerable<CqlDate> e_ = context.Operators.Select<object, CqlDate>(c_, d_);
        IEnumerable<object> g_(object PsychosocialVisitEncounter)
        {
            Encounter aw_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ax_ = [
                aw_,
            ];
            bool? ay_(Encounter FirstSUDEpisode)
            {
                object bc_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bc_ as Period);
                CqlInterval<CqlDateTime> be_ = QICoreCommon_2_1_000.Instance.toInterval(context, bd_ as object);
                CqlDateTime bf_ = context.Operators.Start(be_);
                CqlDate bg_ = context.Operators.DateFrom(bf_);
                Period bh_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_2_1_000.Instance.toInterval(context, bi_ as object);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlDate bl_ = context.Operators.DateFrom(bk_);
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bn_ as object);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDate bq_ = context.Operators.DateFrom(bp_);
                CqlQuantity br_ = context.Operators.Quantity(14m, "days");
                CqlDate bs_ = context.Operators.Add(bq_, br_);
                CqlInterval<CqlDate> bt_ = context.Operators.Interval(bl_, bs_, true, false);
                bool? bu_ = context.Operators.In<CqlDate>(bg_, bt_, default);
                object bv_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                string bw_ = context.Operators.LateBoundProperty<string>(bv_, "value");
                Id bx_ = FirstSUDEpisode?.IdElement;
                string by_ = bx_?.Value;
                bool? bz_ = context.Operators.Equivalent(bw_, by_);
                bool? ca_ = context.Operators.Not(bz_);
                bool? cb_ = context.Operators.And(bu_, ca_);

                return cb_;
            };
            IEnumerable<Encounter> az_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ax_, ay_);
            object ba_(Encounter FirstSUDEpisode) =>
                PsychosocialVisitEncounter;
            IEnumerable<object> bb_ = context.Operators.Select<Encounter, object>(az_, ba_);

            return bb_;
        };
        IEnumerable<object> h_ = context.Operators.SelectMany<object, object>(a_, g_);
        CqlDate i_(object PsychosocialVisitEncounter)
        {
            object cc_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_ as Period);
            CqlInterval<CqlDateTime> ce_ = QICoreCommon_2_1_000.Instance.toInterval(context, cd_ as object);
            CqlDateTime cf_ = context.Operators.Start(ce_);
            CqlDate cg_ = context.Operators.DateFrom(cf_);

            return cg_;
        };
        IEnumerable<CqlDate> j_ = context.Operators.Select<object, CqlDate>(h_, i_);
        IEnumerable<CqlDate> k_ = context.Operators.Union<CqlDate>(e_, j_);

        return k_;
    }


    [CqlExpressionDefinition("Treatment Initiation With Medication Order Dates")]
    public IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> ad_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ae_(Medication M)
            {
                object ai_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object aj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ak_ = context.Operators.Split((string)aj_, "/");
                string al_ = context.Operators.Last<string>(ak_);
                bool? am_ = context.Operators.Equal(ai_, al_);
                CodeableConcept an_ = M?.Code;
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, an_);
                CqlValueSet ap_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? aq_ = context.Operators.ConceptInValueSet(ao_, ap_);
                bool? ar_ = context.Operators.And(am_, aq_);

                return ar_;
            };
            IEnumerable<Medication> af_ = context.Operators.Where<Medication>(ad_, ae_);
            MedicationRequest ag_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ah_ = context.Operators.Select<Medication, MedicationRequest>(af_, ag_);

            return ah_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_(MedicationRequest MR)
        {
            IEnumerable<Medication> as_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? at_(Medication M)
            {
                object ax_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ay_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> az_ = context.Operators.Split((string)ay_, "/");
                string ba_ = context.Operators.Last<string>(az_);
                bool? bb_ = context.Operators.Equal(ax_, ba_);
                CodeableConcept bc_ = M?.Code;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                CqlValueSet be_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? bf_ = context.Operators.ConceptInValueSet(bd_, be_);
                bool? bg_ = context.Operators.And(bb_, bf_);

                return bg_;
            };
            IEnumerable<Medication> au_ = context.Operators.Where<Medication>(as_, at_);
            MedicationRequest av_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> aw_ = context.Operators.Select<Medication, MedicationRequest>(au_, av_);

            return aw_;
        };
        IEnumerable<MedicationRequest> k_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        IEnumerable<MedicationRequest> n_ = Status_1_8_000.Instance.isMedicationOrder(context, m_);
        IEnumerable<MedicationRequest> o_(MedicationRequest SUDMedication)
        {
            Encounter bh_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bi_ = [
                bh_,
            ];
            bool? bj_(Encounter FirstSUDEpisode)
            {
                FhirDateTime bn_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bo_ = context.Operators.Convert<CqlDateTime>(bn_);
                CqlInterval<CqlDateTime> bp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bo_ as object);
                CqlDateTime bq_ = context.Operators.Start(bp_);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                Period bs_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
                CqlInterval<CqlDateTime> bu_ = QICoreCommon_2_1_000.Instance.toInterval(context, bt_ as object);
                CqlDateTime bv_ = context.Operators.Start(bu_);
                CqlDate bw_ = context.Operators.DateFrom(bv_);
                CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
                CqlInterval<CqlDateTime> bz_ = QICoreCommon_2_1_000.Instance.toInterval(context, by_ as object);
                CqlDateTime ca_ = context.Operators.Start(bz_);
                CqlDate cb_ = context.Operators.DateFrom(ca_);
                CqlQuantity cc_ = context.Operators.Quantity(14m, "days");
                CqlDate cd_ = context.Operators.Add(cb_, cc_);
                CqlInterval<CqlDate> ce_ = context.Operators.Interval(bw_, cd_, true, false);
                bool? cf_ = context.Operators.In<CqlDate>(br_, ce_, default);

                return cf_;
            };
            IEnumerable<Encounter> bk_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)bi_, bj_);
            MedicationRequest bl_(Encounter FirstSUDEpisode) =>
                SUDMedication;
            IEnumerable<MedicationRequest> bm_ = context.Operators.Select<Encounter, MedicationRequest>(bk_, bl_);

            return bm_;
        };
        IEnumerable<MedicationRequest> p_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(n_, o_);
        CqlDate q_(MedicationRequest SUDMedication)
        {
            FhirDateTime cg_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime ch_ = context.Operators.Convert<CqlDateTime>(cg_);
            CqlInterval<CqlDateTime> ci_ = QICoreCommon_2_1_000.Instance.toInterval(context, ch_ as object);
            CqlDateTime cj_ = context.Operators.Start(ci_);
            CqlDate ck_ = context.Operators.DateFrom(cj_);

            return ck_;
        };
        IEnumerable<CqlDate> r_ = context.Operators.Select<MedicationRequest, CqlDate>(p_, q_);
        CqlValueSet s_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet u_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> w_ = context.Operators.Union<Procedure>(t_, v_);
        IEnumerable<Procedure> x_ = Status_1_8_000.Instance.isInterventionPerformed(context, w_);
        IEnumerable<Procedure> y_(Procedure SUDMedAdministration)
        {
            Encounter cl_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cm_ = [
                cl_,
            ];
            bool? cn_(Encounter FirstSUDEpisode)
            {
                DataType cr_ = SUDMedAdministration?.Performed;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                CqlInterval<CqlDateTime> ct_ = QICoreCommon_2_1_000.Instance.toInterval(context, cs_);
                CqlDateTime cu_ = context.Operators.Start(ct_);
                CqlDate cv_ = context.Operators.DateFrom(cu_);
                Period cw_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                CqlInterval<CqlDateTime> cy_ = QICoreCommon_2_1_000.Instance.toInterval(context, cx_ as object);
                CqlDateTime cz_ = context.Operators.Start(cy_);
                CqlDate da_ = context.Operators.DateFrom(cz_);
                CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                CqlInterval<CqlDateTime> dd_ = QICoreCommon_2_1_000.Instance.toInterval(context, dc_ as object);
                CqlDateTime de_ = context.Operators.Start(dd_);
                CqlDate df_ = context.Operators.DateFrom(de_);
                CqlQuantity dg_ = context.Operators.Quantity(14m, "days");
                CqlDate dh_ = context.Operators.Add(df_, dg_);
                CqlInterval<CqlDate> di_ = context.Operators.Interval(da_, dh_, true, false);
                bool? dj_ = context.Operators.In<CqlDate>(cv_, di_, default);

                return dj_;
            };
            IEnumerable<Encounter> co_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)cm_, cn_);
            Procedure cp_(Encounter FirstSUDEpisode) =>
                SUDMedAdministration;
            IEnumerable<Procedure> cq_ = context.Operators.Select<Encounter, Procedure>(co_, cp_);

            return cq_;
        };
        IEnumerable<Procedure> z_ = context.Operators.SelectMany<Procedure, Procedure>(x_, y_);
        CqlDate aa_(Procedure SUDMedAdministration)
        {
            DataType dk_ = SUDMedAdministration?.Performed;
            object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
            CqlInterval<CqlDateTime> dm_ = QICoreCommon_2_1_000.Instance.toInterval(context, dl_);
            CqlDateTime dn_ = context.Operators.Start(dm_);
            CqlDate do_ = context.Operators.DateFrom(dn_);

            return do_;
        };
        IEnumerable<CqlDate> ab_ = context.Operators.Select<Procedure, CqlDate>(z_, aa_);
        IEnumerable<CqlDate> ac_ = context.Operators.Union<CqlDate>(r_, ab_);

        return ac_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
        bool? b_ = context.Operators.Exists<CqlDate>(a_);
        IEnumerable<CqlDate> c_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
        bool? d_ = context.Operators.Exists<CqlDate>(c_);
        bool? e_ = context.Operators.Or(b_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Has Two or More Treatment Engagements With Short Acting Medication or Non Medication Intervention")]
    public bool? Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention(CqlContext context)
    {
        IEnumerable<object> a_ = this.Psychosocial_Visit(context);
        CqlValueSet b_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> d_ = Status_1_8_000.Instance.isInterventionPerformed(context, c_);
        IEnumerable<object> e_ = context.Operators.Union<object>(a_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_(object ShortActingTreatment)
        {
            IEnumerable<CqlDate> x_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> y_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> z_ = context.Operators.Union<CqlDate>(x_, y_);
            CqlDate aa_ = context.Operators.Min<CqlDate>(z_);
            CqlDate[] ab_ = [
                aa_,
            ];
            bool? ac_(CqlDate InitiationTreatmentDate)
            {
                object ag_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_2_1_000.Instance.toInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                CqlDate ak_ = context.Operators.DateFrom(aj_);
                CqlQuantity al_ = context.Operators.Quantity(34m, "days");
                CqlDate am_ = context.Operators.Add(InitiationTreatmentDate, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(InitiationTreatmentDate, am_, false, true);
                bool? ao_ = context.Operators.In<CqlDate>(ak_, an_, default);
                bool? ap_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? aq_ = context.Operators.And(ao_, ap_);
                object ar_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_ as Period);
                CqlInterval<CqlDateTime> at_ = QICoreCommon_2_1_000.Instance.toInterval(context, as_ as object);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlDate av_ = context.Operators.DateFrom(au_);
                CqlDate ax_ = context.Operators.Add(InitiationTreatmentDate, al_);
                CqlInterval<CqlDate> ay_ = context.Operators.Interval(InitiationTreatmentDate, ax_, false, true);
                bool? az_ = context.Operators.In<CqlDate>(av_, ay_, default);
                bool? bb_ = context.Operators.And(az_, ap_);
                bool? bc_ = context.Operators.Or(aq_, bb_);

                return bc_;
            };
            IEnumerable<CqlDate> ad_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)ab_, ac_);
            object ae_(CqlDate InitiationTreatmentDate) =>
                ShortActingTreatment;
            IEnumerable<object> af_ = context.Operators.Select<CqlDate, object>(ad_, ae_);

            return af_;
        };
        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);
        object h_(object ShortActingTreatment) =>
            ShortActingTreatment;
        IEnumerable<object> i_ = context.Operators.Select<object, object>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> m_(MedicationRequest MR)
        {
            IEnumerable<Medication> bd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? be_(Medication M)
            {
                object bi_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bk_ = context.Operators.Split((string)bj_, "/");
                string bl_ = context.Operators.Last<string>(bk_);
                bool? bm_ = context.Operators.Equal(bi_, bl_);
                CodeableConcept bn_ = M?.Code;
                CqlConcept bo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bn_);
                CqlValueSet bp_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? bq_ = context.Operators.ConceptInValueSet(bo_, bp_);
                bool? br_ = context.Operators.And(bm_, bq_);

                return br_;
            };
            IEnumerable<Medication> bf_ = context.Operators.Where<Medication>(bd_, be_);
            MedicationRequest bg_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> bh_ = context.Operators.Select<Medication, MedicationRequest>(bf_, bg_);

            return bh_;
        };
        IEnumerable<MedicationRequest> n_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(l_, m_);
        IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(k_, n_);
        IEnumerable<MedicationRequest> p_ = Status_1_8_000.Instance.isMedicationOrder(context, o_);
        IEnumerable<MedicationRequest> q_(MedicationRequest ShortActingMedOrder)
        {
            IEnumerable<CqlDate> bs_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> bt_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> bu_ = context.Operators.Union<CqlDate>(bs_, bt_);
            CqlDate bv_ = context.Operators.Min<CqlDate>(bu_);
            CqlDate[] bw_ = [
                bv_,
            ];
            bool? bx_(CqlDate InitiationTreatmentDate)
            {
                FhirDateTime cb_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime cc_ = context.Operators.Convert<CqlDateTime>(cb_);
                CqlInterval<CqlDateTime> cd_ = QICoreCommon_2_1_000.Instance.toInterval(context, cc_ as object);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlDate cf_ = context.Operators.DateFrom(ce_);
                CqlQuantity cg_ = context.Operators.Quantity(34m, "days");
                CqlDate ch_ = context.Operators.Add(InitiationTreatmentDate, cg_);
                CqlInterval<CqlDate> ci_ = context.Operators.Interval(InitiationTreatmentDate, ch_, false, true);
                bool? cj_ = context.Operators.In<CqlDate>(cf_, ci_, default);
                bool? ck_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? cl_ = context.Operators.And(cj_, ck_);

                return cl_;
            };
            IEnumerable<CqlDate> by_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)bw_, bx_);
            MedicationRequest bz_(CqlDate InitiationTreatmentDate) =>
                ShortActingMedOrder;
            IEnumerable<MedicationRequest> ca_ = context.Operators.Select<CqlDate, MedicationRequest>(by_, bz_);

            return ca_;
        };
        IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(p_, q_);
        MedicationRequest s_(MedicationRequest ShortActingMedOrder) =>
            ShortActingMedOrder;
        IEnumerable<MedicationRequest> t_ = context.Operators.Select<MedicationRequest, MedicationRequest>(r_, s_);
        IEnumerable<object> u_ = context.Operators.Union<object>(i_ as IEnumerable<object>, t_ as IEnumerable<object>);
        int? v_ = context.Operators.Count<object>(u_);
        bool? w_ = context.Operators.GreaterOrEqual(v_, 2);

        return w_;
    }


    [CqlExpressionDefinition("Has Treatment Engagement With Long Acting Medication")]
    public bool? Has_Treatment_Engagement_With_Long_Acting_Medication(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> q_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? r_(Medication M)
            {
                object v_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object w_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> x_ = context.Operators.Split((string)w_, "/");
                string y_ = context.Operators.Last<string>(x_);
                bool? z_ = context.Operators.Equal(v_, y_);
                CodeableConcept aa_ = M?.Code;
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                CqlValueSet ac_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                bool? ae_ = context.Operators.And(z_, ad_);

                return ae_;
            };
            IEnumerable<Medication> s_ = context.Operators.Where<Medication>(q_, r_);
            MedicationRequest t_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> u_ = context.Operators.Select<Medication, MedicationRequest>(s_, t_);

            return u_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_8_000.Instance.isMedicationOrder(context, f_);
        IEnumerable<MedicationRequest> h_(MedicationRequest LongActingMedOrder)
        {
            IEnumerable<CqlDate> af_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ag_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ah_ = context.Operators.Union<CqlDate>(af_, ag_);
            CqlDate ai_ = context.Operators.Min<CqlDate>(ah_);
            CqlDate[] aj_ = [
                ai_,
            ];
            bool? ak_(CqlDate InitiationTreatmentDate)
            {
                FhirDateTime ao_ = LongActingMedOrder?.AuthoredOnElement;
                CqlDateTime ap_ = context.Operators.Convert<CqlDateTime>(ao_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ap_ as object);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlDate as_ = context.Operators.DateFrom(ar_);
                CqlQuantity at_ = context.Operators.Quantity(34m, "days");
                CqlDate au_ = context.Operators.Add(InitiationTreatmentDate, at_);
                CqlInterval<CqlDate> av_ = context.Operators.Interval(InitiationTreatmentDate, au_, false, true);
                bool? aw_ = context.Operators.In<CqlDate>(as_, av_, default);
                bool? ax_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? ay_ = context.Operators.And(aw_, ax_);

                return ay_;
            };
            IEnumerable<CqlDate> al_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)aj_, ak_);
            MedicationRequest am_(CqlDate InitiationTreatmentDate) =>
                LongActingMedOrder;
            IEnumerable<MedicationRequest> an_ = context.Operators.Select<CqlDate, MedicationRequest>(al_, am_);

            return an_;
        };
        IEnumerable<MedicationRequest> i_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_8_000.Instance.isInterventionPerformed(context, k_);
        IEnumerable<Procedure> m_(Procedure LongActingTreatment)
        {
            IEnumerable<CqlDate> az_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ba_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> bb_ = context.Operators.Union<CqlDate>(az_, ba_);
            CqlDate bc_ = context.Operators.Min<CqlDate>(bb_);
            CqlDate[] bd_ = [
                bc_,
            ];
            bool? be_(CqlDate InitiationTreatmentDate)
            {
                DataType bi_ = LongActingTreatment?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_1_000.Instance.toInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlDate bm_ = context.Operators.DateFrom(bl_);
                CqlQuantity bn_ = context.Operators.Quantity(34m, "days");
                CqlDate bo_ = context.Operators.Add(InitiationTreatmentDate, bn_);
                CqlInterval<CqlDate> bp_ = context.Operators.Interval(InitiationTreatmentDate, bo_, false, true);
                bool? bq_ = context.Operators.In<CqlDate>(bm_, bp_, default);
                bool? br_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? bs_ = context.Operators.And(bq_, br_);

                return bs_;
            };
            IEnumerable<CqlDate> bf_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)bd_, be_);
            Procedure bg_(CqlDate InitiationTreatmentDate) =>
                LongActingTreatment;
            IEnumerable<Procedure> bh_ = context.Operators.Select<CqlDate, Procedure>(bf_, bg_);

            return bh_;
        };
        IEnumerable<Procedure> n_ = context.Operators.SelectMany<Procedure, Procedure>(l_, m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(i_ as IEnumerable<object>, n_ as IEnumerable<object>);
        bool? p_ = context.Operators.Exists<object>(o_);

        return p_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? a_ = this.Has_Treatment_Engagement_With_Long_Acting_Medication(context);
        bool? b_ = this.Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention(context);
        bool? c_ = context.Operators.Or(a_, b_);

        return c_;
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


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(13, 17, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(18, 64, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
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

        return i_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ = new(
      [typeof(CqlDate), typeof(Encounter)],
      ["ValidEncounterDate", "ValidEncounter"]);

    #endregion CqlTupleMetadata Properties

}
