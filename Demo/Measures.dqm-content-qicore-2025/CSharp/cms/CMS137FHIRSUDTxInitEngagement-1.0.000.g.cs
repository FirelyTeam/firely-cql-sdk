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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
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

                object ar_() {

                    bool bl_() {
                        DataType bp_ = Interventions?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlDateTime;
                        return br_;
                    }


                    bool bm_() {
                        DataType bs_ = Interventions?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlDateTime>;
                        return bu_;
                    }


                    bool bn_() {
                        DataType bv_ = Interventions?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlQuantity;
                        return bx_;
                    }


                    bool bo_() {
                        DataType by_ = Interventions?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlInterval<CqlQuantity>;
                        return ca_;
                    }

                    if (bl_())
                    {
                        DataType cb_ = Interventions?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        return cc_ as CqlDateTime;
                    }
                    else if (bm_())
                    {
                        DataType cd_ = Interventions?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        return ce_ as CqlInterval<CqlDateTime>;
                    }
                    else if (bn_())
                    {
                        DataType cf_ = Interventions?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        return cg_ as CqlQuantity;
                    }
                    else if (bo_())
                    {
                        DataType ch_ = Interventions?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        return ci_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_());
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
            IEnumerable<Condition> cj_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? ck_(Condition @this) {
                CodeableConcept cq_ = @this?.Code;
                CqlConcept cr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cq_);
                bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                return cs_;
            }

            IEnumerable<Condition> cl_ = context.Operators.Where<Condition>(cj_, ck_);

            CqlConcept cm_(Condition @this) {
                CodeableConcept ct_ = @this?.Code;
                CqlConcept cu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ct_);
                return cu_;
            }

            IEnumerable<CqlConcept> cn_ = context.Operators.Select<Condition, CqlConcept>(cl_, cm_);
            CqlValueSet co_ = this.Substance_Use_Disorder(context);
            bool? cp_ = context.Operators.ConceptsInValueSet(cn_, co_);
            return cp_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        bool? t_(Encounter SUDEncounterDx) {
            Encounter cv_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cw_ = [
                cv_,
            ];

            bool? cx_(Encounter FirstSUDEpisode) {
                Period da_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, da_);
                CqlDateTime dc_ = context.Operators.Start(db_);
                Period dd_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dd_);
                CqlDateTime df_ = context.Operators.Start(de_);
                CqlDate dg_ = context.Operators.DateFrom(df_);
                CqlQuantity dh_ = context.Operators.Quantity(60m, "days");
                CqlDate di_ = context.Operators.Subtract(dg_, dh_);
                CqlInterval<CqlDate> dj_ = context.Operators.Interval(di_, dg_, true, false);
                CqlDate dk_ = dj_?.low;
                CqlDateTime dl_ = context.Operators.ConvertDateToDateTime(dk_);
                CqlDate dm_ = dj_?.high;
                CqlDateTime dn_ = context.Operators.ConvertDateToDateTime(dm_);
                bool? do_ = dj_?.lowClosed;
                bool? dp_ = dj_?.highClosed;
                CqlInterval<CqlDateTime> dq_ = context.Operators.Interval(dl_, dn_, do_, dp_);
                bool? dr_ = context.Operators.In<CqlDateTime>(dc_, dq_, "day");
                bool? ds_ = context.Operators.Not((bool?)(dg_ is null));
                bool? dt_ = context.Operators.And(dr_, ds_);
                return dt_;
            }

            IEnumerable<Encounter> cy_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)cw_, cx_);
            bool? cz_ = context.Operators.Exists<Encounter>(cy_);
            return cz_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        CqlValueSet w_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? z_(MedicationRequest MR) {
            IEnumerable<Medication> du_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dv_(Medication M) {
                object dy_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ea_ = context.Operators.Split((string)dz_, "/");
                string eb_ = context.Operators.Last<string>(ea_);
                bool? ec_ = context.Operators.Equal(dy_, eb_);
                CodeableConcept ed_ = M?.Code;
                CqlConcept ee_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ed_);
                CqlValueSet ef_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? eg_ = context.Operators.ConceptInValueSet(ee_, ef_);
                bool? eh_ = context.Operators.And(ec_, eg_);
                return eh_;
            }

            IEnumerable<Medication> dw_ = context.Operators.Where<Medication>(du_, dv_);
            bool? dx_ = context.Operators.Exists<Medication>(dw_);
            return dx_;
        }

        IEnumerable<MedicationRequest> aa_ = context.Operators.Where<MedicationRequest>(y_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(x_, aa_);
        CqlValueSet ac_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> ei_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ej_(Medication M) {
                object em_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object en_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> eo_ = context.Operators.Split((string)en_, "/");
                string ep_ = context.Operators.Last<string>(eo_);
                bool? eq_ = context.Operators.Equal(em_, ep_);
                CodeableConcept er_ = M?.Code;
                CqlConcept es_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, er_);
                CqlValueSet et_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? eu_ = context.Operators.ConceptInValueSet(es_, et_);
                bool? ev_ = context.Operators.And(eq_, eu_);
                return ev_;
            }

            IEnumerable<Medication> ek_ = context.Operators.Where<Medication>(ei_, ej_);
            bool? el_ = context.Operators.Exists<Medication>(ek_);
            return el_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(y_, ae_);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ab_, ag_);
        IEnumerable<MedicationRequest> ai_ = Status_1_15_000.Instance.isMedicationOrder(context, ah_);

        bool? aj_(MedicationRequest SUDMedication) {
            Encounter ew_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ex_ = [
                ew_,
            ];

            bool? ey_(Encounter FirstSUDEpisode) {
                FhirDateTime fb_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime fc_ = context.Operators.Convert<CqlDateTime>(fb_);
                Period fd_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fd_);
                CqlDateTime ff_ = context.Operators.Start(fe_);
                CqlDate fg_ = context.Operators.DateFrom(ff_);
                CqlQuantity fh_ = context.Operators.Quantity(60m, "days");
                CqlDate fi_ = context.Operators.Subtract(fg_, fh_);
                CqlInterval<CqlDate> fj_ = context.Operators.Interval(fi_, fg_, true, false);
                CqlDate fk_ = fj_?.low;
                CqlDateTime fl_ = context.Operators.ConvertDateToDateTime(fk_);
                CqlDate fm_ = fj_?.high;
                CqlDateTime fn_ = context.Operators.ConvertDateToDateTime(fm_);
                bool? fo_ = fj_?.lowClosed;
                bool? fp_ = fj_?.highClosed;
                CqlInterval<CqlDateTime> fq_ = context.Operators.Interval(fl_, fn_, fo_, fp_);
                bool? fr_ = context.Operators.In<CqlDateTime>(fc_, fq_, "day");
                bool? fs_ = context.Operators.Not((bool?)(fg_ is null));
                bool? ft_ = context.Operators.And(fr_, fs_);
                return ft_;
            }

            IEnumerable<Encounter> ez_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ex_, ey_);
            bool? fa_ = context.Operators.Exists<Encounter>(ez_);
            return fa_;
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

                object p_() {

                    bool ai_() {
                        object am_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlDateTime;
                        return ao_;
                    }


                    bool aj_() {
                        object ap_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlInterval<CqlDateTime>;
                        return ar_;
                    }


                    bool ak_() {
                        object as_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlQuantity;
                        return au_;
                    }


                    bool al_() {
                        object av_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlQuantity>;
                        return ax_;
                    }

                    if (ai_())
                    {
                        object ay_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlDateTime;
                    }
                    else if (aj_())
                    {
                        object ba_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ak_())
                    {
                        object bc_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlQuantity;
                    }
                    else if (al_())
                    {
                        object be_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        return bf_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_());
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

            object bg_() {

                bool bk_() {
                    object bo_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlDateTime;
                    return bq_;
                }


                bool bl_() {
                    object br_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                    return bt_;
                }


                bool bm_() {
                    object bu_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlQuantity;
                    return bw_;
                }


                bool bn_() {
                    object bx_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlInterval<CqlQuantity>;
                    return bz_;
                }

                if (bk_())
                {
                    object ca_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    return cb_ as CqlDateTime;
                }
                else if (bl_())
                {
                    object cc_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    return cd_ as CqlInterval<CqlDateTime>;
                }
                else if (bm_())
                {
                    object ce_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    return cf_ as CqlQuantity;
                }
                else if (bn_())
                {
                    object cg_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    return ch_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_());
            CqlDateTime bi_ = context.Operators.Start(bh_);
            CqlDate bj_ = context.Operators.DateFrom(bi_);
            return bj_;
        }

        IEnumerable<CqlDate> e_ = context.Operators.Select<object, CqlDate>(c_, d_);

        bool? f_(object PsychosocialVisitEncounter) {
            Encounter ci_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cj_ = [
                ci_,
            ];

            bool? ck_(Encounter FirstSUDEpisode) {
                object cn_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_ as Period);
                CqlDateTime cp_ = context.Operators.Start(co_);
                CqlDate cq_ = context.Operators.DateFrom(cp_);
                Period cr_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                CqlDateTime ct_ = context.Operators.Start(cs_);
                CqlDate cu_ = context.Operators.DateFrom(ct_);
                CqlQuantity cv_ = context.Operators.Quantity(14m, "days");
                CqlDate cw_ = context.Operators.Add(cu_, cv_);
                CqlInterval<CqlDate> cx_ = context.Operators.Interval(cu_, cw_, true, false);
                bool? cy_ = context.Operators.In<CqlDate>(cq_, cx_, (string)default);
                object cz_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                string da_ = context.Operators.LateBoundProperty<string>(cz_, "value");
                Id db_ = FirstSUDEpisode?.IdElement;
                string dc_ = db_?.Value;
                bool? dd_ = context.Operators.Equivalent(da_, dc_);
                bool? de_ = context.Operators.Not(dd_);
                bool? df_ = context.Operators.And(cy_, de_);
                return df_;
            }

            IEnumerable<Encounter> cl_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)cj_, ck_);
            bool? cm_ = context.Operators.Exists<Encounter>(cl_);
            return cm_;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(a_, f_);

        CqlDate h_(object PsychosocialVisitEncounter) {
            object dg_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_ as Period);
            CqlDateTime di_ = context.Operators.Start(dh_);
            CqlDate dj_ = context.Operators.DateFrom(di_);
            return dj_;
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

                object cg_() {

                    bool cs_() {
                        DataType cw_ = SUDMedAdministration?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        bool cy_ = cx_ is CqlDateTime;
                        return cy_;
                    }


                    bool ct_() {
                        DataType cz_ = SUDMedAdministration?.Performed;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        bool db_ = da_ is CqlInterval<CqlDateTime>;
                        return db_;
                    }


                    bool cu_() {
                        DataType dc_ = SUDMedAdministration?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlQuantity;
                        return de_;
                    }


                    bool cv_() {
                        DataType df_ = SUDMedAdministration?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bool dh_ = dg_ is CqlInterval<CqlQuantity>;
                        return dh_;
                    }

                    if (cs_())
                    {
                        DataType di_ = SUDMedAdministration?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        return dj_ as CqlDateTime;
                    }
                    else if (ct_())
                    {
                        DataType dk_ = SUDMedAdministration?.Performed;
                        object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                        return dl_ as CqlInterval<CqlDateTime>;
                    }
                    else if (cu_())
                    {
                        DataType dm_ = SUDMedAdministration?.Performed;
                        object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                        return dn_ as CqlQuantity;
                    }
                    else if (cv_())
                    {
                        DataType do_ = SUDMedAdministration?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        return dp_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, cg_());
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

            object dq_() {

                bool du_() {
                    DataType dy_ = SUDMedAdministration?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlDateTime;
                    return ea_;
                }


                bool dv_() {
                    DataType eb_ = SUDMedAdministration?.Performed;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlInterval<CqlDateTime>;
                    return ed_;
                }


                bool dw_() {
                    DataType ee_ = SUDMedAdministration?.Performed;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    bool eg_ = ef_ is CqlQuantity;
                    return eg_;
                }


                bool dx_() {
                    DataType eh_ = SUDMedAdministration?.Performed;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    bool ej_ = ei_ is CqlInterval<CqlQuantity>;
                    return ej_;
                }

                if (du_())
                {
                    DataType ek_ = SUDMedAdministration?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    return el_ as CqlDateTime;
                }
                else if (dv_())
                {
                    DataType em_ = SUDMedAdministration?.Performed;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    return en_ as CqlInterval<CqlDateTime>;
                }
                else if (dw_())
                {
                    DataType eo_ = SUDMedAdministration?.Performed;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    return ep_ as CqlQuantity;
                }
                else if (dx_())
                {
                    DataType eq_ = SUDMedAdministration?.Performed;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    return er_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> dr_ = QICoreCommon_4_0_000.Instance.toInterval(context, dq_());
            CqlDateTime ds_ = context.Operators.Start(dr_);
            CqlDate dt_ = context.Operators.DateFrom(ds_);
            return dt_;
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

                object af_() {

                    bool aw_() {
                        object ba_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlDateTime;
                        return bc_;
                    }


                    bool ax_() {
                        object bd_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlDateTime>;
                        return bf_;
                    }


                    bool ay_() {
                        object bg_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlQuantity;
                        return bi_;
                    }


                    bool az_() {
                        object bj_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlInterval<CqlQuantity>;
                        return bl_;
                    }

                    if (aw_())
                    {
                        object bm_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        return bn_ as CqlDateTime;
                    }
                    else if (ax_())
                    {
                        object bo_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        return bp_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ay_())
                    {
                        object bq_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        return br_ as CqlQuantity;
                    }
                    else if (az_())
                    {
                        object bs_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        return bt_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_());
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
            IEnumerable<Medication> bu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bv_(Medication M) {
                object by_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ca_ = context.Operators.Split((string)bz_, "/");
                string cb_ = context.Operators.Last<string>(ca_);
                bool? cc_ = context.Operators.Equal(by_, cb_);
                CodeableConcept cd_ = M?.Code;
                CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                CqlValueSet cf_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? cg_ = context.Operators.ConceptInValueSet(ce_, cf_);
                bool? ch_ = context.Operators.And(cc_, cg_);
                return ch_;
            }

            IEnumerable<Medication> bw_ = context.Operators.Where<Medication>(bu_, bv_);
            bool? bx_ = context.Operators.Exists<Medication>(bw_);
            return bx_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
        IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(k_, n_);
        IEnumerable<MedicationRequest> p_ = Status_1_15_000.Instance.isMedicationOrder(context, o_);

        bool? q_(MedicationRequest ShortActingMedOrder) {
            IEnumerable<CqlDate> ci_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> cj_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ck_ = context.Operators.Union<CqlDate>(ci_, cj_);
            CqlDate cl_ = context.Operators.Min<CqlDate>(ck_);
            CqlDate[] cm_ = [
                cl_,
            ];

            bool? cn_(CqlDate InitiationTreatmentDate) {
                FhirDateTime cq_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime cr_ = context.Operators.Convert<CqlDateTime>(cq_);
                CqlInterval<CqlDateTime> cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
                CqlDateTime ct_ = context.Operators.Start(cs_);
                CqlDate cu_ = context.Operators.DateFrom(ct_);
                CqlQuantity cv_ = context.Operators.Quantity(34m, "days");
                CqlDate cw_ = context.Operators.Add(InitiationTreatmentDate, cv_);
                CqlInterval<CqlDate> cx_ = context.Operators.Interval(InitiationTreatmentDate, cw_, false, true);
                bool? cy_ = context.Operators.In<CqlDate>(cu_, cx_, (string)default);
                bool? cz_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? da_ = context.Operators.And(cy_, cz_);
                return da_;
            }

            IEnumerable<CqlDate> co_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)cm_, cn_);
            bool? cp_ = context.Operators.Exists<CqlDate>(co_);
            return cp_;
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

                object bf_() {

                    bool bp_() {
                        DataType bt_ = LongActingTreatment?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        bool bv_ = bu_ is CqlDateTime;
                        return bv_;
                    }


                    bool bq_() {
                        DataType bw_ = LongActingTreatment?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlDateTime>;
                        return by_;
                    }


                    bool br_() {
                        DataType bz_ = LongActingTreatment?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlQuantity;
                        return cb_;
                    }


                    bool bs_() {
                        DataType cc_ = LongActingTreatment?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlQuantity>;
                        return ce_;
                    }

                    if (bp_())
                    {
                        DataType cf_ = LongActingTreatment?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        return cg_ as CqlDateTime;
                    }
                    else if (bq_())
                    {
                        DataType ch_ = LongActingTreatment?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        return ci_ as CqlInterval<CqlDateTime>;
                    }
                    else if (br_())
                    {
                        DataType cj_ = LongActingTreatment?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        return ck_ as CqlQuantity;
                    }
                    else if (bs_())
                    {
                        DataType cl_ = LongActingTreatment?.Performed;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        return cm_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_());
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
