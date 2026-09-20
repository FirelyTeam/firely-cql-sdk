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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.3.0")]
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
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                CqlDateTime v_ = context.Operators.Start(u_);
                bool? w_ = context.Operators.In<CqlDateTime>(v_, s_, (string)default);
                bool? x_ = context.Operators.And(t_, w_);
                CqlDateTime y_ = context.Operators.End(q_);
                CqlQuantity z_ = context.Operators.Quantity(47m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                bool? ab_ = context.Operators.SameOrBefore(v_, aa_, "day");
                bool? ac_ = context.Operators.And(x_, ab_);
                return ac_;
            }

            bool? p_ = context.Operators.WhereAny<Condition>(n_, o_);
            return p_;
        }


        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? c_(Encounter ValidEncounters) {
            Period ad_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlDate ag_ = context.Operators.DateFrom(af_);
            (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? ah_ = (CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ, ag_, ValidEncounters);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> d_ = context.Operators.WhereSelect<Encounter, (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(d_);

        object f_((CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? @this) {
            CqlDate ai_ = @this?.ValidEncounterDate;
            return ai_;
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
                DataType bf_ = Interventions?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    DataType bi_ = Interventions?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    aq_ = bj_ as CqlDateTime;
                }
                else
                {
                    DataType bk_ = Interventions?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlQuantity;
                    if (bm_)
                    {
                        DataType bn_ = Interventions?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        aq_ = bo_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bp_ = Interventions?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlInterval<CqlDateTime>;
                        if (br_)
                        {
                            DataType bs_ = Interventions?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            aq_ = bt_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bu_ = Interventions?.Performed;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bool bw_ = bv_ is CqlInterval<CqlQuantity>;
                            if (bw_)
                            {
                                DataType bx_ = Interventions?.Performed;
                                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                                aq_ = by_ as CqlInterval<CqlQuantity>;
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
                bool? bd_ = context.Operators.Not((bool?)(aw_ is null));
                bool? be_ = context.Operators.And(bc_, bd_);
                return be_;
            }

            bool? ap_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)an_, ao_);
            return ap_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> p_ = this.Emergency_Department_or_Detoxification_Visit(context);
        IEnumerable<Encounter> q_ = context.Operators.Except<Encounter>(o_, p_);

        bool? r_(Encounter QualifyingEncounter) {
            IEnumerable<Condition> bz_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? ca_(Condition @this) {
                CodeableConcept cf_ = @this?.Code;
                CqlConcept cg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cf_);
                bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
                return ch_;
            }


            CqlConcept cb_(Condition @this) {
                CodeableConcept ci_ = @this?.Code;
                CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ci_);
                return cj_;
            }

            IEnumerable<CqlConcept> cc_ = context.Operators.WhereSelect<Condition, CqlConcept>(bz_, ca_, cb_);
            CqlValueSet cd_ = this.Substance_Use_Disorder(context);
            bool? ce_ = context.Operators.ConceptsInValueSet(cc_, cd_);
            return ce_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        bool? t_(Encounter SUDEncounterDx) {
            Encounter ck_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cl_ = [
                ck_,
            ];

            bool? cm_(Encounter FirstSUDEpisode) {
                Period co_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                CqlDateTime cq_ = context.Operators.Start(cp_);
                Period cr_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                CqlDateTime ct_ = context.Operators.Start(cs_);
                CqlDate cu_ = context.Operators.DateFrom(ct_);
                CqlQuantity cv_ = context.Operators.Quantity(60m, "days");
                CqlDate cw_ = context.Operators.Subtract(cu_, cv_);
                CqlDateTime cx_ = context.Operators.ConvertDateToDateTime(cw_);
                CqlDateTime cy_ = context.Operators.ConvertDateToDateTime(cu_);
                CqlInterval<CqlDateTime> cz_ = context.Operators.Interval(cx_, cy_, true, false);
                bool? da_ = context.Operators.In<CqlDateTime>(cq_, cz_, "day");
                bool? db_ = context.Operators.Not((bool?)(cu_ is null));
                bool? dc_ = context.Operators.And(da_, db_);
                return dc_;
            }

            bool? cn_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)cl_, cm_);
            return cn_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? x_(MedicationRequest MR) {
            IEnumerable<Medication> dd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? de_(Medication M) {
                string dg_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType dh_ = MR?.Medication;
                object di_ = context.Operators.LateBoundProperty<object>(dh_, "reference");
                object dj_ = context.Operators.LateBoundProperty<object>(di_, "value");
                IEnumerable<string> dk_ = context.Operators.Split((string)dj_, "/");
                string dl_ = context.Operators.Last<string>(dk_);
                bool? dm_ = context.Operators.Equal(dg_, dl_);
                CodeableConcept dn_ = M?.Code;
                CqlConcept do_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dn_);
                CqlValueSet dp_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? dq_ = context.Operators.ConceptInValueSet(do_, dp_);
                bool? dr_ = context.Operators.And(dm_, dq_);
                return dr_;
            }

            bool? df_ = context.Operators.WhereAny<Medication>(dd_, de_);
            return df_;
        }

        IEnumerable<MedicationRequest> y_ = context.Operators.Where<MedicationRequest>(w_, x_);
        CqlValueSet z_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);

        bool? ac_(MedicationRequest MR) {
            IEnumerable<Medication> ds_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dt_(Medication M) {
                string dv_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType dw_ = MR?.Medication;
                object dx_ = context.Operators.LateBoundProperty<object>(dw_, "reference");
                object dy_ = context.Operators.LateBoundProperty<object>(dx_, "value");
                IEnumerable<string> dz_ = context.Operators.Split((string)dy_, "/");
                string ea_ = context.Operators.Last<string>(dz_);
                bool? eb_ = context.Operators.Equal(dv_, ea_);
                CodeableConcept ec_ = M?.Code;
                CqlConcept ed_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ec_);
                CqlValueSet ee_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? ef_ = context.Operators.ConceptInValueSet(ed_, ee_);
                bool? eg_ = context.Operators.And(eb_, ef_);
                return eg_;
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
            Encounter eh_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ei_ = [
                eh_,
            ];

            bool? ej_(Encounter FirstSUDEpisode) {
                FhirDateTime el_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime em_ = context.Operators.Convert<CqlDateTime>(el_);
                Period en_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, en_);
                CqlDateTime ep_ = context.Operators.Start(eo_);
                CqlDate eq_ = context.Operators.DateFrom(ep_);
                CqlQuantity er_ = context.Operators.Quantity(60m, "days");
                CqlDate es_ = context.Operators.Subtract(eq_, er_);
                CqlDateTime et_ = context.Operators.ConvertDateToDateTime(es_);
                CqlDateTime eu_ = context.Operators.ConvertDateToDateTime(eq_);
                CqlInterval<CqlDateTime> ev_ = context.Operators.Interval(et_, eu_, true, false);
                bool? ew_ = context.Operators.In<CqlDateTime>(em_, ev_, "day");
                bool? ex_ = context.Operators.Not((bool?)(eq_ is null));
                bool? ey_ = context.Operators.And(ew_, ex_);
                return ey_;
            }

            bool? ek_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)ei_, ej_);
            return ek_;
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
                CodeableConcept v_ = @this?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                bool? x_ = context.Operators.Not((bool?)(w_ is null));
                return x_;
            }


            CqlConcept r_(Condition @this) {
                CodeableConcept y_ = @this?.Code;
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                return z_;
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
                object af_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    object ai_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    m_ = aj_ as CqlDateTime;
                }
                else
                {
                    object ak_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlQuantity;
                    if (am_)
                    {
                        object an_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        m_ = ao_ as CqlQuantity;
                    }
                    else
                    {
                        object ap_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlInterval<CqlDateTime>;
                        if (ar_)
                        {
                            object as_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            m_ = at_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object au_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            bool aw_ = av_ is CqlInterval<CqlQuantity>;
                            if (aw_)
                            {
                                object ax_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                m_ = ay_ as CqlInterval<CqlQuantity>;
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
                object y_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "id");
                string z_ = context.Operators.LateBoundProperty<string>(y_, "value");
                Id aa_ = FirstSUDEpisode?.IdElement;
                string ab_ = aa_?.Value;
                bool? ac_ = context.Operators.Equivalent(z_, ab_);
                bool? ad_ = context.Operators.Not(ac_);
                bool? ae_ = context.Operators.And(x_, ad_);
                return ae_;
            }

            bool? l_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)j_, k_);
            return l_;
        }


        CqlDate c_(object PsychosocialVisitProcedure) {
            object az_;
            object bd_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                object bg_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                az_ = bh_ as CqlDateTime;
            }
            else
            {
                object bi_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    object bl_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    az_ = bm_ as CqlQuantity;
                }
                else
                {
                    object bn_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        object bq_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        az_ = br_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object bs_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            object bv_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            az_ = bw_ as CqlInterval<CqlQuantity>;
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
            return bc_;
        }

        IEnumerable<CqlDate> d_ = context.Operators.WhereSelect<object, CqlDate>(a_, b_, c_);

        bool? e_(object PsychosocialVisitEncounter) {
            Encounter bx_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] by_ = [
                bx_,
            ];

            bool? bz_(Encounter FirstSUDEpisode) {
                object cb_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_ as Period);
                CqlDateTime cd_ = context.Operators.Start(cc_);
                CqlDate ce_ = context.Operators.DateFrom(cd_);
                Period cf_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cf_);
                CqlDateTime ch_ = context.Operators.Start(cg_);
                CqlDate ci_ = context.Operators.DateFrom(ch_);
                CqlQuantity cj_ = context.Operators.Quantity(14m, "days");
                CqlDate ck_ = context.Operators.Add(ci_, cj_);
                CqlInterval<CqlDate> cl_ = context.Operators.Interval(ci_, ck_, true, false);
                bool? cm_ = context.Operators.In<CqlDate>(ce_, cl_, (string)default);
                object cn_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                string co_ = context.Operators.LateBoundProperty<string>(cn_, "value");
                Id cp_ = FirstSUDEpisode?.IdElement;
                string cq_ = cp_?.Value;
                bool? cr_ = context.Operators.Equivalent(co_, cq_);
                bool? cs_ = context.Operators.Not(cr_);
                bool? ct_ = context.Operators.And(cm_, cs_);
                return ct_;
            }

            bool? ca_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)by_, bz_);
            return ca_;
        }


        CqlDate f_(object PsychosocialVisitEncounter) {
            object cu_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_ as Period);
            CqlDateTime cw_ = context.Operators.Start(cv_);
            CqlDate cx_ = context.Operators.DateFrom(cw_);
            return cx_;
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
                string ad_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType ae_ = MR?.Medication;
                object af_ = context.Operators.LateBoundProperty<object>(ae_, "reference");
                object ag_ = context.Operators.LateBoundProperty<object>(af_, "value");
                IEnumerable<string> ah_ = context.Operators.Split((string)ag_, "/");
                string ai_ = context.Operators.Last<string>(ah_);
                bool? aj_ = context.Operators.Equal(ad_, ai_);
                CodeableConcept ak_ = M?.Code;
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                CqlValueSet am_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
                bool? ao_ = context.Operators.And(aj_, an_);
                return ao_;
            }

            bool? ac_ = context.Operators.WhereAny<Medication>(aa_, ab_);
            return ac_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ap_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? aq_(Medication M) {
                string as_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType at_ = MR?.Medication;
                object au_ = context.Operators.LateBoundProperty<object>(at_, "reference");
                object av_ = context.Operators.LateBoundProperty<object>(au_, "value");
                IEnumerable<string> aw_ = context.Operators.Split((string)av_, "/");
                string ax_ = context.Operators.Last<string>(aw_);
                bool? ay_ = context.Operators.Equal(as_, ax_);
                CodeableConcept az_ = M?.Code;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlValueSet bb_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
                bool? bd_ = context.Operators.And(ay_, bc_);
                return bd_;
            }

            bool? ar_ = context.Operators.WhereAny<Medication>(ap_, aq_);
            return ar_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        IEnumerable<MedicationRequest> m_ = Status_1_15_000.Instance.isMedicationOrder(context, l_);

        bool? n_(MedicationRequest SUDMedication) {
            Encounter be_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bf_ = [
                be_,
            ];

            bool? bg_(Encounter FirstSUDEpisode) {
                FhirDateTime bi_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bj_ = context.Operators.Convert<CqlDateTime>(bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlDate bm_ = context.Operators.DateFrom(bl_);
                Period bn_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDate bq_ = context.Operators.DateFrom(bp_);
                CqlQuantity br_ = context.Operators.Quantity(14m, "days");
                CqlDate bs_ = context.Operators.Add(bq_, br_);
                CqlInterval<CqlDate> bt_ = context.Operators.Interval(bq_, bs_, true, false);
                bool? bu_ = context.Operators.In<CqlDate>(bm_, bt_, (string)default);
                return bu_;
            }

            bool? bh_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bf_, bg_);
            return bh_;
        }


        CqlDate o_(MedicationRequest SUDMedication) {
            FhirDateTime bv_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime bw_ = context.Operators.Convert<CqlDateTime>(bv_);
            CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, bw_);
            CqlDateTime by_ = context.Operators.Start(bx_);
            CqlDate bz_ = context.Operators.DateFrom(by_);
            return bz_;
        }

        IEnumerable<CqlDate> p_ = context.Operators.WhereSelect<MedicationRequest, CqlDate>(m_, n_, o_);
        CqlValueSet q_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet s_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
        IEnumerable<Procedure> v_ = Status_1_15_000.Instance.isProcedurePerformed(context, u_);

        bool? w_(Procedure SUDMedAdministration) {
            Encounter ca_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cb_ = [
                ca_,
            ];

            bool? cc_(Encounter FirstSUDEpisode) {
                object ce_;
                DataType cq_ = SUDMedAdministration?.Performed;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool cs_ = cr_ is CqlDateTime;
                if (cs_)
                {
                    DataType ct_ = SUDMedAdministration?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    ce_ = cu_ as CqlDateTime;
                }
                else
                {
                    DataType cv_ = SUDMedAdministration?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlQuantity;
                    if (cx_)
                    {
                        DataType cy_ = SUDMedAdministration?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        ce_ = cz_ as CqlQuantity;
                    }
                    else
                    {
                        DataType da_ = SUDMedAdministration?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlInterval<CqlDateTime>;
                        if (dc_)
                        {
                            DataType dd_ = SUDMedAdministration?.Performed;
                            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            ce_ = de_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType df_ = SUDMedAdministration?.Performed;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            bool dh_ = dg_ is CqlInterval<CqlQuantity>;
                            if (dh_)
                            {
                                DataType di_ = SUDMedAdministration?.Performed;
                                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                                ce_ = dj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ce_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cf_ = QICoreCommon_4_0_000.Instance.toInterval(context, ce_);
                CqlDateTime cg_ = context.Operators.Start(cf_);
                CqlDate ch_ = context.Operators.DateFrom(cg_);
                Period ci_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ci_);
                CqlDateTime ck_ = context.Operators.Start(cj_);
                CqlDate cl_ = context.Operators.DateFrom(ck_);
                CqlQuantity cm_ = context.Operators.Quantity(14m, "days");
                CqlDate cn_ = context.Operators.Add(cl_, cm_);
                CqlInterval<CqlDate> co_ = context.Operators.Interval(cl_, cn_, true, false);
                bool? cp_ = context.Operators.In<CqlDate>(ch_, co_, (string)default);
                return cp_;
            }

            bool? cd_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)cb_, cc_);
            return cd_;
        }


        CqlDate x_(Procedure SUDMedAdministration) {
            object dk_;
            DataType do_ = SUDMedAdministration?.Performed;
            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
            bool dq_ = dp_ is CqlDateTime;
            if (dq_)
            {
                DataType dr_ = SUDMedAdministration?.Performed;
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                dk_ = ds_ as CqlDateTime;
            }
            else
            {
                DataType dt_ = SUDMedAdministration?.Performed;
                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                bool dv_ = du_ is CqlQuantity;
                if (dv_)
                {
                    DataType dw_ = SUDMedAdministration?.Performed;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    dk_ = dx_ as CqlQuantity;
                }
                else
                {
                    DataType dy_ = SUDMedAdministration?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlInterval<CqlDateTime>;
                    if (ea_)
                    {
                        DataType eb_ = SUDMedAdministration?.Performed;
                        object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        dk_ = ec_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ed_ = SUDMedAdministration?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        bool ef_ = ee_ is CqlInterval<CqlQuantity>;
                        if (ef_)
                        {
                            DataType eg_ = SUDMedAdministration?.Performed;
                            object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                            dk_ = eh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dk_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dl_ = QICoreCommon_4_0_000.Instance.toInterval(context, dk_);
            CqlDateTime dm_ = context.Operators.Start(dl_);
            CqlDate dn_ = context.Operators.DateFrom(dm_);
            return dn_;
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
            IEnumerable<CqlDate> v_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> w_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> x_ = context.Operators.Union<CqlDate>(v_, w_);
            CqlDate y_ = context.Operators.Min<CqlDate>(x_);
            CqlDate[] z_ = [
                y_,
            ];

            bool? aa_(CqlDate InitiationTreatmentDate) {
                object ac_;
                object at_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool av_ = au_ is CqlDateTime;
                if (av_)
                {
                    object aw_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    ac_ = ax_ as CqlDateTime;
                }
                else
                {
                    object ay_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlQuantity;
                    if (ba_)
                    {
                        object bb_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        ac_ = bc_ as CqlQuantity;
                    }
                    else
                    {
                        object bd_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlDateTime>;
                        if (bf_)
                        {
                            object bg_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            ac_ = bh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object bi_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            bool bk_ = bj_ is CqlInterval<CqlQuantity>;
                            if (bk_)
                            {
                                object bl_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                                ac_ = bm_ as CqlInterval<CqlQuantity>;
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
                bool? ak_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? al_ = context.Operators.And(aj_, ak_);
                object am_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_ as Period);
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlDate ap_ = context.Operators.DateFrom(ao_);
                bool? aq_ = context.Operators.In<CqlDate>(ap_, ai_, (string)default);
                bool? ar_ = context.Operators.And(aq_, ak_);
                bool? as_ = context.Operators.Or(al_, ar_);
                return as_;
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
                string bq_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType br_ = MR?.Medication;
                object bs_ = context.Operators.LateBoundProperty<object>(br_, "reference");
                object bt_ = context.Operators.LateBoundProperty<object>(bs_, "value");
                IEnumerable<string> bu_ = context.Operators.Split((string)bt_, "/");
                string bv_ = context.Operators.Last<string>(bu_);
                bool? bw_ = context.Operators.Equal(bq_, bv_);
                CodeableConcept bx_ = M?.Code;
                CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                CqlValueSet bz_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? ca_ = context.Operators.ConceptInValueSet(by_, bz_);
                bool? cb_ = context.Operators.And(bw_, ca_);
                return cb_;
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
            IEnumerable<CqlDate> cc_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> cd_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ce_ = context.Operators.Union<CqlDate>(cc_, cd_);
            CqlDate cf_ = context.Operators.Min<CqlDate>(ce_);
            CqlDate[] cg_ = [
                cf_,
            ];

            bool? ch_(CqlDate InitiationTreatmentDate) {
                FhirDateTime cj_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime ck_ = context.Operators.Convert<CqlDateTime>(cj_);
                CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.Start(cl_);
                CqlDate cn_ = context.Operators.DateFrom(cm_);
                CqlQuantity co_ = context.Operators.Quantity(34m, "days");
                CqlDate cp_ = context.Operators.Add(InitiationTreatmentDate, co_);
                CqlInterval<CqlDate> cq_ = context.Operators.Interval(InitiationTreatmentDate, cp_, false, true);
                bool? cr_ = context.Operators.In<CqlDate>(cn_, cq_, (string)default);
                bool? cs_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? ct_ = context.Operators.And(cr_, cs_);
                return ct_;
            }

            bool? ci_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)cg_, ch_);
            return ci_;
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
                string t_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType u_ = MR?.Medication;
                object v_ = context.Operators.LateBoundProperty<object>(u_, "reference");
                object w_ = context.Operators.LateBoundProperty<object>(v_, "value");
                IEnumerable<string> x_ = context.Operators.Split((string)w_, "/");
                string y_ = context.Operators.Last<string>(x_);
                bool? z_ = context.Operators.Equal(t_, y_);
                CodeableConcept aa_ = M?.Code;
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                CqlValueSet ac_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                bool? ae_ = context.Operators.And(z_, ad_);
                return ae_;
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
            IEnumerable<CqlDate> af_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ag_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ah_ = context.Operators.Union<CqlDate>(af_, ag_);
            CqlDate ai_ = context.Operators.Min<CqlDate>(ah_);
            CqlDate[] aj_ = [
                ai_,
            ];

            bool? ak_(CqlDate InitiationTreatmentDate) {
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

            bool? al_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)aj_, ak_);
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
                object be_;
                DataType bo_ = LongActingTreatment?.Performed;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool bq_ = bp_ is CqlDateTime;
                if (bq_)
                {
                    DataType br_ = LongActingTreatment?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    be_ = bs_ as CqlDateTime;
                }
                else
                {
                    DataType bt_ = LongActingTreatment?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlQuantity;
                    if (bv_)
                    {
                        DataType bw_ = LongActingTreatment?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        be_ = bx_ as CqlQuantity;
                    }
                    else
                    {
                        DataType by_ = LongActingTreatment?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlInterval<CqlDateTime>;
                        if (ca_)
                        {
                            DataType cb_ = LongActingTreatment?.Performed;
                            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                            be_ = cc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cd_ = LongActingTreatment?.Performed;
                            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            bool cf_ = ce_ is CqlInterval<CqlQuantity>;
                            if (cf_)
                            {
                                DataType cg_ = LongActingTreatment?.Performed;
                                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                                be_ = ch_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                be_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.toInterval(context, be_);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                CqlDate bh_ = context.Operators.DateFrom(bg_);
                CqlQuantity bi_ = context.Operators.Quantity(34m, "days");
                CqlDate bj_ = context.Operators.Add(InitiationTreatmentDate, bi_);
                CqlInterval<CqlDate> bk_ = context.Operators.Interval(InitiationTreatmentDate, bj_, false, true);
                bool? bl_ = context.Operators.In<CqlDate>(bh_, bk_, (string)default);
                bool? bm_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? bn_ = context.Operators.And(bl_, bm_);
                return bn_;
            }

            bool? bd_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)bb_, bc_);
            return bd_;
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
