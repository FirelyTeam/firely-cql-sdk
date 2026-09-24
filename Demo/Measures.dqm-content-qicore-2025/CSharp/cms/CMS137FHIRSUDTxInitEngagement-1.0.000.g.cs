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
                Id dg_ = M?.IdElement;
                string dh_ = dg_?.Value;
                DataType di_ = MR?.Medication;
                FhirString dk_ = di_ is ResourceReference dj_ ? dj_.ReferenceElement : null;
                string dl_ = dk_?.Value;
                IEnumerable<string> dm_ = context.Operators.Split(dl_, "/");
                string dn_ = context.Operators.Last<string>(dm_);
                bool? do_ = context.Operators.Equal(dh_, dn_);
                CodeableConcept dp_ = M?.Code;
                CqlConcept dq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dp_);
                CqlValueSet dr_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? ds_ = context.Operators.ConceptInValueSet(dq_, dr_);
                bool? dt_ = context.Operators.And(do_, ds_);
                return dt_;
            }

            bool? df_ = context.Operators.WhereAny<Medication>(dd_, de_);
            return df_;
        }

        IEnumerable<MedicationRequest> y_ = context.Operators.Where<MedicationRequest>(w_, x_);
        CqlValueSet z_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);

        bool? ac_(MedicationRequest MR) {
            IEnumerable<Medication> du_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dv_(Medication M) {
                Id dx_ = M?.IdElement;
                string dy_ = dx_?.Value;
                DataType dz_ = MR?.Medication;
                FhirString eb_ = dz_ is ResourceReference ea_ ? ea_.ReferenceElement : null;
                string ec_ = eb_?.Value;
                IEnumerable<string> ed_ = context.Operators.Split(ec_, "/");
                string ee_ = context.Operators.Last<string>(ed_);
                bool? ef_ = context.Operators.Equal(dy_, ee_);
                CodeableConcept eg_ = M?.Code;
                CqlConcept eh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eg_);
                CqlValueSet ei_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? ej_ = context.Operators.ConceptInValueSet(eh_, ei_);
                bool? ek_ = context.Operators.And(ef_, ej_);
                return ek_;
            }

            bool? dw_ = context.Operators.WhereAny<Medication>(du_, dv_);
            return dw_;
        }

        IEnumerable<MedicationRequest> ad_ = context.Operators.Where<MedicationRequest>(w_, ac_);
        CqlValueSet ae_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ab_, ag_);
        IEnumerable<MedicationRequest> ai_ = Status_1_15_000.Instance.isMedicationOrder(context, ah_);

        bool? aj_(MedicationRequest SUDMedication) {
            Encounter el_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] em_ = [
                el_,
            ];

            bool? en_(Encounter FirstSUDEpisode) {
                FhirDateTime ep_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime eq_ = context.Operators.Convert<CqlDateTime>(ep_);
                Period er_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                CqlDateTime et_ = context.Operators.Start(es_);
                CqlDate eu_ = context.Operators.DateFrom(et_);
                CqlQuantity ev_ = context.Operators.Quantity(60m, "days");
                CqlDate ew_ = context.Operators.Subtract(eu_, ev_);
                CqlDateTime ex_ = context.Operators.ConvertDateToDateTime(ew_);
                CqlDateTime ey_ = context.Operators.ConvertDateToDateTime(eu_);
                CqlInterval<CqlDateTime> ez_ = context.Operators.Interval(ex_, ey_, true, false);
                bool? fa_ = context.Operators.In<CqlDateTime>(eq_, ez_, "day");
                bool? fb_ = context.Operators.Not((bool?)(eu_ is null));
                bool? fc_ = context.Operators.And(fa_, fb_);
                return fc_;
            }

            bool? eo_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)em_, en_);
            return eo_;
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
                object ah_ = PsychosocialVisitProcedure is Procedure ag_ ? ag_.Performed : null;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool aj_ = ai_ is CqlDateTime;
                if (aj_)
                {
                    object al_ = PsychosocialVisitProcedure is Procedure ak_ ? ak_.Performed : null;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    m_ = am_ as CqlDateTime;
                }
                else
                {
                    object ao_ = PsychosocialVisitProcedure is Procedure an_ ? an_.Performed : null;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlQuantity;
                    if (aq_)
                    {
                        object as_ = PsychosocialVisitProcedure is Procedure ar_ ? ar_.Performed : null;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        m_ = at_ as CqlQuantity;
                    }
                    else
                    {
                        object av_ = PsychosocialVisitProcedure is Procedure au_ ? au_.Performed : null;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            object az_ = PsychosocialVisitProcedure is Procedure ay_ ? ay_.Performed : null;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            m_ = ba_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object bc_ = PsychosocialVisitProcedure is Procedure bb_ ? bb_.Performed : null;
                            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                            bool be_ = bd_ is CqlInterval<CqlQuantity>;
                            if (be_)
                            {
                                object bg_ = PsychosocialVisitProcedure is Procedure bf_ ? bf_.Performed : null;
                                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                                m_ = bh_ as CqlInterval<CqlQuantity>;
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
                Id z_ = PsychosocialVisitProcedure is Resource y_ ? y_.IdElement : null;
                string aa_ = z_?.Value;
                Id ab_ = FirstSUDEpisode?.IdElement;
                string ac_ = ab_?.Value;
                bool? ad_ = context.Operators.Equivalent(aa_, ac_);
                bool? ae_ = context.Operators.Not(ad_);
                bool? af_ = context.Operators.And(x_, ae_);
                return af_;
            }

            bool? l_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)j_, k_);
            return l_;
        }


        CqlDate c_(object PsychosocialVisitProcedure) {
            object bi_;
            object bn_ = PsychosocialVisitProcedure is Procedure bm_ ? bm_.Performed : null;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            bool bp_ = bo_ is CqlDateTime;
            if (bp_)
            {
                object br_ = PsychosocialVisitProcedure is Procedure bq_ ? bq_.Performed : null;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                bi_ = bs_ as CqlDateTime;
            }
            else
            {
                object bu_ = PsychosocialVisitProcedure is Procedure bt_ ? bt_.Performed : null;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool bw_ = bv_ is CqlQuantity;
                if (bw_)
                {
                    object by_ = PsychosocialVisitProcedure is Procedure bx_ ? bx_.Performed : null;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bi_ = bz_ as CqlQuantity;
                }
                else
                {
                    object cb_ = PsychosocialVisitProcedure is Procedure ca_ ? ca_.Performed : null;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        object cf_ = PsychosocialVisitProcedure is Procedure ce_ ? ce_.Performed : null;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bi_ = cg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object ci_ = PsychosocialVisitProcedure is Procedure ch_ ? ch_.Performed : null;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                        if (ck_)
                        {
                            object cm_ = PsychosocialVisitProcedure is Procedure cl_ ? cl_.Performed : null;
                            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            bi_ = cn_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bi_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
            CqlDateTime bk_ = context.Operators.Start(bj_);
            CqlDate bl_ = context.Operators.DateFrom(bk_);
            return bl_;
        }

        IEnumerable<CqlDate> d_ = context.Operators.WhereSelect<object, CqlDate>(a_, b_, c_);

        bool? e_(object PsychosocialVisitEncounter) {
            Encounter co_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cp_ = [
                co_,
            ];

            bool? cq_(Encounter FirstSUDEpisode) {
                Period ct_ = PsychosocialVisitEncounter is Encounter cs_ ? cs_.Period : null;
                CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                CqlDateTime cv_ = context.Operators.Start(cu_);
                CqlDate cw_ = context.Operators.DateFrom(cv_);
                Period cx_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cx_);
                CqlDateTime cz_ = context.Operators.Start(cy_);
                CqlDate da_ = context.Operators.DateFrom(cz_);
                CqlQuantity db_ = context.Operators.Quantity(14m, "days");
                CqlDate dc_ = context.Operators.Add(da_, db_);
                CqlInterval<CqlDate> dd_ = context.Operators.Interval(da_, dc_, true, false);
                bool? de_ = context.Operators.In<CqlDate>(cw_, dd_, (string)default);
                Id dg_ = PsychosocialVisitEncounter is Resource df_ ? df_.IdElement : null;
                string dh_ = dg_?.Value;
                Id di_ = FirstSUDEpisode?.IdElement;
                string dj_ = di_?.Value;
                bool? dk_ = context.Operators.Equivalent(dh_, dj_);
                bool? dl_ = context.Operators.Not(dk_);
                bool? dm_ = context.Operators.And(de_, dl_);
                return dm_;
            }

            bool? cr_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)cp_, cq_);
            return cr_;
        }


        CqlDate f_(object PsychosocialVisitEncounter) {
            Period do_ = PsychosocialVisitEncounter is Encounter dn_ ? dn_.Period : null;
            CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
            CqlDateTime dq_ = context.Operators.Start(dp_);
            CqlDate dr_ = context.Operators.DateFrom(dq_);
            return dr_;
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
                Id ad_ = M?.IdElement;
                string ae_ = ad_?.Value;
                DataType af_ = MR?.Medication;
                FhirString ah_ = af_ is ResourceReference ag_ ? ag_.ReferenceElement : null;
                string ai_ = ah_?.Value;
                IEnumerable<string> aj_ = context.Operators.Split(ai_, "/");
                string ak_ = context.Operators.Last<string>(aj_);
                bool? al_ = context.Operators.Equal(ae_, ak_);
                CodeableConcept am_ = M?.Code;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlValueSet ao_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? ap_ = context.Operators.ConceptInValueSet(an_, ao_);
                bool? aq_ = context.Operators.And(al_, ap_);
                return aq_;
            }

            bool? ac_ = context.Operators.WhereAny<Medication>(aa_, ab_);
            return ac_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ar_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? as_(Medication M) {
                Id au_ = M?.IdElement;
                string av_ = au_?.Value;
                DataType aw_ = MR?.Medication;
                FhirString ay_ = aw_ is ResourceReference ax_ ? ax_.ReferenceElement : null;
                string az_ = ay_?.Value;
                IEnumerable<string> ba_ = context.Operators.Split(az_, "/");
                string bb_ = context.Operators.Last<string>(ba_);
                bool? bc_ = context.Operators.Equal(av_, bb_);
                CodeableConcept bd_ = M?.Code;
                CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                CqlValueSet bf_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? bg_ = context.Operators.ConceptInValueSet(be_, bf_);
                bool? bh_ = context.Operators.And(bc_, bg_);
                return bh_;
            }

            bool? at_ = context.Operators.WhereAny<Medication>(ar_, as_);
            return at_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        IEnumerable<MedicationRequest> m_ = Status_1_15_000.Instance.isMedicationOrder(context, l_);

        bool? n_(MedicationRequest SUDMedication) {
            Encounter bi_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bj_ = [
                bi_,
            ];

            bool? bk_(Encounter FirstSUDEpisode) {
                FhirDateTime bm_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bn_ = context.Operators.Convert<CqlDateTime>(bm_);
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDate bq_ = context.Operators.DateFrom(bp_);
                Period br_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, br_);
                CqlDateTime bt_ = context.Operators.Start(bs_);
                CqlDate bu_ = context.Operators.DateFrom(bt_);
                CqlQuantity bv_ = context.Operators.Quantity(14m, "days");
                CqlDate bw_ = context.Operators.Add(bu_, bv_);
                CqlInterval<CqlDate> bx_ = context.Operators.Interval(bu_, bw_, true, false);
                bool? by_ = context.Operators.In<CqlDate>(bq_, bx_, (string)default);
                return by_;
            }

            bool? bl_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bj_, bk_);
            return bl_;
        }


        CqlDate o_(MedicationRequest SUDMedication) {
            FhirDateTime bz_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime ca_ = context.Operators.Convert<CqlDateTime>(bz_);
            CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
            CqlDateTime cc_ = context.Operators.Start(cb_);
            CqlDate cd_ = context.Operators.DateFrom(cc_);
            return cd_;
        }

        IEnumerable<CqlDate> p_ = context.Operators.WhereSelect<MedicationRequest, CqlDate>(m_, n_, o_);
        CqlValueSet q_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet s_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
        IEnumerable<Procedure> v_ = Status_1_15_000.Instance.isProcedurePerformed(context, u_);

        bool? w_(Procedure SUDMedAdministration) {
            Encounter ce_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cf_ = [
                ce_,
            ];

            bool? cg_(Encounter FirstSUDEpisode) {
                object ci_;
                DataType cu_ = SUDMedAdministration?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlDateTime;
                if (cw_)
                {
                    DataType cx_ = SUDMedAdministration?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    ci_ = cy_ as CqlDateTime;
                }
                else
                {
                    DataType cz_ = SUDMedAdministration?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlQuantity;
                    if (db_)
                    {
                        DataType dc_ = SUDMedAdministration?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        ci_ = dd_ as CqlQuantity;
                    }
                    else
                    {
                        DataType de_ = SUDMedAdministration?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlDateTime>;
                        if (dg_)
                        {
                            DataType dh_ = SUDMedAdministration?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            ci_ = di_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType dj_ = SUDMedAdministration?.Performed;
                            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            bool dl_ = dk_ is CqlInterval<CqlQuantity>;
                            if (dl_)
                            {
                                DataType dm_ = SUDMedAdministration?.Performed;
                                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                                ci_ = dn_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ci_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
                CqlDateTime ck_ = context.Operators.Start(cj_);
                CqlDate cl_ = context.Operators.DateFrom(ck_);
                Period cm_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                CqlDateTime co_ = context.Operators.Start(cn_);
                CqlDate cp_ = context.Operators.DateFrom(co_);
                CqlQuantity cq_ = context.Operators.Quantity(14m, "days");
                CqlDate cr_ = context.Operators.Add(cp_, cq_);
                CqlInterval<CqlDate> cs_ = context.Operators.Interval(cp_, cr_, true, false);
                bool? ct_ = context.Operators.In<CqlDate>(cl_, cs_, (string)default);
                return ct_;
            }

            bool? ch_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)cf_, cg_);
            return ch_;
        }


        CqlDate x_(Procedure SUDMedAdministration) {
            object do_;
            DataType ds_ = SUDMedAdministration?.Performed;
            object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
            bool du_ = dt_ is CqlDateTime;
            if (du_)
            {
                DataType dv_ = SUDMedAdministration?.Performed;
                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                do_ = dw_ as CqlDateTime;
            }
            else
            {
                DataType dx_ = SUDMedAdministration?.Performed;
                object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                bool dz_ = dy_ is CqlQuantity;
                if (dz_)
                {
                    DataType ea_ = SUDMedAdministration?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    do_ = eb_ as CqlQuantity;
                }
                else
                {
                    DataType ec_ = SUDMedAdministration?.Performed;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                    if (ee_)
                    {
                        DataType ef_ = SUDMedAdministration?.Performed;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        do_ = eg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType eh_ = SUDMedAdministration?.Performed;
                        object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                        bool ej_ = ei_ is CqlInterval<CqlQuantity>;
                        if (ej_)
                        {
                            DataType ek_ = SUDMedAdministration?.Performed;
                            object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                            do_ = el_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            do_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dp_ = QICoreCommon_4_0_000.Instance.toInterval(context, do_);
            CqlDateTime dq_ = context.Operators.Start(dp_);
            CqlDate dr_ = context.Operators.DateFrom(dq_);
            return dr_;
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
                object av_ = ShortActingTreatment is Procedure au_ ? au_.Performed : null;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                bool ax_ = aw_ is CqlDateTime;
                if (ax_)
                {
                    object az_ = ShortActingTreatment is Procedure ay_ ? ay_.Performed : null;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    ac_ = ba_ as CqlDateTime;
                }
                else
                {
                    object bc_ = ShortActingTreatment is Procedure bb_ ? bb_.Performed : null;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlQuantity;
                    if (be_)
                    {
                        object bg_ = ShortActingTreatment is Procedure bf_ ? bf_.Performed : null;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        ac_ = bh_ as CqlQuantity;
                    }
                    else
                    {
                        object bj_ = ShortActingTreatment is Procedure bi_ ? bi_.Performed : null;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlInterval<CqlDateTime>;
                        if (bl_)
                        {
                            object bn_ = ShortActingTreatment is Procedure bm_ ? bm_.Performed : null;
                            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                            ac_ = bo_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object bq_ = ShortActingTreatment is Procedure bp_ ? bp_.Performed : null;
                            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                            bool bs_ = br_ is CqlInterval<CqlQuantity>;
                            if (bs_)
                            {
                                object bu_ = ShortActingTreatment is Procedure bt_ ? bt_.Performed : null;
                                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                                ac_ = bv_ as CqlInterval<CqlQuantity>;
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
                Period an_ = ShortActingTreatment is Encounter am_ ? am_.Period : null;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlDate aq_ = context.Operators.DateFrom(ap_);
                bool? ar_ = context.Operators.In<CqlDate>(aq_, ai_, (string)default);
                bool? as_ = context.Operators.And(ar_, ak_);
                bool? at_ = context.Operators.Or(al_, as_);
                return at_;
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)z_, aa_);
            return ab_;
        }

        object g_(object ShortActingTreatment) => ShortActingTreatment;
        IEnumerable<object> h_ = context.Operators.WhereSelect<object, object>(e_, f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? j_(MedicationRequest MR) {
            IEnumerable<Medication> bw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bx_(Medication M) {
                Id bz_ = M?.IdElement;
                string ca_ = bz_?.Value;
                DataType cb_ = MR?.Medication;
                FhirString cd_ = cb_ is ResourceReference cc_ ? cc_.ReferenceElement : null;
                string ce_ = cd_?.Value;
                IEnumerable<string> cf_ = context.Operators.Split(ce_, "/");
                string cg_ = context.Operators.Last<string>(cf_);
                bool? ch_ = context.Operators.Equal(ca_, cg_);
                CodeableConcept ci_ = M?.Code;
                CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ci_);
                CqlValueSet ck_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? cl_ = context.Operators.ConceptInValueSet(cj_, ck_);
                bool? cm_ = context.Operators.And(ch_, cl_);
                return cm_;
            }

            bool? by_ = context.Operators.WhereAny<Medication>(bw_, bx_);
            return by_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
        CqlValueSet l_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);
        IEnumerable<MedicationRequest> o_ = Status_1_15_000.Instance.isMedicationOrder(context, n_);

        bool? p_(MedicationRequest ShortActingMedOrder) {
            IEnumerable<CqlDate> cn_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> co_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> cp_ = context.Operators.Union<CqlDate>(cn_, co_);
            CqlDate cq_ = context.Operators.Min<CqlDate>(cp_);
            CqlDate[] cr_ = [
                cq_,
            ];

            bool? cs_(CqlDate InitiationTreatmentDate) {
                FhirDateTime cu_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime cv_ = context.Operators.Convert<CqlDateTime>(cu_);
                CqlInterval<CqlDateTime> cw_ = QICoreCommon_4_0_000.Instance.toInterval(context, cv_);
                CqlDateTime cx_ = context.Operators.Start(cw_);
                CqlDate cy_ = context.Operators.DateFrom(cx_);
                CqlQuantity cz_ = context.Operators.Quantity(34m, "days");
                CqlDate da_ = context.Operators.Add(InitiationTreatmentDate, cz_);
                CqlInterval<CqlDate> db_ = context.Operators.Interval(InitiationTreatmentDate, da_, false, true);
                bool? dc_ = context.Operators.In<CqlDate>(cy_, db_, (string)default);
                bool? dd_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? de_ = context.Operators.And(dc_, dd_);
                return de_;
            }

            bool? ct_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)cr_, cs_);
            return ct_;
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
                Id t_ = M?.IdElement;
                string u_ = t_?.Value;
                DataType v_ = MR?.Medication;
                FhirString x_ = v_ is ResourceReference w_ ? w_.ReferenceElement : null;
                string y_ = x_?.Value;
                IEnumerable<string> z_ = context.Operators.Split(y_, "/");
                string aa_ = context.Operators.Last<string>(z_);
                bool? ab_ = context.Operators.Equal(u_, aa_);
                CodeableConcept ac_ = M?.Code;
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                CqlValueSet ae_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
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
            IEnumerable<CqlDate> ah_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ai_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> aj_ = context.Operators.Union<CqlDate>(ah_, ai_);
            CqlDate ak_ = context.Operators.Min<CqlDate>(aj_);
            CqlDate[] al_ = [
                ak_,
            ];

            bool? am_(CqlDate InitiationTreatmentDate) {
                FhirDateTime ao_ = LongActingMedOrder?.AuthoredOnElement;
                CqlDateTime ap_ = context.Operators.Convert<CqlDateTime>(ao_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlDate as_ = context.Operators.DateFrom(ar_);
                CqlQuantity at_ = context.Operators.Quantity(34m, "days");
                CqlDate au_ = context.Operators.Add(InitiationTreatmentDate, at_);
                CqlInterval<CqlDate> av_ = context.Operators.Interval(InitiationTreatmentDate, au_, false, true);
                bool? aw_ = context.Operators.In<CqlDate>(as_, av_, (string)default);
                bool? ax_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? ay_ = context.Operators.And(aw_, ax_);
                return ay_;
            }

            bool? an_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)al_, am_);
            return an_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isProcedurePerformed(context, k_);

        bool? m_(Procedure LongActingTreatment) {
            IEnumerable<CqlDate> az_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ba_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> bb_ = context.Operators.Union<CqlDate>(az_, ba_);
            CqlDate bc_ = context.Operators.Min<CqlDate>(bb_);
            CqlDate[] bd_ = [
                bc_,
            ];

            bool? be_(CqlDate InitiationTreatmentDate) {
                object bg_;
                DataType bq_ = LongActingTreatment?.Performed;
                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                bool bs_ = br_ is CqlDateTime;
                if (bs_)
                {
                    DataType bt_ = LongActingTreatment?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bg_ = bu_ as CqlDateTime;
                }
                else
                {
                    DataType bv_ = LongActingTreatment?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bool bx_ = bw_ is CqlQuantity;
                    if (bx_)
                    {
                        DataType by_ = LongActingTreatment?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bg_ = bz_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ca_ = LongActingTreatment?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                        if (cc_)
                        {
                            DataType cd_ = LongActingTreatment?.Performed;
                            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            bg_ = ce_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cf_ = LongActingTreatment?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            bool ch_ = cg_ is CqlInterval<CqlQuantity>;
                            if (ch_)
                            {
                                DataType ci_ = LongActingTreatment?.Performed;
                                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                                bg_ = cj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bg_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                CqlDateTime bi_ = context.Operators.Start(bh_);
                CqlDate bj_ = context.Operators.DateFrom(bi_);
                CqlQuantity bk_ = context.Operators.Quantity(34m, "days");
                CqlDate bl_ = context.Operators.Add(InitiationTreatmentDate, bk_);
                CqlInterval<CqlDate> bm_ = context.Operators.Interval(InitiationTreatmentDate, bl_, false, true);
                bool? bn_ = context.Operators.In<CqlDate>(bj_, bm_, (string)default);
                bool? bo_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? bp_ = context.Operators.And(bn_, bo_);
                return bp_;
            }

            bool? bf_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)bd_, be_);
            return bf_;
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
