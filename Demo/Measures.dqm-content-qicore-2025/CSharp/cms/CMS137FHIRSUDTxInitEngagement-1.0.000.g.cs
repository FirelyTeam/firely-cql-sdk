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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
            CqlValueSet k_ = this.Substance_Use_Disorder(context);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            Condition m_(Condition X) => X as Condition;
            IEnumerable<Condition> n_ = context.Operators.Select<Condition, Condition>(l_, m_);
            IEnumerable<Condition> o_ = Status_1_15_000.Instance.verified(context, n_);

            bool? p_(Condition SUDDiagnosis) {
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                Period t_ = ValidEncounters?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(s_, u_, (string)default);
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                CqlDateTime x_ = context.Operators.Start(w_);
                bool? y_ = context.Operators.In<CqlDateTime>(x_, u_, (string)default);
                bool? z_ = context.Operators.And(v_, y_);
                CqlDateTime aa_ = context.Operators.End(s_);
                CqlQuantity ab_ = context.Operators.Quantity(47m, "days");
                CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
                bool? ad_ = context.Operators.SameOrBefore(x_, ac_, "day");
                bool? ae_ = context.Operators.And(z_, ad_);
                return ae_;
            }

            IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
            bool? r_ = context.Operators.Exists<Condition>(q_);
            return r_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? d_(Encounter ValidEncounters) {
            Period af_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? aj_ = (CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ, ai_, ValidEncounters);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> e_ = context.Operators.Select<Encounter, (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(e_);

        object g_((CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? @this) {
            CqlDate ak_ = @this?.ValidEncounterDate;
            return ak_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> h_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? i_ = context.Operators.First<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(h_);
        Encounter j_ = i_?.ValidEncounter;
        return j_;
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
                object ar_;
                DataType bl_ = Interventions?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    DataType bo_ = Interventions?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    ar_ = bp_ as CqlDateTime;
                }
                else
                {
                    DataType bq_ = Interventions?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlInterval<CqlDateTime>;
                    if (bs_)
                    {
                        DataType bt_ = Interventions?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        ar_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bv_ = Interventions?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlQuantity;
                        if (bx_)
                        {
                            DataType by_ = Interventions?.Performed;
                            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                            ar_ = bz_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ca_ = Interventions?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            bool cc_ = cb_ is CqlInterval<CqlQuantity>;
                            if (cc_)
                            {
                                DataType cd_ = Interventions?.Performed;
                                object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                                ar_ = ce_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ar_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                Period au_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                CqlDate ax_ = context.Operators.DateFrom(aw_);
                CqlQuantity ay_ = context.Operators.Quantity(60m, "days");
                CqlDate az_ = context.Operators.Subtract(ax_, ay_);
                CqlInterval<CqlDate> ba_ = context.Operators.Interval(az_, ax_, true, false);
                CqlDate bb_ = ba_?.low;
                CqlDateTime bc_ = context.Operators.ConvertDateToDateTime(bb_);
                CqlDate bd_ = ba_?.high;
                CqlDateTime be_ = context.Operators.ConvertDateToDateTime(bd_);
                bool? bf_ = ba_?.lowClosed;
                bool? bg_ = ba_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(bc_, be_, bf_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(at_, bh_, "day");
                bool? bj_ = context.Operators.Not((bool?)(ax_ is null));
                bool? bk_ = context.Operators.And(bi_, bj_);
                return bk_;
            }

            IEnumerable<Encounter> ap_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)an_, ao_);
            bool? aq_ = context.Operators.Exists<Encounter>(ap_);
            return aq_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> p_ = this.Emergency_Department_or_Detoxification_Visit(context);
        IEnumerable<Encounter> q_ = context.Operators.Except<Encounter>(o_, p_);

        bool? r_(Encounter QualifyingEncounter) {
            IEnumerable<Condition> cf_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? cg_(Condition @this) {
                CodeableConcept cm_ = @this?.Code;
                CqlConcept cn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cm_);
                bool? co_ = context.Operators.Not((bool?)(cn_ is null));
                return co_;
            }

            IEnumerable<Condition> ch_ = context.Operators.Where<Condition>(cf_, cg_);

            CqlConcept ci_(Condition @this) {
                CodeableConcept cp_ = @this?.Code;
                CqlConcept cq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cp_);
                return cq_;
            }

            IEnumerable<CqlConcept> cj_ = context.Operators.Select<Condition, CqlConcept>(ch_, ci_);
            CqlValueSet ck_ = this.Substance_Use_Disorder(context);
            bool? cl_ = context.Operators.ConceptsInValueSet(cj_, ck_);
            return cl_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        bool? t_(Encounter SUDEncounterDx) {
            Encounter cr_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cs_ = [
                cr_,
            ];

            bool? ct_(Encounter FirstSUDEpisode) {
                Period cw_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                CqlDateTime cy_ = context.Operators.Start(cx_);
                Period cz_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cz_);
                CqlDateTime db_ = context.Operators.Start(da_);
                CqlDate dc_ = context.Operators.DateFrom(db_);
                CqlQuantity dd_ = context.Operators.Quantity(60m, "days");
                CqlDate de_ = context.Operators.Subtract(dc_, dd_);
                CqlInterval<CqlDate> df_ = context.Operators.Interval(de_, dc_, true, false);
                CqlDate dg_ = df_?.low;
                CqlDateTime dh_ = context.Operators.ConvertDateToDateTime(dg_);
                CqlDate di_ = df_?.high;
                CqlDateTime dj_ = context.Operators.ConvertDateToDateTime(di_);
                bool? dk_ = df_?.lowClosed;
                bool? dl_ = df_?.highClosed;
                CqlInterval<CqlDateTime> dm_ = context.Operators.Interval(dh_, dj_, dk_, dl_);
                bool? dn_ = context.Operators.In<CqlDateTime>(cy_, dm_, "day");
                bool? do_ = context.Operators.Not((bool?)(dc_ is null));
                bool? dp_ = context.Operators.And(dn_, do_);
                return dp_;
            }

            IEnumerable<Encounter> cu_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)cs_, ct_);
            bool? cv_ = context.Operators.Exists<Encounter>(cu_);
            return cv_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        CqlValueSet w_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? z_(MedicationRequest MR) {
            IEnumerable<Medication> dq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dr_(Medication M) {
                object du_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dw_ = context.Operators.Split((string)dv_, "/");
                string dx_ = context.Operators.Last<string>(dw_);
                bool? dy_ = context.Operators.Equal(du_, dx_);
                CodeableConcept dz_ = M?.Code;
                CqlConcept ea_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dz_);
                CqlValueSet eb_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? ec_ = context.Operators.ConceptInValueSet(ea_, eb_);
                bool? ed_ = context.Operators.And(dy_, ec_);
                return ed_;
            }

            IEnumerable<Medication> ds_ = context.Operators.Where<Medication>(dq_, dr_);
            bool? dt_ = context.Operators.Exists<Medication>(ds_);
            return dt_;
        }

        IEnumerable<MedicationRequest> aa_ = context.Operators.Where<MedicationRequest>(y_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(x_, aa_);
        CqlValueSet ac_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> ee_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ef_(Medication M) {
                object ei_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ej_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ek_ = context.Operators.Split((string)ej_, "/");
                string el_ = context.Operators.Last<string>(ek_);
                bool? em_ = context.Operators.Equal(ei_, el_);
                CodeableConcept en_ = M?.Code;
                CqlConcept eo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, en_);
                CqlValueSet ep_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? eq_ = context.Operators.ConceptInValueSet(eo_, ep_);
                bool? er_ = context.Operators.And(em_, eq_);
                return er_;
            }

            IEnumerable<Medication> eg_ = context.Operators.Where<Medication>(ee_, ef_);
            bool? eh_ = context.Operators.Exists<Medication>(eg_);
            return eh_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(y_, ae_);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ab_, ag_);
        IEnumerable<MedicationRequest> ai_ = Status_1_15_000.Instance.isMedicationOrder(context, ah_);

        bool? aj_(MedicationRequest SUDMedication) {
            Encounter es_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] et_ = [
                es_,
            ];

            bool? eu_(Encounter FirstSUDEpisode) {
                FhirDateTime ex_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime ey_ = context.Operators.Convert<CqlDateTime>(ex_);
                Period ez_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> fa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ez_);
                CqlDateTime fb_ = context.Operators.Start(fa_);
                CqlDate fc_ = context.Operators.DateFrom(fb_);
                CqlQuantity fd_ = context.Operators.Quantity(60m, "days");
                CqlDate fe_ = context.Operators.Subtract(fc_, fd_);
                CqlInterval<CqlDate> ff_ = context.Operators.Interval(fe_, fc_, true, false);
                CqlDate fg_ = ff_?.low;
                CqlDateTime fh_ = context.Operators.ConvertDateToDateTime(fg_);
                CqlDate fi_ = ff_?.high;
                CqlDateTime fj_ = context.Operators.ConvertDateToDateTime(fi_);
                bool? fk_ = ff_?.lowClosed;
                bool? fl_ = ff_?.highClosed;
                CqlInterval<CqlDateTime> fm_ = context.Operators.Interval(fh_, fj_, fk_, fl_);
                bool? fn_ = context.Operators.In<CqlDateTime>(ey_, fm_, "day");
                bool? fo_ = context.Operators.Not((bool?)(fc_ is null));
                bool? fp_ = context.Operators.And(fn_, fo_);
                return fp_;
            }

            IEnumerable<Encounter> ev_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)et_, eu_);
            bool? ew_ = context.Operators.Exists<Encounter>(ev_);
            return ew_;
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
                CodeableConcept w_ = @this?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                return y_;
            }

            IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);

            CqlConcept s_(Condition @this) {
                CodeableConcept z_ = @this?.Code;
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                return aa_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<Condition, CqlConcept>(r_, s_);
            CqlValueSet u_ = this.Substance_Use_Disorder(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
            return v_;
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
            Encounter k_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] l_ = [
                k_,
            ];

            bool? m_(Encounter FirstSUDEpisode) {
                object p_;
                object ai_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    object al_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    p_ = am_ as CqlDateTime;
                }
                else
                {
                    object an_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        object aq_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        p_ = ar_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object as_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlQuantity;
                        if (au_)
                        {
                            object av_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            p_ = aw_ as CqlQuantity;
                        }
                        else
                        {
                            object ax_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                            bool az_ = ay_ is CqlInterval<CqlQuantity>;
                            if (az_)
                            {
                                object ba_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                                p_ = bb_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                p_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlDate s_ = context.Operators.DateFrom(r_);
                Period t_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlDate w_ = context.Operators.DateFrom(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDate y_ = context.Operators.Add(w_, x_);
                CqlInterval<CqlDate> z_ = context.Operators.Interval(w_, y_, true, false);
                bool? aa_ = context.Operators.In<CqlDate>(s_, z_, (string)default);
                object ab_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "id");
                string ac_ = context.Operators.LateBoundProperty<string>(ab_, "value");
                Id ad_ = FirstSUDEpisode?.IdElement;
                string ae_ = ad_?.Value;
                bool? af_ = context.Operators.Equivalent(ac_, ae_);
                bool? ag_ = context.Operators.Not(af_);
                bool? ah_ = context.Operators.And(aa_, ag_);
                return ah_;
            }

            IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)l_, m_);
            bool? o_ = context.Operators.Exists<Encounter>(n_);
            return o_;
        }

        IEnumerable<object> c_ = context.Operators.Where<object>(a_, b_);

        CqlDate d_(object PsychosocialVisitProcedure) {
            object bc_;
            object bg_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
            bool bi_ = bh_ is CqlDateTime;
            if (bi_)
            {
                object bj_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                bc_ = bk_ as CqlDateTime;
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
                    bc_ = bp_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    object bq_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlQuantity;
                    if (bs_)
                    {
                        object bt_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        bc_ = bu_ as CqlQuantity;
                    }
                    else
                    {
                        object bv_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlInterval<CqlQuantity>;
                        if (bx_)
                        {
                            object by_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                            bc_ = bz_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
            CqlDateTime be_ = context.Operators.Start(bd_);
            CqlDate bf_ = context.Operators.DateFrom(be_);
            return bf_;
        }

        IEnumerable<CqlDate> e_ = context.Operators.Select<object, CqlDate>(c_, d_);

        bool? f_(object PsychosocialVisitEncounter) {
            Encounter ca_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cb_ = [
                ca_,
            ];

            bool? cc_(Encounter FirstSUDEpisode) {
                object cf_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cf_ as Period);
                CqlDateTime ch_ = context.Operators.Start(cg_);
                CqlDate ci_ = context.Operators.DateFrom(ch_);
                Period cj_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                CqlDateTime cl_ = context.Operators.Start(ck_);
                CqlDate cm_ = context.Operators.DateFrom(cl_);
                CqlQuantity cn_ = context.Operators.Quantity(14m, "days");
                CqlDate co_ = context.Operators.Add(cm_, cn_);
                CqlInterval<CqlDate> cp_ = context.Operators.Interval(cm_, co_, true, false);
                bool? cq_ = context.Operators.In<CqlDate>(ci_, cp_, (string)default);
                object cr_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                string cs_ = context.Operators.LateBoundProperty<string>(cr_, "value");
                Id ct_ = FirstSUDEpisode?.IdElement;
                string cu_ = ct_?.Value;
                bool? cv_ = context.Operators.Equivalent(cs_, cu_);
                bool? cw_ = context.Operators.Not(cv_);
                bool? cx_ = context.Operators.And(cq_, cw_);
                return cx_;
            }

            IEnumerable<Encounter> cd_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)cb_, cc_);
            bool? ce_ = context.Operators.Exists<Encounter>(cd_);
            return ce_;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(a_, f_);

        CqlDate h_(object PsychosocialVisitEncounter) {
            object cy_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_ as Period);
            CqlDateTime da_ = context.Operators.Start(cz_);
            CqlDate db_ = context.Operators.DateFrom(da_);
            return db_;
        }

        IEnumerable<CqlDate> i_ = context.Operators.Select<object, CqlDate>(g_, h_);
        IEnumerable<CqlDate> j_ = context.Operators.Union<CqlDate>(e_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Treatment Initiation With Medication Order Dates")]
    public IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Treatment_Initiation_With_Medication_Order_Dates, Treatment_Initiation_With_Medication_Order_Dates_Compute);

    private const long _cacheIndex_Treatment_Initiation_With_Medication_Order_Dates = -5155209491511971935L;

    private IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> ac_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ad_(Medication M) {
                object ag_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ah_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ai_ = context.Operators.Split((string)ah_, "/");
                string aj_ = context.Operators.Last<string>(ai_);
                bool? ak_ = context.Operators.Equal(ag_, aj_);
                CodeableConcept al_ = M?.Code;
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
                CqlValueSet an_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? ao_ = context.Operators.ConceptInValueSet(am_, an_);
                bool? ap_ = context.Operators.And(ak_, ao_);
                return ap_;
            }

            IEnumerable<Medication> ae_ = context.Operators.Where<Medication>(ac_, ad_);
            bool? af_ = context.Operators.Exists<Medication>(ae_);
            return af_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> aq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ar_(Medication M) {
                object au_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object av_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> aw_ = context.Operators.Split((string)av_, "/");
                string ax_ = context.Operators.Last<string>(aw_);
                bool? ay_ = context.Operators.Equal(au_, ax_);
                CodeableConcept az_ = M?.Code;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlValueSet bb_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
                bool? bd_ = context.Operators.And(ay_, bc_);
                return bd_;
            }

            IEnumerable<Medication> as_ = context.Operators.Where<Medication>(aq_, ar_);
            bool? at_ = context.Operators.Exists<Medication>(as_);
            return at_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(c_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        IEnumerable<MedicationRequest> m_ = Status_1_15_000.Instance.isMedicationOrder(context, l_);

        bool? n_(MedicationRequest SUDMedication) {
            Encounter be_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bf_ = [
                be_,
            ];

            bool? bg_(Encounter FirstSUDEpisode) {
                FhirDateTime bj_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
                CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlDate bn_ = context.Operators.DateFrom(bm_);
                Period bo_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                CqlDateTime bq_ = context.Operators.Start(bp_);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                CqlQuantity bs_ = context.Operators.Quantity(14m, "days");
                CqlDate bt_ = context.Operators.Add(br_, bs_);
                CqlInterval<CqlDate> bu_ = context.Operators.Interval(br_, bt_, true, false);
                bool? bv_ = context.Operators.In<CqlDate>(bn_, bu_, (string)default);
                return bv_;
            }

            IEnumerable<Encounter> bh_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)bf_, bg_);
            bool? bi_ = context.Operators.Exists<Encounter>(bh_);
            return bi_;
        }

        IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);

        CqlDate p_(MedicationRequest SUDMedication) {
            FhirDateTime bw_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime bx_ = context.Operators.Convert<CqlDateTime>(bw_);
            CqlInterval<CqlDateTime> by_ = QICoreCommon_4_0_000.Instance.toInterval(context, bx_);
            CqlDateTime bz_ = context.Operators.Start(by_);
            CqlDate ca_ = context.Operators.DateFrom(bz_);
            return ca_;
        }

        IEnumerable<CqlDate> q_ = context.Operators.Select<MedicationRequest, CqlDate>(o_, p_);
        CqlValueSet r_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> s_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet t_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> u_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> v_ = context.Operators.Union<Procedure>(s_, u_);
        IEnumerable<Procedure> w_ = Status_1_15_000.Instance.isProcedurePerformed(context, v_);

        bool? x_(Procedure SUDMedAdministration) {
            Encounter cb_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cc_ = [
                cb_,
            ];

            bool? cd_(Encounter FirstSUDEpisode) {
                object cg_;
                DataType cs_ = SUDMedAdministration?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool cu_ = ct_ is CqlDateTime;
                if (cu_)
                {
                    DataType cv_ = SUDMedAdministration?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    cg_ = cw_ as CqlDateTime;
                }
                else
                {
                    DataType cx_ = SUDMedAdministration?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    bool cz_ = cy_ is CqlInterval<CqlDateTime>;
                    if (cz_)
                    {
                        DataType da_ = SUDMedAdministration?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        cg_ = db_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dc_ = SUDMedAdministration?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlQuantity;
                        if (de_)
                        {
                            DataType df_ = SUDMedAdministration?.Performed;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            cg_ = dg_ as CqlQuantity;
                        }
                        else
                        {
                            DataType dh_ = SUDMedAdministration?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            bool dj_ = di_ is CqlInterval<CqlQuantity>;
                            if (dj_)
                            {
                                DataType dk_ = SUDMedAdministration?.Performed;
                                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                                cg_ = dl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cg_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, cg_);
                CqlDateTime ci_ = context.Operators.Start(ch_);
                CqlDate cj_ = context.Operators.DateFrom(ci_);
                Period ck_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.Start(cl_);
                CqlDate cn_ = context.Operators.DateFrom(cm_);
                CqlQuantity co_ = context.Operators.Quantity(14m, "days");
                CqlDate cp_ = context.Operators.Add(cn_, co_);
                CqlInterval<CqlDate> cq_ = context.Operators.Interval(cn_, cp_, true, false);
                bool? cr_ = context.Operators.In<CqlDate>(cj_, cq_, (string)default);
                return cr_;
            }

            IEnumerable<Encounter> ce_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)cc_, cd_);
            bool? cf_ = context.Operators.Exists<Encounter>(ce_);
            return cf_;
        }

        IEnumerable<Procedure> y_ = context.Operators.Where<Procedure>(w_, x_);

        CqlDate z_(Procedure SUDMedAdministration) {
            object dm_;
            DataType dq_ = SUDMedAdministration?.Performed;
            object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
            bool ds_ = dr_ is CqlDateTime;
            if (ds_)
            {
                DataType dt_ = SUDMedAdministration?.Performed;
                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                dm_ = du_ as CqlDateTime;
            }
            else
            {
                DataType dv_ = SUDMedAdministration?.Performed;
                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                if (dx_)
                {
                    DataType dy_ = SUDMedAdministration?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    dm_ = dz_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ea_ = SUDMedAdministration?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    bool ec_ = eb_ is CqlQuantity;
                    if (ec_)
                    {
                        DataType ed_ = SUDMedAdministration?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        dm_ = ee_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ef_ = SUDMedAdministration?.Performed;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        bool eh_ = eg_ is CqlInterval<CqlQuantity>;
                        if (eh_)
                        {
                            DataType ei_ = SUDMedAdministration?.Performed;
                            object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                            dm_ = ej_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dm_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dn_ = QICoreCommon_4_0_000.Instance.toInterval(context, dm_);
            CqlDateTime do_ = context.Operators.Start(dn_);
            CqlDate dp_ = context.Operators.DateFrom(do_);
            return dp_;
        }

        IEnumerable<CqlDate> aa_ = context.Operators.Select<Procedure, CqlDate>(y_, z_);
        IEnumerable<CqlDate> ab_ = context.Operators.Union<CqlDate>(q_, aa_);
        return ab_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -5625741812967658730L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
        bool? b_ = context.Operators.Exists<CqlDate>(a_);
        IEnumerable<CqlDate> c_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
        bool? d_ = context.Operators.Exists<CqlDate>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        return e_;
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
            IEnumerable<CqlDate> x_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> y_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> z_ = context.Operators.Union<CqlDate>(x_, y_);
            CqlDate aa_ = context.Operators.Min<CqlDate>(z_);
            CqlDate[] ab_ = [
                aa_,
            ];

            bool? ac_(CqlDate InitiationTreatmentDate) {
                object af_;
                object aw_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    object az_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    af_ = ba_ as CqlDateTime;
                }
                else
                {
                    object bb_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        object be_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        af_ = bf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object bg_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlQuantity;
                        if (bi_)
                        {
                            object bj_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            af_ = bk_ as CqlQuantity;
                        }
                        else
                        {
                            object bl_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bn_)
                            {
                                object bo_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                af_ = bp_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                af_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(34m, "days");
                CqlDate ak_ = context.Operators.Add(InitiationTreatmentDate, aj_);
                CqlInterval<CqlDate> al_ = context.Operators.Interval(InitiationTreatmentDate, ak_, false, true);
                bool? am_ = context.Operators.In<CqlDate>(ai_, al_, (string)default);
                bool? an_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? ao_ = context.Operators.And(am_, an_);
                object ap_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_ as Period);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlDate as_ = context.Operators.DateFrom(ar_);
                bool? at_ = context.Operators.In<CqlDate>(as_, al_, (string)default);
                bool? au_ = context.Operators.And(at_, an_);
                bool? av_ = context.Operators.Or(ao_, au_);
                return av_;
            }

            IEnumerable<CqlDate> ad_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)ab_, ac_);
            bool? ae_ = context.Operators.Exists<CqlDate>(ad_);
            return ae_;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
        object h_(object ShortActingTreatment) => ShortActingTreatment;
        IEnumerable<object> i_ = context.Operators.Select<object, object>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> bq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? br_(Medication M) {
                object bu_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bw_ = context.Operators.Split((string)bv_, "/");
                string bx_ = context.Operators.Last<string>(bw_);
                bool? by_ = context.Operators.Equal(bu_, bx_);
                CodeableConcept bz_ = M?.Code;
                CqlConcept ca_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bz_);
                CqlValueSet cb_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? cc_ = context.Operators.ConceptInValueSet(ca_, cb_);
                bool? cd_ = context.Operators.And(by_, cc_);
                return cd_;
            }

            IEnumerable<Medication> bs_ = context.Operators.Where<Medication>(bq_, br_);
            bool? bt_ = context.Operators.Exists<Medication>(bs_);
            return bt_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
        IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(k_, n_);
        IEnumerable<MedicationRequest> p_ = Status_1_15_000.Instance.isMedicationOrder(context, o_);

        bool? q_(MedicationRequest ShortActingMedOrder) {
            IEnumerable<CqlDate> ce_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> cf_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> cg_ = context.Operators.Union<CqlDate>(ce_, cf_);
            CqlDate ch_ = context.Operators.Min<CqlDate>(cg_);
            CqlDate[] ci_ = [
                ch_,
            ];

            bool? cj_(CqlDate InitiationTreatmentDate) {
                FhirDateTime cm_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime cn_ = context.Operators.Convert<CqlDateTime>(cm_);
                CqlInterval<CqlDateTime> co_ = QICoreCommon_4_0_000.Instance.toInterval(context, cn_);
                CqlDateTime cp_ = context.Operators.Start(co_);
                CqlDate cq_ = context.Operators.DateFrom(cp_);
                CqlQuantity cr_ = context.Operators.Quantity(34m, "days");
                CqlDate cs_ = context.Operators.Add(InitiationTreatmentDate, cr_);
                CqlInterval<CqlDate> ct_ = context.Operators.Interval(InitiationTreatmentDate, cs_, false, true);
                bool? cu_ = context.Operators.In<CqlDate>(cq_, ct_, (string)default);
                bool? cv_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? cw_ = context.Operators.And(cu_, cv_);
                return cw_;
            }

            IEnumerable<CqlDate> ck_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)ci_, cj_);
            bool? cl_ = context.Operators.Exists<CqlDate>(ck_);
            return cl_;
        }

        IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(p_, q_);
        MedicationRequest s_(MedicationRequest ShortActingMedOrder) => ShortActingMedOrder;
        IEnumerable<MedicationRequest> t_ = context.Operators.Select<MedicationRequest, MedicationRequest>(r_, s_);
        IEnumerable<object> u_ = context.Operators.Union<object>(i_ as IEnumerable<object>, t_ as IEnumerable<object>);
        int? v_ = context.Operators.Count<object>(u_);
        bool? w_ = context.Operators.GreaterOrEqual(v_, 2);
        return w_;
    }


    [CqlExpressionDefinition("Has Treatment Engagement With Long Acting Medication")]
    public bool? Has_Treatment_Engagement_With_Long_Acting_Medication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Treatment_Engagement_With_Long_Acting_Medication, Has_Treatment_Engagement_With_Long_Acting_Medication_Compute);

    private const long _cacheIndex_Has_Treatment_Engagement_With_Long_Acting_Medication = 664917922855669451L;

    private bool? Has_Treatment_Engagement_With_Long_Acting_Medication_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> q_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? r_(Medication M) {
                object u_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object v_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> w_ = context.Operators.Split((string)v_, "/");
                string x_ = context.Operators.Last<string>(w_);
                bool? y_ = context.Operators.Equal(u_, x_);
                CodeableConcept z_ = M?.Code;
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                CqlValueSet ab_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            }

            IEnumerable<Medication> s_ = context.Operators.Where<Medication>(q_, r_);
            bool? t_ = context.Operators.Exists<Medication>(s_);
            return t_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest LongActingMedOrder) {
            IEnumerable<CqlDate> ae_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> af_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ag_ = context.Operators.Union<CqlDate>(ae_, af_);
            CqlDate ah_ = context.Operators.Min<CqlDate>(ag_);
            CqlDate[] ai_ = [
                ah_,
            ];

            bool? aj_(CqlDate InitiationTreatmentDate) {
                FhirDateTime am_ = LongActingMedOrder?.AuthoredOnElement;
                CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(am_);
                CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlDate aq_ = context.Operators.DateFrom(ap_);
                CqlQuantity ar_ = context.Operators.Quantity(34m, "days");
                CqlDate as_ = context.Operators.Add(InitiationTreatmentDate, ar_);
                CqlInterval<CqlDate> at_ = context.Operators.Interval(InitiationTreatmentDate, as_, false, true);
                bool? au_ = context.Operators.In<CqlDate>(aq_, at_, (string)default);
                bool? av_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? aw_ = context.Operators.And(au_, av_);
                return aw_;
            }

            IEnumerable<CqlDate> ak_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)ai_, aj_);
            bool? al_ = context.Operators.Exists<CqlDate>(ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isProcedurePerformed(context, k_);

        bool? m_(Procedure LongActingTreatment) {
            IEnumerable<CqlDate> ax_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ay_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> az_ = context.Operators.Union<CqlDate>(ax_, ay_);
            CqlDate ba_ = context.Operators.Min<CqlDate>(az_);
            CqlDate[] bb_ = [
                ba_,
            ];

            bool? bc_(CqlDate InitiationTreatmentDate) {
                object bf_;
                DataType bp_ = LongActingTreatment?.Performed;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool br_ = bq_ is CqlDateTime;
                if (br_)
                {
                    DataType bs_ = LongActingTreatment?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bf_ = bt_ as CqlDateTime;
                }
                else
                {
                    DataType bu_ = LongActingTreatment?.Performed;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                    if (bw_)
                    {
                        DataType bx_ = LongActingTreatment?.Performed;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bf_ = by_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bz_ = LongActingTreatment?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlQuantity;
                        if (cb_)
                        {
                            DataType cc_ = LongActingTreatment?.Performed;
                            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                            bf_ = cd_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ce_ = LongActingTreatment?.Performed;
                            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                            bool cg_ = cf_ is CqlInterval<CqlQuantity>;
                            if (cg_)
                            {
                                DataType ch_ = LongActingTreatment?.Performed;
                                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                                bf_ = ci_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bf_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlDate bi_ = context.Operators.DateFrom(bh_);
                CqlQuantity bj_ = context.Operators.Quantity(34m, "days");
                CqlDate bk_ = context.Operators.Add(InitiationTreatmentDate, bj_);
                CqlInterval<CqlDate> bl_ = context.Operators.Interval(InitiationTreatmentDate, bk_, false, true);
                bool? bm_ = context.Operators.In<CqlDate>(bi_, bl_, (string)default);
                bool? bn_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? bo_ = context.Operators.And(bm_, bn_);
                return bo_;
            }

            IEnumerable<CqlDate> bd_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)bb_, bc_);
            bool? be_ = context.Operators.Exists<CqlDate>(bd_);
            return be_;
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
        bool? b_ = this.Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention(context);
        bool? c_ = context.Operators.Or(a_, b_);
        return c_;
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
