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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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

                bool? u_() {
                    CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                    CqlDateTime x_ = context.Operators.Start(w_);
                    Period y_ = ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                    bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, (string)default);
                    return (bool?)((CqlBoolean)aa_);
                }


                bool? v_() {
                    CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    CqlQuantity af_ = context.Operators.Quantity(47m, "days");
                    CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                    bool? ah_ = context.Operators.SameOrBefore(ac_, ag_, "day");
                    return (bool?)((CqlBoolean)ah_);
                }

                return (bool?)(/* CQL 'and' (41:19-44:37) */ (/* CQL 'and' (41:19-42:84) */ ((CqlBoolean)t_
                    && (CqlBoolean)u_())
                    && (CqlBoolean)v_()));
            }

            bool? p_ = context.Operators.WhereAny<Condition>(n_, o_);
            return p_;
        }


        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? c_(Encounter ValidEncounters) {
            Period ai_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
            CqlDateTime ak_ = context.Operators.Start(aj_);
            CqlDate al_ = context.Operators.DateFrom(ak_);
            (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? am_ = (CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ, al_, ValidEncounters);
            return am_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> d_ = context.Operators.WhereSelect<Encounter, (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(d_);

        object f_((CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? @this) {
            CqlDate an_ = @this?.ValidEncounterDate;
            return an_;
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
                DataType be_ = Interventions?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlDateTime;
                if (bg_)
                {
                    aq_ = bf_ as CqlDateTime;
                }
                else
                {
                    bool bh_ = bf_ is CqlQuantity;
                    if (bh_)
                    {
                        aq_ = bf_ as CqlQuantity;
                    }
                    else
                    {
                        bool bi_ = bf_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            aq_ = bf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bj_ = bf_ is CqlInterval<CqlQuantity>;
                            if (bj_)
                            {
                                aq_ = bf_ as CqlInterval<CqlQuantity>;
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

                bool? bd_() {
                    Period bk_ = FirstSUDEpisode?.Period;
                    CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                    CqlDateTime bm_ = context.Operators.Start(bl_);
                    CqlDate bn_ = context.Operators.DateFrom(bm_);
                    return (bool?)((CqlBoolean)(!((bool?)(bn_ is null))));
                }

                return (bool?)(/* CQL 'and' (70:19-70:135) */ ((CqlBoolean)bc_
                    && (CqlBoolean)bd_()));
            }

            bool? ap_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)an_, ao_);
            return ap_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> p_ = this.Emergency_Department_or_Detoxification_Visit(context);
        IEnumerable<Encounter> q_ = context.Operators.Except<Encounter>(o_, p_);

        bool? r_(Encounter QualifyingEncounter) {
            IEnumerable<Condition> bo_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? bp_(Condition @this) {
                CodeableConcept bu_ = @this?.Code;
                CqlConcept bv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bu_);
                return !((bool?)(bv_ is null));
            }


            CqlConcept bq_(Condition @this) {
                CodeableConcept bw_ = @this?.Code;
                CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                return bx_;
            }

            IEnumerable<CqlConcept> br_ = context.Operators.WhereSelect<Condition, CqlConcept>(bo_, bp_, bq_);
            CqlValueSet bs_ = this.Substance_Use_Disorder(context);
            bool? bt_ = context.Operators.ConceptsInValueSet(br_, bs_);
            return bt_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        bool? t_(Encounter SUDEncounterDx) {
            Encounter by_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bz_ = [
                by_,
            ];

            bool? ca_(Encounter FirstSUDEpisode) {
                Period cc_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                Period cf_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cf_);
                CqlDateTime ch_ = context.Operators.Start(cg_);
                CqlDate ci_ = context.Operators.DateFrom(ch_);
                CqlQuantity cj_ = context.Operators.Quantity(60m, "days");
                CqlDate ck_ = context.Operators.Subtract(ci_, cj_);
                CqlDateTime cl_ = context.Operators.ConvertDateToDateTime(ck_);
                CqlDateTime cm_ = context.Operators.ConvertDateToDateTime(ci_);
                CqlInterval<CqlDateTime> cn_ = context.Operators.Interval(cl_, cm_, true, false);
                bool? co_ = context.Operators.In<CqlDateTime>(ce_, cn_, "day");

                bool? cp_() {
                    Period cq_ = FirstSUDEpisode?.Period;
                    CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_);
                    CqlDateTime cs_ = context.Operators.Start(cr_);
                    CqlDate ct_ = context.Operators.DateFrom(cs_);
                    return (bool?)((CqlBoolean)(!((bool?)(ct_ is null))));
                }

                return (bool?)(/* CQL 'and' (76:21-76:120) */ ((CqlBoolean)co_
                    && (CqlBoolean)cp_()));
            }

            bool? cb_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bz_, ca_);
            return cb_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? x_(MedicationRequest MR) {
            IEnumerable<Medication> cu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cv_(Medication M) {
                object cx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cy_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cz_ = context.Operators.Split((string)cy_, "/");
                string da_ = context.Operators.Last<string>(cz_);
                bool? db_ = context.Operators.Equal(cx_, da_);

                bool? dc_() {
                    CodeableConcept dd_ = M?.Code;
                    CqlConcept de_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dd_);
                    CqlValueSet df_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                    bool? dg_ = context.Operators.ConceptInValueSet(de_, df_);
                    return (bool?)((CqlBoolean)dg_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)db_
                    && (CqlBoolean)dc_()));
            }

            bool? cw_ = context.Operators.WhereAny<Medication>(cu_, cv_);
            return cw_;
        }

        IEnumerable<MedicationRequest> y_ = context.Operators.Where<MedicationRequest>(w_, x_);
        CqlValueSet z_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);

        bool? ac_(MedicationRequest MR) {
            IEnumerable<Medication> dh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? di_(Medication M) {
                object dk_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dl_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dm_ = context.Operators.Split((string)dl_, "/");
                string dn_ = context.Operators.Last<string>(dm_);
                bool? do_ = context.Operators.Equal(dk_, dn_);

                bool? dp_() {
                    CodeableConcept dq_ = M?.Code;
                    CqlConcept dr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dq_);
                    CqlValueSet ds_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                    bool? dt_ = context.Operators.ConceptInValueSet(dr_, ds_);
                    return (bool?)((CqlBoolean)dt_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)do_
                    && (CqlBoolean)dp_()));
            }

            bool? dj_ = context.Operators.WhereAny<Medication>(dh_, di_);
            return dj_;
        }

        IEnumerable<MedicationRequest> ad_ = context.Operators.Where<MedicationRequest>(w_, ac_);
        CqlValueSet ae_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ab_, ag_);
        IEnumerable<MedicationRequest> ai_ = Status_1_15_000.Instance.isMedicationOrder(context, ah_);

        bool? aj_(MedicationRequest SUDMedication) {
            Encounter du_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] dv_ = [
                du_,
            ];

            bool? dw_(Encounter FirstSUDEpisode) {
                FhirDateTime dy_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime dz_ = context.Operators.Convert<CqlDateTime>(dy_);
                Period ea_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                CqlDateTime ec_ = context.Operators.Start(eb_);
                CqlDate ed_ = context.Operators.DateFrom(ec_);
                CqlQuantity ee_ = context.Operators.Quantity(60m, "days");
                CqlDate ef_ = context.Operators.Subtract(ed_, ee_);
                CqlDateTime eg_ = context.Operators.ConvertDateToDateTime(ef_);
                CqlDateTime eh_ = context.Operators.ConvertDateToDateTime(ed_);
                CqlInterval<CqlDateTime> ei_ = context.Operators.Interval(eg_, eh_, true, false);
                bool? ej_ = context.Operators.In<CqlDateTime>(dz_, ei_, "day");

                bool? ek_() {
                    Period el_ = FirstSUDEpisode?.Period;
                    CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                    CqlDateTime en_ = context.Operators.Start(em_);
                    CqlDate eo_ = context.Operators.DateFrom(en_);
                    return (bool?)((CqlBoolean)(!((bool?)(eo_ is null))));
                }

                return (bool?)(/* CQL 'and' (82:21-82:116) */ ((CqlBoolean)ej_
                    && (CqlBoolean)ek_()));
            }

            bool? dx_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)dv_, dw_);
            return dx_;
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

        bool? j_() {
            IEnumerable<object> k_ = this.History_of_SUD_Diagnosis_or_Treatment(context);
            bool? l_ = context.Operators.Exists<object>(k_);
            return (bool?)((CqlBoolean)!l_);
        }

        return (bool?)(/* CQL 'and' (34:3-36:58) */ (/* CQL 'and' (34:3-35:65) */ ((CqlBoolean)i_
            && (CqlBoolean)(!((bool?)((this.First_SUD_Episode_During_Measurement_Period(context)) is null))))
            && (CqlBoolean)j_()));
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
                object z_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlDateTime;
                if (ab_)
                {
                    m_ = aa_ as CqlDateTime;
                }
                else
                {
                    bool ac_ = aa_ is CqlQuantity;
                    if (ac_)
                    {
                        m_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        bool ad_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            m_ = aa_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ae_ = aa_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                m_ = aa_ as CqlInterval<CqlQuantity>;
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

                bool? y_() {
                    object af_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "id");
                    string ag_ = context.Operators.LateBoundProperty<string>(af_, "value");
                    Id ah_ = FirstSUDEpisode?.IdElement;
                    string ai_ = ah_?.Value;
                    bool? aj_ = context.Operators.Equivalent(ag_, ai_);
                    return (bool?)((CqlBoolean)!aj_);
                }

                return (bool?)(/* CQL 'and' (104:19-105:65) */ ((CqlBoolean)x_
                    && (CqlBoolean)y_()));
            }

            bool? l_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)j_, k_);
            return l_;
        }


        CqlDate c_(object PsychosocialVisitProcedure) {
            object ak_;
            object ao_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            bool aq_ = ap_ is CqlDateTime;
            if (aq_)
            {
                ak_ = ap_ as CqlDateTime;
            }
            else
            {
                bool ar_ = ap_ is CqlQuantity;
                if (ar_)
                {
                    ak_ = ap_ as CqlQuantity;
                }
                else
                {
                    bool as_ = ap_ is CqlInterval<CqlDateTime>;
                    if (as_)
                    {
                        ak_ = ap_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool at_ = ap_ is CqlInterval<CqlQuantity>;
                        if (at_)
                        {
                            ak_ = ap_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ak_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            return an_;
        }

        IEnumerable<CqlDate> d_ = context.Operators.WhereSelect<object, CqlDate>(a_, b_, c_);

        bool? e_(object PsychosocialVisitEncounter) {
            Encounter au_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] av_ = [
                au_,
            ];

            bool? aw_(Encounter FirstSUDEpisode) {
                object ay_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_ as Period);
                CqlDateTime ba_ = context.Operators.Start(az_);
                CqlDate bb_ = context.Operators.DateFrom(ba_);
                Period bc_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                CqlDate bf_ = context.Operators.DateFrom(be_);
                CqlQuantity bg_ = context.Operators.Quantity(14m, "days");
                CqlDate bh_ = context.Operators.Add(bf_, bg_);
                CqlInterval<CqlDate> bi_ = context.Operators.Interval(bf_, bh_, true, false);
                bool? bj_ = context.Operators.In<CqlDate>(bb_, bi_, (string)default);

                bool? bk_() {
                    object bl_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                    string bm_ = context.Operators.LateBoundProperty<string>(bl_, "value");
                    Id bn_ = FirstSUDEpisode?.IdElement;
                    string bo_ = bn_?.Value;
                    bool? bp_ = context.Operators.Equivalent(bm_, bo_);
                    return (bool?)((CqlBoolean)!bp_);
                }

                return (bool?)(/* CQL 'and' (111:21-112:67) */ ((CqlBoolean)bj_
                    && (CqlBoolean)bk_()));
            }

            bool? ax_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)av_, aw_);
            return ax_;
        }


        CqlDate f_(object PsychosocialVisitEncounter) {
            object bq_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_ as Period);
            CqlDateTime bs_ = context.Operators.Start(br_);
            CqlDate bt_ = context.Operators.DateFrom(bs_);
            return bt_;
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

                bool? ai_() {
                    CodeableConcept aj_ = M?.Code;
                    CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                    CqlValueSet al_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                    bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
                    return (bool?)((CqlBoolean)am_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)ah_
                    && (CqlBoolean)ai_()));
            }

            bool? ac_ = context.Operators.WhereAny<Medication>(aa_, ab_);
            return ac_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> an_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ao_(Medication M) {
                object aq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ar_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> as_ = context.Operators.Split((string)ar_, "/");
                string at_ = context.Operators.Last<string>(as_);
                bool? au_ = context.Operators.Equal(aq_, at_);

                bool? av_() {
                    CodeableConcept aw_ = M?.Code;
                    CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aw_);
                    CqlValueSet ay_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                    bool? az_ = context.Operators.ConceptInValueSet(ax_, ay_);
                    return (bool?)((CqlBoolean)az_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)au_
                    && (CqlBoolean)av_()));
            }

            bool? ap_ = context.Operators.WhereAny<Medication>(an_, ao_);
            return ap_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        IEnumerable<MedicationRequest> m_ = Status_1_15_000.Instance.isMedicationOrder(context, l_);

        bool? n_(MedicationRequest SUDMedication) {
            Encounter ba_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bb_ = [
                ba_,
            ];

            bool? bc_(Encounter FirstSUDEpisode) {
                FhirDateTime be_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlDate bi_ = context.Operators.DateFrom(bh_);
                Period bj_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlDate bm_ = context.Operators.DateFrom(bl_);
                CqlQuantity bn_ = context.Operators.Quantity(14m, "days");
                CqlDate bo_ = context.Operators.Add(bm_, bn_);
                CqlInterval<CqlDate> bp_ = context.Operators.Interval(bm_, bo_, true, false);
                bool? bq_ = context.Operators.In<CqlDate>(bi_, bp_, (string)default);
                return bq_;
            }

            bool? bd_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bb_, bc_);
            return bd_;
        }


        CqlDate o_(MedicationRequest SUDMedication) {
            FhirDateTime br_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime bs_ = context.Operators.Convert<CqlDateTime>(br_);
            CqlInterval<CqlDateTime> bt_ = QICoreCommon_4_0_000.Instance.toInterval(context, bs_);
            CqlDateTime bu_ = context.Operators.Start(bt_);
            CqlDate bv_ = context.Operators.DateFrom(bu_);
            return bv_;
        }

        IEnumerable<CqlDate> p_ = context.Operators.WhereSelect<MedicationRequest, CqlDate>(m_, n_, o_);
        CqlValueSet q_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet s_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
        IEnumerable<Procedure> v_ = Status_1_15_000.Instance.isProcedurePerformed(context, u_);

        bool? w_(Procedure SUDMedAdministration) {
            Encounter bw_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bx_ = [
                bw_,
            ];

            bool? by_(Encounter FirstSUDEpisode) {
                object ca_;
                DataType cm_ = SUDMedAdministration?.Performed;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                bool co_ = cn_ is CqlDateTime;
                if (co_)
                {
                    ca_ = cn_ as CqlDateTime;
                }
                else
                {
                    bool cp_ = cn_ is CqlQuantity;
                    if (cp_)
                    {
                        ca_ = cn_ as CqlQuantity;
                    }
                    else
                    {
                        bool cq_ = cn_ is CqlInterval<CqlDateTime>;
                        if (cq_)
                        {
                            ca_ = cn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cr_ = cn_ is CqlInterval<CqlQuantity>;
                            if (cr_)
                            {
                                ca_ = cn_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ca_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                CqlDateTime cc_ = context.Operators.Start(cb_);
                CqlDate cd_ = context.Operators.DateFrom(cc_);
                Period ce_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ce_);
                CqlDateTime cg_ = context.Operators.Start(cf_);
                CqlDate ch_ = context.Operators.DateFrom(cg_);
                CqlQuantity ci_ = context.Operators.Quantity(14m, "days");
                CqlDate cj_ = context.Operators.Add(ch_, ci_);
                CqlInterval<CqlDate> ck_ = context.Operators.Interval(ch_, cj_, true, false);
                bool? cl_ = context.Operators.In<CqlDate>(cd_, ck_, (string)default);
                return cl_;
            }

            bool? bz_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bx_, by_);
            return bz_;
        }


        CqlDate x_(Procedure SUDMedAdministration) {
            object cs_;
            DataType cw_ = SUDMedAdministration?.Performed;
            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
            bool cy_ = cx_ is CqlDateTime;
            if (cy_)
            {
                cs_ = cx_ as CqlDateTime;
            }
            else
            {
                bool cz_ = cx_ is CqlQuantity;
                if (cz_)
                {
                    cs_ = cx_ as CqlQuantity;
                }
                else
                {
                    bool da_ = cx_ is CqlInterval<CqlDateTime>;
                    if (da_)
                    {
                        cs_ = cx_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool db_ = cx_ is CqlInterval<CqlQuantity>;
                        if (db_)
                        {
                            cs_ = cx_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cs_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ct_ = QICoreCommon_4_0_000.Instance.toInterval(context, cs_);
            CqlDateTime cu_ = context.Operators.Start(ct_);
            CqlDate cv_ = context.Operators.DateFrom(cu_);
            return cv_;
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

        bool? c_() {
            IEnumerable<CqlDate> d_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            bool? e_ = context.Operators.Exists<CqlDate>(d_);
            return (bool?)((CqlBoolean)e_);
        }

        return (bool?)(/* CQL 'or' (97:3-98:64) */ ((CqlBoolean)b_
            || (CqlBoolean)c_()));
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
                    ac_ = am_ as CqlDateTime;
                }
                else
                {
                    bool ao_ = am_ is CqlQuantity;
                    if (ao_)
                    {
                        ac_ = am_ as CqlQuantity;
                    }
                    else
                    {
                        bool ap_ = am_ is CqlInterval<CqlDateTime>;
                        if (ap_)
                        {
                            ac_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aq_ = am_ is CqlInterval<CqlQuantity>;
                            if (aq_)
                            {
                                ac_ = am_ as CqlInterval<CqlQuantity>;
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

                bool? ak_() {
                    object ar_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
                    CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_ as Period);
                    CqlDateTime at_ = context.Operators.Start(as_);
                    CqlDate au_ = context.Operators.DateFrom(at_);
                    CqlQuantity av_ = context.Operators.Quantity(34m, "days");
                    CqlDate aw_ = context.Operators.Add(InitiationTreatmentDate, av_);
                    CqlInterval<CqlDate> ax_ = context.Operators.Interval(InitiationTreatmentDate, aw_, false, true);
                    bool? ay_ = context.Operators.In<CqlDate>(au_, ax_, (string)default);
                    return (bool?)(/* CQL 'and' (151:16-151:107) */ ((CqlBoolean)ay_
                        && (CqlBoolean)(!((bool?)(InitiationTreatmentDate is null)))));
                }

                return (bool?)(/* CQL 'or' (150:21-151:107) */ (/* CQL 'and' (150:21-150:128) */ ((CqlBoolean)aj_
                    && (CqlBoolean)(!((bool?)(InitiationTreatmentDate is null))))
                    || (CqlBoolean)ak_()));
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)z_, aa_);
            return ab_;
        }

        object g_(object ShortActingTreatment) => ShortActingTreatment;
        IEnumerable<object> h_ = context.Operators.WhereSelect<object, object>(e_, f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? j_(MedicationRequest MR) {
            IEnumerable<Medication> az_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ba_(Medication M) {
                object bc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> be_ = context.Operators.Split((string)bd_, "/");
                string bf_ = context.Operators.Last<string>(be_);
                bool? bg_ = context.Operators.Equal(bc_, bf_);

                bool? bh_() {
                    CodeableConcept bi_ = M?.Code;
                    CqlConcept bj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bi_);
                    CqlValueSet bk_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                    bool? bl_ = context.Operators.ConceptInValueSet(bj_, bk_);
                    return (bool?)((CqlBoolean)bl_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)bg_
                    && (CqlBoolean)bh_()));
            }

            bool? bb_ = context.Operators.WhereAny<Medication>(az_, ba_);
            return bb_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
        CqlValueSet l_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);
        IEnumerable<MedicationRequest> o_ = Status_1_15_000.Instance.isMedicationOrder(context, n_);

        bool? p_(MedicationRequest ShortActingMedOrder) {
            IEnumerable<CqlDate> bm_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> bn_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> bo_ = context.Operators.Union<CqlDate>(bm_, bn_);
            CqlDate bp_ = context.Operators.Min<CqlDate>(bo_);
            CqlDate[] bq_ = [
                bp_,
            ];

            bool? br_(CqlDate InitiationTreatmentDate) {
                FhirDateTime bt_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
                CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                CqlDate bx_ = context.Operators.DateFrom(bw_);
                CqlQuantity by_ = context.Operators.Quantity(34m, "days");
                CqlDate bz_ = context.Operators.Add(InitiationTreatmentDate, by_);
                CqlInterval<CqlDate> ca_ = context.Operators.Interval(InitiationTreatmentDate, bz_, false, true);
                bool? cb_ = context.Operators.In<CqlDate>(bx_, ca_, (string)default);
                return (bool?)(/* CQL 'and' (158:23-158:130) */ ((CqlBoolean)cb_
                    && (CqlBoolean)(!((bool?)(InitiationTreatmentDate is null)))));
            }

            bool? bs_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)bq_, br_);
            return bs_;
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

                bool? y_() {
                    CodeableConcept z_ = M?.Code;
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                    CqlValueSet ab_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                    bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                    return (bool?)((CqlBoolean)ac_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)x_
                    && (CqlBoolean)y_()));
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
            IEnumerable<CqlDate> ad_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ae_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> af_ = context.Operators.Union<CqlDate>(ad_, ae_);
            CqlDate ag_ = context.Operators.Min<CqlDate>(af_);
            CqlDate[] ah_ = [
                ag_,
            ];

            bool? ai_(CqlDate InitiationTreatmentDate) {
                FhirDateTime ak_ = LongActingMedOrder?.AuthoredOnElement;
                CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                CqlQuantity ap_ = context.Operators.Quantity(34m, "days");
                CqlDate aq_ = context.Operators.Add(InitiationTreatmentDate, ap_);
                CqlInterval<CqlDate> ar_ = context.Operators.Interval(InitiationTreatmentDate, aq_, false, true);
                bool? as_ = context.Operators.In<CqlDate>(ao_, ar_, (string)default);
                return (bool?)(/* CQL 'and' (172:21-172:129) */ ((CqlBoolean)as_
                    && (CqlBoolean)(!((bool?)(InitiationTreatmentDate is null)))));
            }

            bool? aj_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)ah_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isProcedurePerformed(context, k_);

        bool? m_(Procedure LongActingTreatment) {
            IEnumerable<CqlDate> at_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> au_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> av_ = context.Operators.Union<CqlDate>(at_, au_);
            CqlDate aw_ = context.Operators.Min<CqlDate>(av_);
            CqlDate[] ax_ = [
                aw_,
            ];

            bool? ay_(CqlDate InitiationTreatmentDate) {
                object ba_;
                DataType bi_ = LongActingTreatment?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlDateTime;
                if (bk_)
                {
                    ba_ = bj_ as CqlDateTime;
                }
                else
                {
                    bool bl_ = bj_ is CqlQuantity;
                    if (bl_)
                    {
                        ba_ = bj_ as CqlQuantity;
                    }
                    else
                    {
                        bool bm_ = bj_ is CqlInterval<CqlDateTime>;
                        if (bm_)
                        {
                            ba_ = bj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bn_ = bj_ is CqlInterval<CqlQuantity>;
                            if (bn_)
                            {
                                ba_ = bj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ba_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlDate bd_ = context.Operators.DateFrom(bc_);
                CqlQuantity be_ = context.Operators.Quantity(34m, "days");
                CqlDate bf_ = context.Operators.Add(InitiationTreatmentDate, be_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(InitiationTreatmentDate, bf_, false, true);
                bool? bh_ = context.Operators.In<CqlDate>(bd_, bg_, (string)default);
                return (bool?)(/* CQL 'and' (178:23-178:131) */ ((CqlBoolean)bh_
                    && (CqlBoolean)(!((bool?)(InitiationTreatmentDate is null)))));
            }

            bool? az_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)ax_, ay_);
            return az_;
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
        return (bool?)(/* CQL 'or' (164:3-165:106) */ ((CqlBoolean)a_
            || (CqlBoolean)(this.Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention(context))));
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
