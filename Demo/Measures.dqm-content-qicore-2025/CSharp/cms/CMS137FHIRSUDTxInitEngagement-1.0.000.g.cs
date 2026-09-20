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
                    aq_ = bg_ as CqlDateTime;
                }
                else
                {
                    bool bi_ = bg_ is CqlQuantity;
                    if (bi_)
                    {
                        aq_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        bool bj_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            aq_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bk_ = bg_ is CqlInterval<CqlQuantity>;
                            if (bk_)
                            {
                                aq_ = bg_ as CqlInterval<CqlQuantity>;
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
            IEnumerable<Condition> bl_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? bm_(Condition @this) {
                CodeableConcept br_ = @this?.Code;
                CqlConcept bs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, br_);
                bool? bt_ = context.Operators.Not((bool?)(bs_ is null));
                return bt_;
            }


            CqlConcept bn_(Condition @this) {
                CodeableConcept bu_ = @this?.Code;
                CqlConcept bv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bu_);
                return bv_;
            }

            IEnumerable<CqlConcept> bo_ = context.Operators.WhereSelect<Condition, CqlConcept>(bl_, bm_, bn_);
            CqlValueSet bp_ = this.Substance_Use_Disorder(context);
            bool? bq_ = context.Operators.ConceptsInValueSet(bo_, bp_);
            return bq_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        bool? t_(Encounter SUDEncounterDx) {
            Encounter bw_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bx_ = [
                bw_,
            ];

            bool? by_(Encounter FirstSUDEpisode) {
                Period ca_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ca_);
                CqlDateTime cc_ = context.Operators.Start(cb_);
                Period cd_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                CqlDate cg_ = context.Operators.DateFrom(cf_);
                CqlQuantity ch_ = context.Operators.Quantity(60m, "days");
                CqlDate ci_ = context.Operators.Subtract(cg_, ch_);
                CqlDateTime cj_ = context.Operators.ConvertDateToDateTime(ci_);
                CqlDateTime ck_ = context.Operators.ConvertDateToDateTime(cg_);
                CqlInterval<CqlDateTime> cl_ = context.Operators.Interval(cj_, ck_, true, false);
                bool? cm_ = context.Operators.In<CqlDateTime>(cc_, cl_, "day");
                bool? cn_ = context.Operators.Not((bool?)(cg_ is null));
                bool? co_ = context.Operators.And(cm_, cn_);
                return co_;
            }

            bool? bz_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bx_, by_);
            return bz_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? x_(MedicationRequest MR) {
            IEnumerable<Medication> cp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cq_(Medication M) {
                Id cs_ = M?.IdElement;
                string ct_ = cs_?.Value;
                FhirString cu_;
                DataType de_ = MR?.Medication;
                bool df_ = de_ is ResourceReference;
                if (df_)
                {
                    FhirString dg_ = (de_ as ResourceReference)?.ReferenceElement;
                    cu_ = dg_;
                }
                else
                {
                    cu_ = default;
                }
                string cv_ = cu_?.Value;
                IEnumerable<string> cw_ = context.Operators.Split(cv_, "/");
                string cx_ = context.Operators.Last<string>(cw_);
                bool? cy_ = context.Operators.Equal(ct_, cx_);
                CodeableConcept cz_ = M?.Code;
                CqlConcept da_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cz_);
                CqlValueSet db_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? dc_ = context.Operators.ConceptInValueSet(da_, db_);
                bool? dd_ = context.Operators.And(cy_, dc_);
                return dd_;
            }

            bool? cr_ = context.Operators.WhereAny<Medication>(cp_, cq_);
            return cr_;
        }

        IEnumerable<MedicationRequest> y_ = context.Operators.Where<MedicationRequest>(w_, x_);
        CqlValueSet z_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);

        bool? ac_(MedicationRequest MR) {
            IEnumerable<Medication> dh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? di_(Medication M) {
                Id dk_ = M?.IdElement;
                string dl_ = dk_?.Value;
                FhirString dm_;
                DataType dw_ = MR?.Medication;
                bool dx_ = dw_ is ResourceReference;
                if (dx_)
                {
                    FhirString dy_ = (dw_ as ResourceReference)?.ReferenceElement;
                    dm_ = dy_;
                }
                else
                {
                    dm_ = default;
                }
                string dn_ = dm_?.Value;
                IEnumerable<string> do_ = context.Operators.Split(dn_, "/");
                string dp_ = context.Operators.Last<string>(do_);
                bool? dq_ = context.Operators.Equal(dl_, dp_);
                CodeableConcept dr_ = M?.Code;
                CqlConcept ds_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dr_);
                CqlValueSet dt_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? du_ = context.Operators.ConceptInValueSet(ds_, dt_);
                bool? dv_ = context.Operators.And(dq_, du_);
                return dv_;
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
            Encounter dz_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ea_ = [
                dz_,
            ];

            bool? eb_(Encounter FirstSUDEpisode) {
                FhirDateTime ed_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime ee_ = context.Operators.Convert<CqlDateTime>(ed_);
                Period ef_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                CqlDateTime eh_ = context.Operators.Start(eg_);
                CqlDate ei_ = context.Operators.DateFrom(eh_);
                CqlQuantity ej_ = context.Operators.Quantity(60m, "days");
                CqlDate ek_ = context.Operators.Subtract(ei_, ej_);
                CqlDateTime el_ = context.Operators.ConvertDateToDateTime(ek_);
                CqlDateTime em_ = context.Operators.ConvertDateToDateTime(ei_);
                CqlInterval<CqlDateTime> en_ = context.Operators.Interval(el_, em_, true, false);
                bool? eo_ = context.Operators.In<CqlDateTime>(ee_, en_, "day");
                bool? ep_ = context.Operators.Not((bool?)(ei_ is null));
                bool? eq_ = context.Operators.And(eo_, ep_);
                return eq_;
            }

            bool? ec_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)ea_, eb_);
            return ec_;
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
                object af_;
                if (PsychosocialVisitProcedure is Procedure)
                {
                    DataType ai_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                    af_ = ai_;
                }
                else
                {
                    af_ = null;
                }
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    object aj_;
                    if (PsychosocialVisitProcedure is Procedure)
                    {
                        DataType al_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                        aj_ = al_;
                    }
                    else
                    {
                        aj_ = null;
                    }
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    m_ = ak_ as CqlDateTime;
                }
                else
                {
                    object am_;
                    if (PsychosocialVisitProcedure is Procedure)
                    {
                        DataType ap_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                        am_ = ap_;
                    }
                    else
                    {
                        am_ = null;
                    }
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlQuantity;
                    if (ao_)
                    {
                        object aq_;
                        if (PsychosocialVisitProcedure is Procedure)
                        {
                            DataType as_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                            aq_ = as_;
                        }
                        else
                        {
                            aq_ = null;
                        }
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        m_ = ar_ as CqlQuantity;
                    }
                    else
                    {
                        object at_;
                        if (PsychosocialVisitProcedure is Procedure)
                        {
                            DataType aw_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                            at_ = aw_;
                        }
                        else
                        {
                            at_ = null;
                        }
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlDateTime>;
                        if (av_)
                        {
                            object ax_;
                            if (PsychosocialVisitProcedure is Procedure)
                            {
                                DataType az_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                                ax_ = az_;
                            }
                            else
                            {
                                ax_ = null;
                            }
                            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                            m_ = ay_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object ba_;
                            if (PsychosocialVisitProcedure is Procedure)
                            {
                                DataType bd_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                                ba_ = bd_;
                            }
                            else
                            {
                                ba_ = null;
                            }
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                            if (bc_)
                            {
                                object be_;
                                if (PsychosocialVisitProcedure is Procedure)
                                {
                                    DataType bg_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                                    be_ = bg_;
                                }
                                else
                                {
                                    be_ = null;
                                }
                                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                m_ = bf_ as CqlInterval<CqlQuantity>;
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
                Id y_;
                if (PsychosocialVisitProcedure is Encounter)
                {
                    Id bh_ = (PsychosocialVisitProcedure as Encounter)?.IdElement;
                    y_ = bh_;
                }
                else if (PsychosocialVisitProcedure is Procedure)
                {
                    Id bi_ = (PsychosocialVisitProcedure as Procedure)?.IdElement;
                    y_ = bi_;
                }
                else
                {
                    y_ = default;
                }
                string z_ = y_?.Value;
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
            object bj_;
            object bn_;
            if (PsychosocialVisitProcedure is Procedure)
            {
                DataType bq_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                bn_ = bq_;
            }
            else
            {
                bn_ = null;
            }
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            bool bp_ = bo_ is CqlDateTime;
            if (bp_)
            {
                object br_;
                if (PsychosocialVisitProcedure is Procedure)
                {
                    DataType bt_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                    br_ = bt_;
                }
                else
                {
                    br_ = null;
                }
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                bj_ = bs_ as CqlDateTime;
            }
            else
            {
                object bu_;
                if (PsychosocialVisitProcedure is Procedure)
                {
                    DataType bx_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                    bu_ = bx_;
                }
                else
                {
                    bu_ = null;
                }
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool bw_ = bv_ is CqlQuantity;
                if (bw_)
                {
                    object by_;
                    if (PsychosocialVisitProcedure is Procedure)
                    {
                        DataType ca_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                        by_ = ca_;
                    }
                    else
                    {
                        by_ = null;
                    }
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bj_ = bz_ as CqlQuantity;
                }
                else
                {
                    object cb_;
                    if (PsychosocialVisitProcedure is Procedure)
                    {
                        DataType ce_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                        cb_ = ce_;
                    }
                    else
                    {
                        cb_ = null;
                    }
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        object cf_;
                        if (PsychosocialVisitProcedure is Procedure)
                        {
                            DataType ch_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                            cf_ = ch_;
                        }
                        else
                        {
                            cf_ = null;
                        }
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bj_ = cg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object ci_;
                        if (PsychosocialVisitProcedure is Procedure)
                        {
                            DataType cl_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                            ci_ = cl_;
                        }
                        else
                        {
                            ci_ = null;
                        }
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                        if (ck_)
                        {
                            object cm_;
                            if (PsychosocialVisitProcedure is Procedure)
                            {
                                DataType co_ = (PsychosocialVisitProcedure as Procedure)?.Performed;
                                cm_ = co_;
                            }
                            else
                            {
                                cm_ = null;
                            }
                            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            bj_ = cn_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bj_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
            CqlDateTime bl_ = context.Operators.Start(bk_);
            CqlDate bm_ = context.Operators.DateFrom(bl_);
            return bm_;
        }

        IEnumerable<CqlDate> d_ = context.Operators.WhereSelect<object, CqlDate>(a_, b_, c_);

        bool? e_(object PsychosocialVisitEncounter) {
            Encounter cp_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cq_ = [
                cp_,
            ];

            bool? cr_(Encounter FirstSUDEpisode) {
                Period ct_;
                if (PsychosocialVisitEncounter is Encounter)
                {
                    Period dm_ = (PsychosocialVisitEncounter as Encounter)?.Period;
                    ct_ = dm_;
                }
                else
                {
                    ct_ = default;
                }
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
                Id df_;
                if (PsychosocialVisitEncounter is Encounter)
                {
                    Id dn_ = (PsychosocialVisitEncounter as Encounter)?.IdElement;
                    df_ = dn_;
                }
                else if (PsychosocialVisitEncounter is Procedure)
                {
                    Id do_ = (PsychosocialVisitEncounter as Procedure)?.IdElement;
                    df_ = do_;
                }
                else
                {
                    df_ = default;
                }
                string dg_ = df_?.Value;
                Id dh_ = FirstSUDEpisode?.IdElement;
                string di_ = dh_?.Value;
                bool? dj_ = context.Operators.Equivalent(dg_, di_);
                bool? dk_ = context.Operators.Not(dj_);
                bool? dl_ = context.Operators.And(de_, dk_);
                return dl_;
            }

            bool? cs_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)cq_, cr_);
            return cs_;
        }


        CqlDate f_(object PsychosocialVisitEncounter) {
            Period dp_;
            if (PsychosocialVisitEncounter is Encounter)
            {
                Period dt_ = (PsychosocialVisitEncounter as Encounter)?.Period;
                dp_ = dt_;
            }
            else
            {
                dp_ = default;
            }
            CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dp_);
            CqlDateTime dr_ = context.Operators.Start(dq_);
            CqlDate ds_ = context.Operators.DateFrom(dr_);
            return ds_;
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
                FhirString af_;
                DataType ap_ = MR?.Medication;
                bool aq_ = ap_ is ResourceReference;
                if (aq_)
                {
                    FhirString ar_ = (ap_ as ResourceReference)?.ReferenceElement;
                    af_ = ar_;
                }
                else
                {
                    af_ = default;
                }
                string ag_ = af_?.Value;
                IEnumerable<string> ah_ = context.Operators.Split(ag_, "/");
                string ai_ = context.Operators.Last<string>(ah_);
                bool? aj_ = context.Operators.Equal(ae_, ai_);
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
            IEnumerable<Medication> as_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? at_(Medication M) {
                Id av_ = M?.IdElement;
                string aw_ = av_?.Value;
                FhirString ax_;
                DataType bh_ = MR?.Medication;
                bool bi_ = bh_ is ResourceReference;
                if (bi_)
                {
                    FhirString bj_ = (bh_ as ResourceReference)?.ReferenceElement;
                    ax_ = bj_;
                }
                else
                {
                    ax_ = default;
                }
                string ay_ = ax_?.Value;
                IEnumerable<string> az_ = context.Operators.Split(ay_, "/");
                string ba_ = context.Operators.Last<string>(az_);
                bool? bb_ = context.Operators.Equal(aw_, ba_);
                CodeableConcept bc_ = M?.Code;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                CqlValueSet be_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? bf_ = context.Operators.ConceptInValueSet(bd_, be_);
                bool? bg_ = context.Operators.And(bb_, bf_);
                return bg_;
            }

            bool? au_ = context.Operators.WhereAny<Medication>(as_, at_);
            return au_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        IEnumerable<MedicationRequest> m_ = Status_1_15_000.Instance.isMedicationOrder(context, l_);

        bool? n_(MedicationRequest SUDMedication) {
            Encounter bk_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bl_ = [
                bk_,
            ];

            bool? bm_(Encounter FirstSUDEpisode) {
                FhirDateTime bo_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bp_ = context.Operators.Convert<CqlDateTime>(bo_);
                CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                CqlDate bs_ = context.Operators.DateFrom(br_);
                Period bt_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                CqlDateTime bv_ = context.Operators.Start(bu_);
                CqlDate bw_ = context.Operators.DateFrom(bv_);
                CqlQuantity bx_ = context.Operators.Quantity(14m, "days");
                CqlDate by_ = context.Operators.Add(bw_, bx_);
                CqlInterval<CqlDate> bz_ = context.Operators.Interval(bw_, by_, true, false);
                bool? ca_ = context.Operators.In<CqlDate>(bs_, bz_, (string)default);
                return ca_;
            }

            bool? bn_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)bl_, bm_);
            return bn_;
        }


        CqlDate o_(MedicationRequest SUDMedication) {
            FhirDateTime cb_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime cc_ = context.Operators.Convert<CqlDateTime>(cb_);
            CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
            CqlDateTime ce_ = context.Operators.Start(cd_);
            CqlDate cf_ = context.Operators.DateFrom(ce_);
            return cf_;
        }

        IEnumerable<CqlDate> p_ = context.Operators.WhereSelect<MedicationRequest, CqlDate>(m_, n_, o_);
        CqlValueSet q_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet s_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
        IEnumerable<Procedure> v_ = Status_1_15_000.Instance.isProcedurePerformed(context, u_);

        bool? w_(Procedure SUDMedAdministration) {
            Encounter cg_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ch_ = [
                cg_,
            ];

            bool? ci_(Encounter FirstSUDEpisode) {
                object ck_;
                DataType cw_ = SUDMedAdministration?.Performed;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlDateTime;
                if (cy_)
                {
                    ck_ = cx_ as CqlDateTime;
                }
                else
                {
                    bool cz_ = cx_ is CqlQuantity;
                    if (cz_)
                    {
                        ck_ = cx_ as CqlQuantity;
                    }
                    else
                    {
                        bool da_ = cx_ is CqlInterval<CqlDateTime>;
                        if (da_)
                        {
                            ck_ = cx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool db_ = cx_ is CqlInterval<CqlQuantity>;
                            if (db_)
                            {
                                ck_ = cx_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ck_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.Start(cl_);
                CqlDate cn_ = context.Operators.DateFrom(cm_);
                Period co_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                CqlDateTime cq_ = context.Operators.Start(cp_);
                CqlDate cr_ = context.Operators.DateFrom(cq_);
                CqlQuantity cs_ = context.Operators.Quantity(14m, "days");
                CqlDate ct_ = context.Operators.Add(cr_, cs_);
                CqlInterval<CqlDate> cu_ = context.Operators.Interval(cr_, ct_, true, false);
                bool? cv_ = context.Operators.In<CqlDate>(cn_, cu_, (string)default);
                return cv_;
            }

            bool? cj_ = context.Operators.WhereAny<Encounter>((IEnumerable<Encounter>)ch_, ci_);
            return cj_;
        }


        CqlDate x_(Procedure SUDMedAdministration) {
            object dc_;
            DataType dg_ = SUDMedAdministration?.Performed;
            object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
            bool di_ = dh_ is CqlDateTime;
            if (di_)
            {
                dc_ = dh_ as CqlDateTime;
            }
            else
            {
                bool dj_ = dh_ is CqlQuantity;
                if (dj_)
                {
                    dc_ = dh_ as CqlQuantity;
                }
                else
                {
                    bool dk_ = dh_ is CqlInterval<CqlDateTime>;
                    if (dk_)
                    {
                        dc_ = dh_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool dl_ = dh_ is CqlInterval<CqlQuantity>;
                        if (dl_)
                        {
                            dc_ = dh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dc_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dd_ = QICoreCommon_4_0_000.Instance.toInterval(context, dc_);
            CqlDateTime de_ = context.Operators.Start(dd_);
            CqlDate df_ = context.Operators.DateFrom(de_);
            return df_;
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
                object at_;
                if (ShortActingTreatment is Procedure)
                {
                    DataType aw_ = (ShortActingTreatment as Procedure)?.Performed;
                    at_ = aw_;
                }
                else
                {
                    at_ = null;
                }
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool av_ = au_ is CqlDateTime;
                if (av_)
                {
                    object ax_;
                    if (ShortActingTreatment is Procedure)
                    {
                        DataType az_ = (ShortActingTreatment as Procedure)?.Performed;
                        ax_ = az_;
                    }
                    else
                    {
                        ax_ = null;
                    }
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    ac_ = ay_ as CqlDateTime;
                }
                else
                {
                    object ba_;
                    if (ShortActingTreatment is Procedure)
                    {
                        DataType bd_ = (ShortActingTreatment as Procedure)?.Performed;
                        ba_ = bd_;
                    }
                    else
                    {
                        ba_ = null;
                    }
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlQuantity;
                    if (bc_)
                    {
                        object be_;
                        if (ShortActingTreatment is Procedure)
                        {
                            DataType bg_ = (ShortActingTreatment as Procedure)?.Performed;
                            be_ = bg_;
                        }
                        else
                        {
                            be_ = null;
                        }
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        ac_ = bf_ as CqlQuantity;
                    }
                    else
                    {
                        object bh_;
                        if (ShortActingTreatment is Procedure)
                        {
                            DataType bk_ = (ShortActingTreatment as Procedure)?.Performed;
                            bh_ = bk_;
                        }
                        else
                        {
                            bh_ = null;
                        }
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            object bl_;
                            if (ShortActingTreatment is Procedure)
                            {
                                DataType bn_ = (ShortActingTreatment as Procedure)?.Performed;
                                bl_ = bn_;
                            }
                            else
                            {
                                bl_ = null;
                            }
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            ac_ = bm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object bo_;
                            if (ShortActingTreatment is Procedure)
                            {
                                DataType br_ = (ShortActingTreatment as Procedure)?.Performed;
                                bo_ = br_;
                            }
                            else
                            {
                                bo_ = null;
                            }
                            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                            bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                            if (bq_)
                            {
                                object bs_;
                                if (ShortActingTreatment is Procedure)
                                {
                                    DataType bu_ = (ShortActingTreatment as Procedure)?.Performed;
                                    bs_ = bu_;
                                }
                                else
                                {
                                    bs_ = null;
                                }
                                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                                ac_ = bt_ as CqlInterval<CqlQuantity>;
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
                Period am_;
                if (ShortActingTreatment is Encounter)
                {
                    Period bv_ = (ShortActingTreatment as Encounter)?.Period;
                    am_ = bv_;
                }
                else
                {
                    am_ = default;
                }
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
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
            IEnumerable<Medication> bw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bx_(Medication M) {
                Id bz_ = M?.IdElement;
                string ca_ = bz_?.Value;
                FhirString cb_;
                DataType cl_ = MR?.Medication;
                bool cm_ = cl_ is ResourceReference;
                if (cm_)
                {
                    FhirString cn_ = (cl_ as ResourceReference)?.ReferenceElement;
                    cb_ = cn_;
                }
                else
                {
                    cb_ = default;
                }
                string cc_ = cb_?.Value;
                IEnumerable<string> cd_ = context.Operators.Split(cc_, "/");
                string ce_ = context.Operators.Last<string>(cd_);
                bool? cf_ = context.Operators.Equal(ca_, ce_);
                CodeableConcept cg_ = M?.Code;
                CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
                CqlValueSet ci_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? cj_ = context.Operators.ConceptInValueSet(ch_, ci_);
                bool? ck_ = context.Operators.And(cf_, cj_);
                return ck_;
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
            IEnumerable<CqlDate> co_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> cp_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> cq_ = context.Operators.Union<CqlDate>(co_, cp_);
            CqlDate cr_ = context.Operators.Min<CqlDate>(cq_);
            CqlDate[] cs_ = [
                cr_,
            ];

            bool? ct_(CqlDate InitiationTreatmentDate) {
                FhirDateTime cv_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime cw_ = context.Operators.Convert<CqlDateTime>(cv_);
                CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_);
                CqlDateTime cy_ = context.Operators.Start(cx_);
                CqlDate cz_ = context.Operators.DateFrom(cy_);
                CqlQuantity da_ = context.Operators.Quantity(34m, "days");
                CqlDate db_ = context.Operators.Add(InitiationTreatmentDate, da_);
                CqlInterval<CqlDate> dc_ = context.Operators.Interval(InitiationTreatmentDate, db_, false, true);
                bool? dd_ = context.Operators.In<CqlDate>(cz_, dc_, (string)default);
                bool? de_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? df_ = context.Operators.And(dd_, de_);
                return df_;
            }

            bool? cu_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)cs_, ct_);
            return cu_;
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
                FhirString v_;
                DataType af_ = MR?.Medication;
                bool ag_ = af_ is ResourceReference;
                if (ag_)
                {
                    FhirString ah_ = (af_ as ResourceReference)?.ReferenceElement;
                    v_ = ah_;
                }
                else
                {
                    v_ = default;
                }
                string w_ = v_?.Value;
                IEnumerable<string> x_ = context.Operators.Split(w_, "/");
                string y_ = context.Operators.Last<string>(x_);
                bool? z_ = context.Operators.Equal(u_, y_);
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
            IEnumerable<CqlDate> ai_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> aj_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ak_ = context.Operators.Union<CqlDate>(ai_, aj_);
            CqlDate al_ = context.Operators.Min<CqlDate>(ak_);
            CqlDate[] am_ = [
                al_,
            ];

            bool? an_(CqlDate InitiationTreatmentDate) {
                FhirDateTime ap_ = LongActingMedOrder?.AuthoredOnElement;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlDate at_ = context.Operators.DateFrom(as_);
                CqlQuantity au_ = context.Operators.Quantity(34m, "days");
                CqlDate av_ = context.Operators.Add(InitiationTreatmentDate, au_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(InitiationTreatmentDate, av_, false, true);
                bool? ax_ = context.Operators.In<CqlDate>(at_, aw_, (string)default);
                bool? ay_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? az_ = context.Operators.And(ax_, ay_);
                return az_;
            }

            bool? ao_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)am_, an_);
            return ao_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isProcedurePerformed(context, k_);

        bool? m_(Procedure LongActingTreatment) {
            IEnumerable<CqlDate> ba_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> bb_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> bc_ = context.Operators.Union<CqlDate>(ba_, bb_);
            CqlDate bd_ = context.Operators.Min<CqlDate>(bc_);
            CqlDate[] be_ = [
                bd_,
            ];

            bool? bf_(CqlDate InitiationTreatmentDate) {
                object bh_;
                DataType br_ = LongActingTreatment?.Performed;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                bool bt_ = bs_ is CqlDateTime;
                if (bt_)
                {
                    bh_ = bs_ as CqlDateTime;
                }
                else
                {
                    bool bu_ = bs_ is CqlQuantity;
                    if (bu_)
                    {
                        bh_ = bs_ as CqlQuantity;
                    }
                    else
                    {
                        bool bv_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bv_)
                        {
                            bh_ = bs_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bw_ = bs_ is CqlInterval<CqlQuantity>;
                            if (bw_)
                            {
                                bh_ = bs_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bh_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                CqlDate bk_ = context.Operators.DateFrom(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(34m, "days");
                CqlDate bm_ = context.Operators.Add(InitiationTreatmentDate, bl_);
                CqlInterval<CqlDate> bn_ = context.Operators.Interval(InitiationTreatmentDate, bm_, false, true);
                bool? bo_ = context.Operators.In<CqlDate>(bk_, bn_, (string)default);
                bool? bp_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? bq_ = context.Operators.And(bo_, bp_);
                return bq_;
            }

            bool? bg_ = context.Operators.WhereAny<CqlDate>((IEnumerable<CqlDate>)be_, bf_);
            return bg_;
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
