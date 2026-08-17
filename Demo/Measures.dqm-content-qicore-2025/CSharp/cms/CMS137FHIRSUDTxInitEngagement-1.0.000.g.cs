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
                    bool? x_ = context.Operators.In<CqlDateTime>(w_, s_, (string)default);
                    u_ = t_ & x_;
                }
                // CQL 'and' (41:19-44:37): right operand skipped when left is false
                if (u_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                    CqlDateTime z_ = context.Operators.Start(y_);
                    CqlDateTime aa_ = context.Operators.End(q_);
                    CqlQuantity ab_ = context.Operators.Quantity(47m, "days");
                    CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
                    bool? ad_ = context.Operators.SameOrBefore(z_, ac_, "day");
                    return u_ & ad_;
                }
            }

            bool? p_ = context.Operators.WhereAny<Condition>(n_, o_);
            return p_;
        }


        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? c_(Encounter ValidEncounters) {
            Period ae_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? ai_ = (CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ, ah_, ValidEncounters);
            return ai_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> d_ = context.Operators.WhereSelect<Encounter, (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(d_);

        object f_((CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? @this) {
            CqlDate aj_ = @this?.ValidEncounterDate;
            return aj_;
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
                    aq_ = be_ as CqlDateTime;
                }
                else
                {
                    bool bg_ = be_ is CqlQuantity;
                    if (bg_)
                    {
                        aq_ = be_ as CqlQuantity;
                    }
                    else
                    {
                        bool bh_ = be_ is CqlInterval<CqlDateTime>;
                        if (bh_)
                        {
                            aq_ = be_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bi_ = be_ is CqlInterval<CqlQuantity>;
                            if (bi_)
                            {
                                aq_ = be_ as CqlInterval<CqlQuantity>;
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
                    return bc_ & (!((bool?)(aw_ is null)));
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
            IEnumerable<Condition> bj_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? bk_(Condition @this) {
                CodeableConcept bp_ = @this?.Code;
                CqlConcept bq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                return !((bool?)(bq_ is null));
            }


            CqlConcept bl_(Condition @this) {
                CodeableConcept br_ = @this?.Code;
                CqlConcept bs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, br_);
                return bs_;
            }

            IEnumerable<CqlConcept> bm_ = context.Operators.WhereSelect<Condition, CqlConcept>(bj_, bk_, bl_);
            CqlValueSet bn_ = this.Substance_Use_Disorder(context);
            bool? bo_ = context.Operators.ConceptsInValueSet(bm_, bn_);
            return bo_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        bool? t_(Encounter SUDEncounterDx) {
            Encounter bt_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bu_ = [
                bt_,
            ];

            bool? bv_(Encounter FirstSUDEpisode) {
                Period bx_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bx_);
                CqlDateTime bz_ = context.Operators.Start(by_);
                Period ca_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ca_);
                CqlDateTime cc_ = context.Operators.Start(cb_);
                CqlDate cd_ = context.Operators.DateFrom(cc_);
                CqlQuantity ce_ = context.Operators.Quantity(60m, "days");
                CqlDate cf_ = context.Operators.Subtract(cd_, ce_);
                CqlDateTime cg_ = context.Operators.ConvertDateToDateTime(cf_);
                CqlDateTime ch_ = context.Operators.ConvertDateToDateTime(cd_);
                CqlInterval<CqlDateTime> ci_ = context.Operators.Interval(cg_, ch_, true, false);
                bool? cj_ = context.Operators.In<CqlDateTime>(bz_, ci_, "day");
                // CQL 'and' (76:21-76:120): right operand skipped when left is false
                if (cj_ is false)
                {
                    return false;
                }
                else
                {
                    return cj_ & (!((bool?)(cd_ is null)));
                }
            }

            bool? bw_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bu_, bv_);
            return bw_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? x_(MedicationRequest MR) {
            IEnumerable<Medication> ck_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cl_(Medication M) {
                object cn_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object co_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cp_ = context.Operators.Split((string)co_, "/");
                string cq_ = context.Operators.Last<string>(cp_);
                bool? cr_ = context.Operators.Equal(cn_, cq_);
                // CQL 'and': right operand skipped when left is false
                if (cr_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept cs_ = M?.Code;
                    CqlConcept ct_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cs_);
                    CqlValueSet cu_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                    bool? cv_ = context.Operators.ConceptInValueSet(ct_, cu_);
                    return cr_ & cv_;
                }
            }

            bool? cm_ = context.Operators.WhereAny<Medication>(ck_, cl_);
            return cm_;
        }

        IEnumerable<MedicationRequest> y_ = context.Operators.Where<MedicationRequest>(w_, x_);
        CqlValueSet z_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);

        bool? ac_(MedicationRequest MR) {
            IEnumerable<Medication> cw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cx_(Medication M) {
                object cz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object da_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> db_ = context.Operators.Split((string)da_, "/");
                string dc_ = context.Operators.Last<string>(db_);
                bool? dd_ = context.Operators.Equal(cz_, dc_);
                // CQL 'and': right operand skipped when left is false
                if (dd_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept de_ = M?.Code;
                    CqlConcept df_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, de_);
                    CqlValueSet dg_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                    bool? dh_ = context.Operators.ConceptInValueSet(df_, dg_);
                    return dd_ & dh_;
                }
            }

            bool? cy_ = context.Operators.WhereAny<Medication>(cw_, cx_);
            return cy_;
        }

        IEnumerable<MedicationRequest> ad_ = context.Operators.Where<MedicationRequest>(w_, ac_);
        CqlValueSet ae_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ab_, ag_);
        IEnumerable<MedicationRequest> ai_ = Status_1_15_000.Instance.isMedicationOrder(context, ah_);

        bool? aj_(MedicationRequest SUDMedication) {
            Encounter di_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] dj_ = [
                di_,
            ];

            bool? dk_(Encounter FirstSUDEpisode) {
                FhirDateTime dm_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime dn_ = context.Operators.Convert<CqlDateTime>(dm_);
                Period do_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                CqlDateTime dq_ = context.Operators.Start(dp_);
                CqlDate dr_ = context.Operators.DateFrom(dq_);
                CqlQuantity ds_ = context.Operators.Quantity(60m, "days");
                CqlDate dt_ = context.Operators.Subtract(dr_, ds_);
                CqlDateTime du_ = context.Operators.ConvertDateToDateTime(dt_);
                CqlDateTime dv_ = context.Operators.ConvertDateToDateTime(dr_);
                CqlInterval<CqlDateTime> dw_ = context.Operators.Interval(du_, dv_, true, false);
                bool? dx_ = context.Operators.In<CqlDateTime>(dn_, dw_, "day");
                // CQL 'and' (82:21-82:116): right operand skipped when left is false
                if (dx_ is false)
                {
                    return false;
                }
                else
                {
                    return dx_ & (!((bool?)(dr_ is null)));
                }
            }

            bool? dl_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)dj_, dk_);
            return dl_;
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
                    m_ = z_ as CqlDateTime;
                }
                else
                {
                    bool ab_ = z_ is CqlQuantity;
                    if (ab_)
                    {
                        m_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        bool ac_ = z_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            m_ = z_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ad_ = z_ is CqlInterval<CqlQuantity>;
                            if (ad_)
                            {
                                m_ = z_ as CqlInterval<CqlQuantity>;
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
                    object ae_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "id");
                    string af_ = context.Operators.LateBoundProperty<string>(ae_, "value");
                    Id ag_ = FirstSUDEpisode?.IdElement;
                    string ah_ = ag_?.Value;
                    bool? ai_ = context.Operators.Equivalent(af_, ah_);
                    return x_ & !ai_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)j_, k_);
            return l_;
        }


        CqlDate c_(object PsychosocialVisitProcedure) {
            object aj_;
            object an_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            bool ap_ = ao_ is CqlDateTime;
            if (ap_)
            {
                aj_ = ao_ as CqlDateTime;
            }
            else
            {
                bool aq_ = ao_ is CqlQuantity;
                if (aq_)
                {
                    aj_ = ao_ as CqlQuantity;
                }
                else
                {
                    bool ar_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ar_)
                    {
                        aj_ = ao_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool as_ = ao_ is CqlInterval<CqlQuantity>;
                        if (as_)
                        {
                            aj_ = ao_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            aj_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlDate am_ = context.Operators.DateFrom(al_);
            return am_;
        }

        IEnumerable<CqlDate> d_ = context.Operators.WhereSelect<object, CqlDate>(a_, b_, c_);

        bool? e_(object PsychosocialVisitEncounter) {
            Encounter at_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] au_ = [
                at_,
            ];

            bool? av_(Encounter FirstSUDEpisode) {
                object ax_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_ as Period);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlDate ba_ = context.Operators.DateFrom(az_);
                Period bb_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                CqlDateTime bd_ = context.Operators.Start(bc_);
                CqlDate be_ = context.Operators.DateFrom(bd_);
                CqlQuantity bf_ = context.Operators.Quantity(14m, "days");
                CqlDate bg_ = context.Operators.Add(be_, bf_);
                CqlInterval<CqlDate> bh_ = context.Operators.Interval(be_, bg_, true, false);
                bool? bi_ = context.Operators.In<CqlDate>(ba_, bh_, (string)default);
                // CQL 'and' (111:21-112:67): right operand skipped when left is false
                if (bi_ is false)
                {
                    return false;
                }
                else
                {
                    object bj_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                    string bk_ = context.Operators.LateBoundProperty<string>(bj_, "value");
                    Id bl_ = FirstSUDEpisode?.IdElement;
                    string bm_ = bl_?.Value;
                    bool? bn_ = context.Operators.Equivalent(bk_, bm_);
                    return bi_ & !bn_;
                }
            }

            bool? aw_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)au_, av_);
            return aw_;
        }


        CqlDate f_(object PsychosocialVisitEncounter) {
            object bo_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_ as Period);
            CqlDateTime bq_ = context.Operators.Start(bp_);
            CqlDate br_ = context.Operators.DateFrom(bq_);
            return br_;
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
                    by_ = cl_ as CqlDateTime;
                }
                else
                {
                    bool cn_ = cl_ is CqlQuantity;
                    if (cn_)
                    {
                        by_ = cl_ as CqlQuantity;
                    }
                    else
                    {
                        bool co_ = cl_ is CqlInterval<CqlDateTime>;
                        if (co_)
                        {
                            by_ = cl_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cp_ = cl_ is CqlInterval<CqlQuantity>;
                            if (cp_)
                            {
                                by_ = cl_ as CqlInterval<CqlQuantity>;
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
            object cq_;
            DataType cu_ = SUDMedAdministration?.Performed;
            object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
            bool cw_ = cv_ is CqlDateTime;
            if (cw_)
            {
                cq_ = cv_ as CqlDateTime;
            }
            else
            {
                bool cx_ = cv_ is CqlQuantity;
                if (cx_)
                {
                    cq_ = cv_ as CqlQuantity;
                }
                else
                {
                    bool cy_ = cv_ is CqlInterval<CqlDateTime>;
                    if (cy_)
                    {
                        cq_ = cv_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cz_ = cv_ is CqlInterval<CqlQuantity>;
                        if (cz_)
                        {
                            cq_ = cv_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cr_ = QICoreCommon_4_0_000.Instance.toInterval(context, cq_);
            CqlDateTime cs_ = context.Operators.Start(cr_);
            CqlDate ct_ = context.Operators.DateFrom(cs_);
            return ct_;
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
                    object ar_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
                    CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_ as Period);
                    CqlDateTime at_ = context.Operators.Start(as_);
                    CqlDate au_ = context.Operators.DateFrom(at_);
                    bool? av_ = context.Operators.In<CqlDate>(au_, ai_, (string)default);
                    return ak_ | (/* CQL 'and' (151:16-151:107) */ (av_ is false
                        ? false
                        : av_ & (!((bool?)(InitiationTreatmentDate is null)))));
                }
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)z_, aa_);
            return ab_;
        }

        object g_(object ShortActingTreatment) => ShortActingTreatment;
        IEnumerable<object> h_ = context.Operators.WhereSelect<object, object>(e_, f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? j_(MedicationRequest MR) {
            IEnumerable<Medication> aw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ax_(Medication M) {
                object az_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ba_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bb_ = context.Operators.Split((string)ba_, "/");
                string bc_ = context.Operators.Last<string>(bb_);
                bool? bd_ = context.Operators.Equal(az_, bc_);
                // CQL 'and': right operand skipped when left is false
                if (bd_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept be_ = M?.Code;
                    CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_);
                    CqlValueSet bg_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                    bool? bh_ = context.Operators.ConceptInValueSet(bf_, bg_);
                    return bd_ & bh_;
                }
            }

            bool? ay_ = context.Operators.WhereAny<Medication>(aw_, ax_);
            return ay_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
        CqlValueSet l_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);
        IEnumerable<MedicationRequest> o_ = Status_1_15_000.Instance.isMedicationOrder(context, n_);

        bool? p_(MedicationRequest ShortActingMedOrder) {
            IEnumerable<CqlDate> bi_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> bj_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> bk_ = context.Operators.Union<CqlDate>(bi_, bj_);
            CqlDate bl_ = context.Operators.Min<CqlDate>(bk_);
            CqlDate[] bm_ = [
                bl_,
            ];

            bool? bn_(CqlDate InitiationTreatmentDate) {
                FhirDateTime bp_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime bq_ = context.Operators.Convert<CqlDateTime>(bp_);
                CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                CqlDateTime bs_ = context.Operators.Start(br_);
                CqlDate bt_ = context.Operators.DateFrom(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(34m, "days");
                CqlDate bv_ = context.Operators.Add(InitiationTreatmentDate, bu_);
                CqlInterval<CqlDate> bw_ = context.Operators.Interval(InitiationTreatmentDate, bv_, false, true);
                bool? bx_ = context.Operators.In<CqlDate>(bt_, bw_, (string)default);
                return /* CQL 'and' (158:23-158:130) */ (bx_ is false
                    ? false
                    : bx_ & (!((bool?)(InitiationTreatmentDate is null))));
            }

            bool? bo_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)bm_, bn_);
            return bo_;
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
                    az_ = bi_ as CqlDateTime;
                }
                else
                {
                    bool bk_ = bi_ is CqlQuantity;
                    if (bk_)
                    {
                        az_ = bi_ as CqlQuantity;
                    }
                    else
                    {
                        bool bl_ = bi_ is CqlInterval<CqlDateTime>;
                        if (bl_)
                        {
                            az_ = bi_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bm_ = bi_ is CqlInterval<CqlQuantity>;
                            if (bm_)
                            {
                                az_ = bi_ as CqlInterval<CqlQuantity>;
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
