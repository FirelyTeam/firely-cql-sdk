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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
[CqlLibrary("CMS137FHIRSUDTxInitEngagement", "1.0.000")]
public partial class CMS137FHIRSUDTxInitEngagement_1_0_000 : ILibrary, ISingleton<CMS137FHIRSUDTxInitEngagement_1_0_000>
{
    #region ValueSets (15)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -213861832508738093L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS137FHIRSUDTxInitEngagement-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (22)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -1721097001566011548L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = 3378695002201602210L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
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
        IEnumerable<Encounter> x_ = Status_1_15_000.Instance.isEncounterPerformed(context, w_);
        return x_;
    }


    [CqlExpressionDefinition("First SUD Episode During Measurement Period")]
    public Encounter First_SUD_Episode_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_SUD_Episode_During_Measurement_Period, First_SUD_Episode_During_Measurement_Period_Compute);

    private const long _cacheIndex_First_SUD_Episode_During_Measurement_Period = 586250289999529460L;

    private Encounter First_SUD_Episode_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);

        bool? b_(Encounter ValidEncounters) {
            CqlValueSet j_ = this.Substance_Use_Disorder(context);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            Condition l_(Condition X) => X as Condition;
            IEnumerable<Condition> m_ = context.Operators.Select<Condition, Condition>(k_, l_);
            IEnumerable<Condition> n_ = Status_1_15_000.Instance.verified(context, m_);

            bool? o_(Condition SUDDiagnosis) {
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                Period r_ = ValidEncounters?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, (string)default);
                bool? u_;
                // CQL 'and' (41:19-42:84): right operand skipped when left is false
                if (t_ is false)
                {
                    u_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    Period x_ = ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                    bool? z_ = context.Operators.In<CqlDateTime>(w_, y_, (string)default);
                    u_ = t_ & z_;
                }
                // CQL 'and' (41:19-44:37): right operand skipped when left is false
                if (u_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
                    CqlDateTime ad_ = context.Operators.End(ac_);
                    CqlQuantity ae_ = context.Operators.Quantity(47m, "days");
                    CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
                    bool? ag_ = context.Operators.SameOrBefore(ab_, af_, "day");
                    return u_ & ag_;
                }
            }

            bool? p_ = context.Operators.WhereAny<Condition>(n_, o_);
            return p_;
        }


        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? c_(Encounter ValidEncounters) {
            Period ah_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);
            (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? al_ = (CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ, ak_, ValidEncounters);
            return al_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> d_ = context.Operators.WhereSelect<Encounter, (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(d_);

        object f_((CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? @this) {
            CqlDate am_ = @this?.ValidEncounterDate;
            return am_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> g_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? h_ = context.Operators.First<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(g_);
        Encounter i_ = h_?.ValidEncounter;
        return i_;
    }


    [CqlExpressionDefinition("Emergency Department or Detoxification Visit")]
    public IEnumerable<Encounter> Emergency_Department_or_Detoxification_Visit(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Emergency_Department_or_Detoxification_Visit, Emergency_Department_or_Detoxification_Visit_Compute);

    private const long _cacheIndex_Emergency_Department_or_Detoxification_Visit = 5050409531052435535L;

    private IEnumerable<Encounter> Emergency_Department_or_Detoxification_Visit_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Detoxification_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Encounter> f_ = Status_1_15_000.Instance.isEncounterPerformed(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("History of SUD Diagnosis or Treatment")]
    public IEnumerable<object> History_of_SUD_Diagnosis_or_Treatment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_History_of_SUD_Diagnosis_or_Treatment, History_of_SUD_Diagnosis_or_Treatment_Compute);

    private const long _cacheIndex_History_of_SUD_Diagnosis_or_Treatment = 1577389953795855491L;

    private IEnumerable<object> History_of_SUD_Diagnosis_or_Treatment_Compute(CqlContext context)
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
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isInterventionPerformed(context, k_);

        bool? m_(Procedure Interventions) {
            Encounter am_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] an_ = [
                am_,
            ];

            bool? ao_(Encounter FirstSUDEpisode) {
                object aq_;
                DataType bd_ = Interventions?.Performed;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                bool bf_ = be_ is CqlDateTime;
                if (bf_)
                {
                    DataType bg_ = Interventions?.Performed;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    aq_ = bh_ as CqlDateTime;
                }
                else
                {
                    DataType bi_ = Interventions?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlQuantity;
                    if (bk_)
                    {
                        DataType bl_ = Interventions?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        aq_ = bm_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bn_ = Interventions?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            DataType bq_ = Interventions?.Performed;
                            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                            aq_ = br_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bs_ = Interventions?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                            if (bu_)
                            {
                                DataType bv_ = Interventions?.Performed;
                                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                                aq_ = bw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                aq_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                Period at_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlDate aw_ = context.Operators.DateFrom(av_);
                CqlQuantity ax_ = context.Operators.Quantity(60m, "days");
                CqlDate ay_ = context.Operators.Subtract(aw_, ax_);
                CqlDateTime az_ = context.Operators.ConvertDateToDateTime(ay_);
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(aw_);
                CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(az_, ba_, true, false);
                bool? bc_ = context.Operators.In<CqlDateTime>(as_, bb_, "day");
                // CQL 'and' (70:19-70:135): right operand skipped when left is false
                if (bc_ is false)
                {
                    return false;
                }
                else
                {
                    Period bx_ = FirstSUDEpisode?.Period;
                    CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bx_);
                    CqlDateTime bz_ = context.Operators.Start(by_);
                    CqlDate ca_ = context.Operators.DateFrom(bz_);
                    return bc_ & (!((bool?)(ca_ is null)));
                }
            }

            bool? ap_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)an_, ao_);
            return ap_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> p_ = this.Emergency_Department_or_Detoxification_Visit(context);
        IEnumerable<Encounter> q_ = context.Operators.Except<Encounter>(o_, p_);

        bool? r_(Encounter QualifyingEncounter) {
            IEnumerable<Condition> cb_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? cc_(Condition @this) {
                CodeableConcept ch_ = @this?.Code;
                CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ch_);
                return !((bool?)(ci_ is null));
            }


            CqlConcept cd_(Condition @this) {
                CodeableConcept cj_ = @this?.Code;
                CqlConcept ck_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cj_);
                return ck_;
            }

            IEnumerable<CqlConcept> ce_ = context.Operators.WhereSelect<Condition, CqlConcept>(cb_, cc_, cd_);
            CqlValueSet cf_ = this.Substance_Use_Disorder(context);
            bool? cg_ = context.Operators.ConceptsInValueSet(ce_, cf_);
            return cg_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        bool? t_(Encounter SUDEncounterDx) {
            Encounter cl_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cm_ = [
                cl_,
            ];

            bool? cn_(Encounter FirstSUDEpisode) {
                Period cp_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                CqlDateTime cr_ = context.Operators.Start(cq_);
                Period cs_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                CqlDateTime cu_ = context.Operators.Start(ct_);
                CqlDate cv_ = context.Operators.DateFrom(cu_);
                CqlQuantity cw_ = context.Operators.Quantity(60m, "days");
                CqlDate cx_ = context.Operators.Subtract(cv_, cw_);
                CqlDateTime cy_ = context.Operators.ConvertDateToDateTime(cx_);
                CqlDateTime cz_ = context.Operators.ConvertDateToDateTime(cv_);
                CqlInterval<CqlDateTime> da_ = context.Operators.Interval(cy_, cz_, true, false);
                bool? db_ = context.Operators.In<CqlDateTime>(cr_, da_, "day");
                // CQL 'and' (76:21-76:120): right operand skipped when left is false
                if (db_ is false)
                {
                    return false;
                }
                else
                {
                    Period dc_ = FirstSUDEpisode?.Period;
                    CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                    CqlDateTime de_ = context.Operators.Start(dd_);
                    CqlDate df_ = context.Operators.DateFrom(de_);
                    return db_ & (!((bool?)(df_ is null)));
                }
            }

            bool? co_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)cm_, cn_);
            return co_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? x_(MedicationRequest MR) {
            IEnumerable<Medication> dg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dh_(Medication M) {
                object dj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dl_ = context.Operators.Split((string)dk_, "/");
                string dm_ = context.Operators.Last<string>(dl_);
                bool? dn_ = context.Operators.Equal(dj_, dm_);
                // CQL 'and': right operand skipped when left is false
                if (dn_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept do_ = M?.Code;
                    CqlConcept dp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, do_);
                    CqlValueSet dq_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                    bool? dr_ = context.Operators.ConceptInValueSet(dp_, dq_);
                    return dn_ & dr_;
                }
            }

            bool? di_ = context.Operators.WhereAny<Medication>(dg_, dh_);
            return di_;
        }

        IEnumerable<MedicationRequest> y_ = context.Operators.Where<MedicationRequest>(w_, x_);
        CqlValueSet z_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);

        bool? ac_(MedicationRequest MR) {
            IEnumerable<Medication> ds_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dt_(Medication M) {
                object dv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dx_ = context.Operators.Split((string)dw_, "/");
                string dy_ = context.Operators.Last<string>(dx_);
                bool? dz_ = context.Operators.Equal(dv_, dy_);
                // CQL 'and': right operand skipped when left is false
                if (dz_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept ea_ = M?.Code;
                    CqlConcept eb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ea_);
                    CqlValueSet ec_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                    bool? ed_ = context.Operators.ConceptInValueSet(eb_, ec_);
                    return dz_ & ed_;
                }
            }

            bool? du_ = context.Operators.WhereAny<Medication>(ds_, dt_);
            return du_;
        }

        IEnumerable<MedicationRequest> ad_ = context.Operators.Where<MedicationRequest>(w_, ac_);
        CqlValueSet ae_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ab_, ag_);
        IEnumerable<MedicationRequest> ai_ = Status_1_15_000.Instance.isMedicationOrder(context, ah_);

        bool? aj_(MedicationRequest SUDMedication) {
            Encounter ee_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ef_ = [
                ee_,
            ];

            bool? eg_(Encounter FirstSUDEpisode) {
                FhirDateTime ei_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime ej_ = context.Operators.Convert<CqlDateTime>(ei_);
                Period ek_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                CqlDateTime em_ = context.Operators.Start(el_);
                CqlDate en_ = context.Operators.DateFrom(em_);
                CqlQuantity eo_ = context.Operators.Quantity(60m, "days");
                CqlDate ep_ = context.Operators.Subtract(en_, eo_);
                CqlDateTime eq_ = context.Operators.ConvertDateToDateTime(ep_);
                CqlDateTime er_ = context.Operators.ConvertDateToDateTime(en_);
                CqlInterval<CqlDateTime> es_ = context.Operators.Interval(eq_, er_, true, false);
                bool? et_ = context.Operators.In<CqlDateTime>(ej_, es_, "day");
                // CQL 'and' (82:21-82:116): right operand skipped when left is false
                if (et_ is false)
                {
                    return false;
                }
                else
                {
                    Period eu_ = FirstSUDEpisode?.Period;
                    CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eu_);
                    CqlDateTime ew_ = context.Operators.Start(ev_);
                    CqlDate ex_ = context.Operators.DateFrom(ew_);
                    return et_ & (!((bool?)(ex_ is null)));
                }
            }

            bool? eh_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)ef_, eg_);
            return eh_;
        }

        IEnumerable<MedicationRequest> ak_ = context.Operators.Where<MedicationRequest>(ai_, aj_);
        IEnumerable<object> al_ = context.Operators.Union<object>(v_ as IEnumerable<object>, ak_ as IEnumerable<object>);
        return al_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -7114531631954589718L;

    private bool? Initial_Population_Compute(CqlContext context)
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
        bool? j_;
        // CQL 'and' (34:3-35:65): right operand skipped when left is false
        if (i_ is false)
        {
            j_ = false;
        }
        else
        {
            Encounter k_ = this.First_SUD_Episode_During_Measurement_Period(context);
            j_ = i_ & (!((bool?)(k_ is null)));
        }
        // CQL 'and' (34:3-36:58): right operand skipped when left is false
        if (j_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<object> l_ = this.History_of_SUD_Diagnosis_or_Treatment(context);
            bool? m_ = context.Operators.Exists<object>(l_);
            return j_ & !m_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -9046258412847076761L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2195821761694915090L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        return a_;
    }


    [CqlExpressionDefinition("Psychosocial Visit")]
    public IEnumerable<object> Psychosocial_Visit(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Psychosocial_Visit, Psychosocial_Visit_Compute);

    private const long _cacheIndex_Psychosocial_Visit = 5229788767688913214L;

    private IEnumerable<object> Psychosocial_Visit_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Treatment(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        IEnumerable<Procedure> f_ = Status_1_15_000.Instance.isInterventionPerformed(context, e_);
        CqlValueSet g_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet i_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter> l_ = Status_1_15_000.Instance.isEncounterPerformed(context, k_);

        bool? m_(Encounter TelehealthEncounter) {
            IEnumerable<Condition> p_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, TelehealthEncounter);

            bool? q_(Condition @this) {
                CodeableConcept v_ = @this?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                return !((bool?)(w_ is null));
            }


            CqlConcept r_(Condition @this) {
                CodeableConcept x_ = @this?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                return y_;
            }

            IEnumerable<CqlConcept> s_ = context.Operators.WhereSelect<Condition, CqlConcept>(p_, q_, r_);
            CqlValueSet t_ = this.Substance_Use_Disorder(context);
            bool? u_ = context.Operators.ConceptsInValueSet(s_, t_);
            return u_;
        }

        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(f_ as IEnumerable<object>, n_ as IEnumerable<object>);
        return o_;
    }


    [CqlExpressionDefinition("Treatment Initiation With Non Medication Intervention Dates")]
    public IEnumerable<CqlDate> Treatment_Initiation_With_Non_Medication_Intervention_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Treatment_Initiation_With_Non_Medication_Intervention_Dates, Treatment_Initiation_With_Non_Medication_Intervention_Dates_Compute);

    private const long _cacheIndex_Treatment_Initiation_With_Non_Medication_Intervention_Dates = -3291394688854868864L;

    private IEnumerable<CqlDate> Treatment_Initiation_With_Non_Medication_Intervention_Dates_Compute(CqlContext context)
    {
        IEnumerable<object> a_ = this.Psychosocial_Visit(context);

        bool? b_(object PsychosocialVisitProcedure) {
            Encounter i_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] j_ = [
                i_,
            ];

            bool? k_(Encounter FirstSUDEpisode) {
                object m_;
                object y_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    object ab_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    m_ = ac_ as CqlDateTime;
                }
                else
                {
                    object ad_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlQuantity;
                    if (af_)
                    {
                        object ag_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        m_ = ah_ as CqlQuantity;
                    }
                    else
                    {
                        object ai_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            object al_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            m_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object an_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                object aq_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                m_ = ar_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                m_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlDate p_ = context.Operators.DateFrom(o_);
                Period q_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlDate t_ = context.Operators.DateFrom(s_);
                CqlQuantity u_ = context.Operators.Quantity(14m, "days");
                CqlDate v_ = context.Operators.Add(t_, u_);
                CqlInterval<CqlDate> w_ = context.Operators.Interval(t_, v_, true, false);
                bool? x_ = context.Operators.In<CqlDate>(p_, w_, (string)default);
                // CQL 'and' (104:19-105:65): right operand skipped when left is false
                if (x_ is false)
                {
                    return false;
                }
                else
                {
                    object as_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "id");
                    string at_ = context.Operators.LateBoundProperty<string>(as_, "value");
                    Id au_ = FirstSUDEpisode?.IdElement;
                    string av_ = au_?.Value;
                    bool? aw_ = context.Operators.Equivalent(at_, av_);
                    return x_ & !aw_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)j_, k_);
            return l_;
        }


        CqlDate c_(object PsychosocialVisitProcedure) {
            object ax_;
            object bb_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                object be_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                ax_ = bf_ as CqlDateTime;
            }
            else
            {
                object bg_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlQuantity;
                if (bi_)
                {
                    object bj_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    ax_ = bk_ as CqlQuantity;
                }
                else
                {
                    object bl_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                    if (bn_)
                    {
                        object bo_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        ax_ = bp_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object bq_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            object bt_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            ax_ = bu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ax_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
            CqlDateTime az_ = context.Operators.Start(ay_);
            CqlDate ba_ = context.Operators.DateFrom(az_);
            return ba_;
        }

        IEnumerable<CqlDate> d_ = context.Operators.WhereSelect<object, CqlDate>(a_, b_, c_);

        bool? e_(object PsychosocialVisitEncounter) {
            Encounter bv_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bw_ = [
                bv_,
            ];

            bool? bx_(Encounter FirstSUDEpisode) {
                object bz_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_ as Period);
                CqlDateTime cb_ = context.Operators.Start(ca_);
                CqlDate cc_ = context.Operators.DateFrom(cb_);
                Period cd_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                CqlDate cg_ = context.Operators.DateFrom(cf_);
                CqlQuantity ch_ = context.Operators.Quantity(14m, "days");
                CqlDate ci_ = context.Operators.Add(cg_, ch_);
                CqlInterval<CqlDate> cj_ = context.Operators.Interval(cg_, ci_, true, false);
                bool? ck_ = context.Operators.In<CqlDate>(cc_, cj_, (string)default);
                // CQL 'and' (111:21-112:67): right operand skipped when left is false
                if (ck_ is false)
                {
                    return false;
                }
                else
                {
                    object cl_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                    string cm_ = context.Operators.LateBoundProperty<string>(cl_, "value");
                    Id cn_ = FirstSUDEpisode?.IdElement;
                    string co_ = cn_?.Value;
                    bool? cp_ = context.Operators.Equivalent(cm_, co_);
                    return ck_ & !cp_;
                }
            }

            bool? by_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bw_, bx_);
            return by_;
        }


        CqlDate f_(object PsychosocialVisitEncounter) {
            object cq_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_ as Period);
            CqlDateTime cs_ = context.Operators.Start(cr_);
            CqlDate ct_ = context.Operators.DateFrom(cs_);
            return ct_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.WhereSelect<object, CqlDate>(a_, e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Union<CqlDate>(d_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Treatment Initiation With Medication Order Dates")]
    public IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Treatment_Initiation_With_Medication_Order_Dates, Treatment_Initiation_With_Medication_Order_Dates_Compute);

    private const long _cacheIndex_Treatment_Initiation_With_Medication_Order_Dates = -5155209491511971935L;

    private IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> aa_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ab_(Medication M) {
                object ad_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ae_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> af_ = context.Operators.Split((string)ae_, "/");
                string ag_ = context.Operators.Last<string>(af_);
                bool? ah_ = context.Operators.Equal(ad_, ag_);
                // CQL 'and': right operand skipped when left is false
                if (ah_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept ai_ = M?.Code;
                    CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ai_);
                    CqlValueSet ak_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                    bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                    return ah_ & al_;
                }
            }

            bool? ac_ = context.Operators.WhereAny<Medication>(aa_, ab_);
            return ac_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> am_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? an_(Medication M) {
                object ap_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object aq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ar_ = context.Operators.Split((string)aq_, "/");
                string as_ = context.Operators.Last<string>(ar_);
                bool? at_ = context.Operators.Equal(ap_, as_);
                // CQL 'and': right operand skipped when left is false
                if (at_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept au_ = M?.Code;
                    CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, au_);
                    CqlValueSet aw_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                    bool? ax_ = context.Operators.ConceptInValueSet(av_, aw_);
                    return at_ & ax_;
                }
            }

            bool? ao_ = context.Operators.WhereAny<Medication>(am_, an_);
            return ao_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        IEnumerable<MedicationRequest> m_ = Status_1_15_000.Instance.isMedicationOrder(context, l_);

        bool? n_(MedicationRequest SUDMedication) {
            Encounter ay_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] az_ = [
                ay_,
            ];

            bool? ba_(Encounter FirstSUDEpisode) {
                FhirDateTime bc_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bd_ = context.Operators.Convert<CqlDateTime>(bc_);
                CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                CqlDateTime bf_ = context.Operators.Start(be_);
                CqlDate bg_ = context.Operators.DateFrom(bf_);
                Period bh_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                CqlDate bk_ = context.Operators.DateFrom(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(14m, "days");
                CqlDate bm_ = context.Operators.Add(bk_, bl_);
                CqlInterval<CqlDate> bn_ = context.Operators.Interval(bk_, bm_, true, false);
                bool? bo_ = context.Operators.In<CqlDate>(bg_, bn_, (string)default);
                return bo_;
            }

            bool? bb_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)az_, ba_);
            return bb_;
        }


        CqlDate o_(MedicationRequest SUDMedication) {
            FhirDateTime bp_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime bq_ = context.Operators.Convert<CqlDateTime>(bp_);
            CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
            CqlDateTime bs_ = context.Operators.Start(br_);
            CqlDate bt_ = context.Operators.DateFrom(bs_);
            return bt_;
        }

        IEnumerable<CqlDate> p_ = context.Operators.WhereSelect<MedicationRequest, CqlDate>(m_, n_, o_);
        CqlValueSet q_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet s_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
        IEnumerable<Procedure> v_ = Status_1_15_000.Instance.isProcedurePerformed(context, u_);

        bool? w_(Procedure SUDMedAdministration) {
            Encounter bu_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bv_ = [
                bu_,
            ];

            bool? bw_(Encounter FirstSUDEpisode) {
                object by_;
                DataType ck_ = SUDMedAdministration?.Performed;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                bool cm_ = cl_ is CqlDateTime;
                if (cm_)
                {
                    DataType cn_ = SUDMedAdministration?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    by_ = co_ as CqlDateTime;
                }
                else
                {
                    DataType cp_ = SUDMedAdministration?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlQuantity;
                    if (cr_)
                    {
                        DataType cs_ = SUDMedAdministration?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        by_ = ct_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cu_ = SUDMedAdministration?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                        if (cw_)
                        {
                            DataType cx_ = SUDMedAdministration?.Performed;
                            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                            by_ = cy_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cz_ = SUDMedAdministration?.Performed;
                            object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                            bool db_ = da_ is CqlInterval<CqlQuantity>;
                            if (db_)
                            {
                                DataType dc_ = SUDMedAdministration?.Performed;
                                object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                                by_ = dd_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                by_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bz_ = QICoreCommon_4_0_000.Instance.toInterval(context, by_);
                CqlDateTime ca_ = context.Operators.Start(bz_);
                CqlDate cb_ = context.Operators.DateFrom(ca_);
                Period cc_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlDate cf_ = context.Operators.DateFrom(ce_);
                CqlQuantity cg_ = context.Operators.Quantity(14m, "days");
                CqlDate ch_ = context.Operators.Add(cf_, cg_);
                CqlInterval<CqlDate> ci_ = context.Operators.Interval(cf_, ch_, true, false);
                bool? cj_ = context.Operators.In<CqlDate>(cb_, ci_, (string)default);
                return cj_;
            }

            bool? bx_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bv_, bw_);
            return bx_;
        }


        CqlDate x_(Procedure SUDMedAdministration) {
            object de_;
            DataType di_ = SUDMedAdministration?.Performed;
            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
            bool dk_ = dj_ is CqlDateTime;
            if (dk_)
            {
                DataType dl_ = SUDMedAdministration?.Performed;
                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                de_ = dm_ as CqlDateTime;
            }
            else
            {
                DataType dn_ = SUDMedAdministration?.Performed;
                object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                bool dp_ = do_ is CqlQuantity;
                if (dp_)
                {
                    DataType dq_ = SUDMedAdministration?.Performed;
                    object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    de_ = dr_ as CqlQuantity;
                }
                else
                {
                    DataType ds_ = SUDMedAdministration?.Performed;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    bool du_ = dt_ is CqlInterval<CqlDateTime>;
                    if (du_)
                    {
                        DataType dv_ = SUDMedAdministration?.Performed;
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        de_ = dw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dx_ = SUDMedAdministration?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        bool dz_ = dy_ is CqlInterval<CqlQuantity>;
                        if (dz_)
                        {
                            DataType ea_ = SUDMedAdministration?.Performed;
                            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                            de_ = eb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            de_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_);
            CqlDateTime dg_ = context.Operators.Start(df_);
            CqlDate dh_ = context.Operators.DateFrom(dg_);
            return dh_;
        }

        IEnumerable<CqlDate> y_ = context.Operators.WhereSelect<Procedure, CqlDate>(v_, w_, x_);
        IEnumerable<CqlDate> z_ = context.Operators.Union<CqlDate>(p_, y_);
        return z_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -5625741812967658730L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
        bool? b_ = context.Operators.Exists<CqlDate>(a_);
        // CQL 'or' (97:3-98:64): right operand skipped when left is true
        if (b_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<CqlDate> c_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            bool? d_ = context.Operators.Exists<CqlDate>(c_);
            return b_ | d_;
        }
    }


    [CqlExpressionDefinition("Has Two or More Treatment Engagements With Short Acting Medication or Non Medication Intervention")]
    public bool? Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention, Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention_Compute);

    private const long _cacheIndex_Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention = 8416184830860607988L;

    private bool? Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention_Compute(CqlContext context)
    {
        IEnumerable<object> a_ = this.Psychosocial_Visit(context);
        CqlValueSet b_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> d_ = Status_1_15_000.Instance.isProcedurePerformed(context, c_);
        IEnumerable<object> e_ = context.Operators.Union<object>(a_ as IEnumerable<object>, d_ as IEnumerable<object>);

        bool? f_(object ShortActingTreatment) {
            IEnumerable<CqlDate> v_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> w_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> x_ = context.Operators.Union<CqlDate>(v_, w_);
            CqlDate y_ = context.Operators.Min<CqlDate>(x_);
            CqlDate[] z_ = [
                y_,
            ];

            bool? aa_(CqlDate InitiationTreatmentDate) {
                object ac_;
                object al_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    object ao_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    ac_ = ap_ as CqlDateTime;
                }
                else
                {
                    object aq_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlQuantity;
                    if (as_)
                    {
                        object at_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        ac_ = au_ as CqlQuantity;
                    }
                    else
                    {
                        object av_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            object ay_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            ac_ = az_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object ba_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                            if (bc_)
                            {
                                object bd_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                                ac_ = be_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ac_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(34m, "days");
                CqlDate ah_ = context.Operators.Add(InitiationTreatmentDate, ag_);
                CqlInterval<CqlDate> ai_ = context.Operators.Interval(InitiationTreatmentDate, ah_, false, true);
                bool? aj_ = context.Operators.In<CqlDate>(af_, ai_, (string)default);
                bool? ak_ = /* CQL 'and' (150:21-150:128) */ (aj_ is false
                    ? false
                    : aj_ & (!((bool?)(InitiationTreatmentDate is null))));
                // CQL 'or' (150:21-151:107): right operand skipped when left is true
                if (ak_ is true)
                {
                    return true;
                }
                else
                {
                    object bf_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
                    CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_ as Period);
                    CqlDateTime bh_ = context.Operators.Start(bg_);
                    CqlDate bi_ = context.Operators.DateFrom(bh_);
                    CqlQuantity bj_ = context.Operators.Quantity(34m, "days");
                    CqlDate bk_ = context.Operators.Add(InitiationTreatmentDate, bj_);
                    CqlInterval<CqlDate> bl_ = context.Operators.Interval(InitiationTreatmentDate, bk_, false, true);
                    bool? bm_ = context.Operators.In<CqlDate>(bi_, bl_, (string)default);
                    return ak_ | (/* CQL 'and' (151:16-151:107) */ (bm_ is false
                        ? false
                        : bm_ & (!((bool?)(InitiationTreatmentDate is null)))));
                }
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)z_, aa_);
            return ab_;
        }

        object g_(object ShortActingTreatment) => ShortActingTreatment;
        IEnumerable<object> h_ = context.Operators.WhereSelect<object, object>(e_, f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? j_(MedicationRequest MR) {
            IEnumerable<Medication> bn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bo_(Medication M) {
                object bq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object br_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bs_ = context.Operators.Split((string)br_, "/");
                string bt_ = context.Operators.Last<string>(bs_);
                bool? bu_ = context.Operators.Equal(bq_, bt_);
                // CQL 'and': right operand skipped when left is false
                if (bu_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bv_ = M?.Code;
                    CqlConcept bw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bv_);
                    CqlValueSet bx_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                    bool? by_ = context.Operators.ConceptInValueSet(bw_, bx_);
                    return bu_ & by_;
                }
            }

            bool? bp_ = context.Operators.WhereAny<Medication>(bn_, bo_);
            return bp_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
        CqlValueSet l_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);
        IEnumerable<MedicationRequest> o_ = Status_1_15_000.Instance.isMedicationOrder(context, n_);

        bool? p_(MedicationRequest ShortActingMedOrder) {
            IEnumerable<CqlDate> bz_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ca_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> cb_ = context.Operators.Union<CqlDate>(bz_, ca_);
            CqlDate cc_ = context.Operators.Min<CqlDate>(cb_);
            CqlDate[] cd_ = [
                cc_,
            ];

            bool? ce_(CqlDate InitiationTreatmentDate) {
                FhirDateTime cg_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime ch_ = context.Operators.Convert<CqlDateTime>(cg_);
                CqlInterval<CqlDateTime> ci_ = QICoreCommon_4_0_000.Instance.toInterval(context, ch_);
                CqlDateTime cj_ = context.Operators.Start(ci_);
                CqlDate ck_ = context.Operators.DateFrom(cj_);
                CqlQuantity cl_ = context.Operators.Quantity(34m, "days");
                CqlDate cm_ = context.Operators.Add(InitiationTreatmentDate, cl_);
                CqlInterval<CqlDate> cn_ = context.Operators.Interval(InitiationTreatmentDate, cm_, false, true);
                bool? co_ = context.Operators.In<CqlDate>(ck_, cn_, (string)default);
                return /* CQL 'and' (158:23-158:130) */ (co_ is false
                    ? false
                    : co_ & (!((bool?)(InitiationTreatmentDate is null))));
            }

            bool? cf_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)cd_, ce_);
            return cf_;
        }

        MedicationRequest q_(MedicationRequest ShortActingMedOrder) => ShortActingMedOrder;
        IEnumerable<MedicationRequest> r_ = context.Operators.WhereSelect<MedicationRequest, MedicationRequest>(o_, p_, q_);
        IEnumerable<object> s_ = context.Operators.Union<object>(h_ as IEnumerable<object>, r_ as IEnumerable<object>);
        int? t_ = context.Operators.Count<object>(s_);
        bool? u_ = context.Operators.GreaterOrEqual(t_, 2);
        return u_;
    }


    [CqlExpressionDefinition("Has Treatment Engagement With Long Acting Medication")]
    public bool? Has_Treatment_Engagement_With_Long_Acting_Medication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Treatment_Engagement_With_Long_Acting_Medication, Has_Treatment_Engagement_With_Long_Acting_Medication_Compute);

    private const long _cacheIndex_Has_Treatment_Engagement_With_Long_Acting_Medication = 664917922855669451L;

    private bool? Has_Treatment_Engagement_With_Long_Acting_Medication_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> q_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? r_(Medication M) {
                object t_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object u_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> v_ = context.Operators.Split((string)u_, "/");
                string w_ = context.Operators.Last<string>(v_);
                bool? x_ = context.Operators.Equal(t_, w_);
                // CQL 'and': right operand skipped when left is false
                if (x_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept y_ = M?.Code;
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                    CqlValueSet aa_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                    bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                    return x_ & ab_;
                }
            }

            bool? s_ = context.Operators.WhereAny<Medication>(q_, r_);
            return s_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest LongActingMedOrder) {
            IEnumerable<CqlDate> ac_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ad_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ae_ = context.Operators.Union<CqlDate>(ac_, ad_);
            CqlDate af_ = context.Operators.Min<CqlDate>(ae_);
            CqlDate[] ag_ = [
                af_,
            ];

            bool? ah_(CqlDate InitiationTreatmentDate) {
                FhirDateTime aj_ = LongActingMedOrder?.AuthoredOnElement;
                CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(aj_);
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
                CqlDateTime am_ = context.Operators.Start(al_);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlQuantity ao_ = context.Operators.Quantity(34m, "days");
                CqlDate ap_ = context.Operators.Add(InitiationTreatmentDate, ao_);
                CqlInterval<CqlDate> aq_ = context.Operators.Interval(InitiationTreatmentDate, ap_, false, true);
                bool? ar_ = context.Operators.In<CqlDate>(an_, aq_, (string)default);
                return /* CQL 'and' (172:21-172:129) */ (ar_ is false
                    ? false
                    : ar_ & (!((bool?)(InitiationTreatmentDate is null))));
            }

            bool? ai_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)ag_, ah_);
            return ai_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isProcedurePerformed(context, k_);

        bool? m_(Procedure LongActingTreatment) {
            IEnumerable<CqlDate> as_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> at_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> au_ = context.Operators.Union<CqlDate>(as_, at_);
            CqlDate av_ = context.Operators.Min<CqlDate>(au_);
            CqlDate[] aw_ = [
                av_,
            ];

            bool? ax_(CqlDate InitiationTreatmentDate) {
                object az_;
                DataType bh_ = LongActingTreatment?.Performed;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = LongActingTreatment?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    az_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = LongActingTreatment?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlQuantity;
                    if (bo_)
                    {
                        DataType bp_ = LongActingTreatment?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        az_ = bq_ as CqlQuantity;
                    }
                    else
                    {
                        DataType br_ = LongActingTreatment?.Performed;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType bu_ = LongActingTreatment?.Performed;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            az_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bw_ = LongActingTreatment?.Performed;
                            object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                            bool by_ = bx_ is CqlInterval<CqlQuantity>;
                            if (by_)
                            {
                                DataType bz_ = LongActingTreatment?.Performed;
                                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                                az_ = ca_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                az_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                CqlDate bc_ = context.Operators.DateFrom(bb_);
                CqlQuantity bd_ = context.Operators.Quantity(34m, "days");
                CqlDate be_ = context.Operators.Add(InitiationTreatmentDate, bd_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(InitiationTreatmentDate, be_, false, true);
                bool? bg_ = context.Operators.In<CqlDate>(bc_, bf_, (string)default);
                return /* CQL 'and' (178:23-178:131) */ (bg_ is false
                    ? false
                    : bg_ & (!((bool?)(InitiationTreatmentDate is null))));
            }

            bool? ay_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)aw_, ax_);
            return ay_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(i_ as IEnumerable<object>, n_ as IEnumerable<object>);
        bool? p_ = context.Operators.Exists<object>(o_);
        return p_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = 1834938210783437317L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Treatment_Engagement_With_Long_Acting_Medication(context);
        // CQL 'or' (164:3-165:106): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 6418437819993636238L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8205811437225639691L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -6782451795594240210L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 1868441466622731252L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = -4824117620333877211L;

    private bool? Stratification_1_Compute(CqlContext context)
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
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -8456206768832357499L;

    private bool? Stratification_2_Compute(CqlContext context)
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
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private const long _cacheIndex_Stratification_3 = 9122996230781459201L;

    private bool? Stratification_3_Compute(CqlContext context)
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

    #region Singleton Lifetime Members

    private CMS137FHIRSUDTxInitEngagement_1_0_000() {}

    public static CMS137FHIRSUDTxInitEngagement_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS137FHIRSUDTxInitEngagement";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ = new(
       [typeof(CqlDate), typeof(Encounter)],
       ["ValidEncounterDate", "ValidEncounter"]);

    #endregion CqlTupleMetadata Properties

}
